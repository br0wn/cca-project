using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.DBObjectDefinition;
using Concert.DataAccessLayer;

namespace Concert.PresentationLayer {
    public partial class EditAlbumForm : Form
    {
        private bool editMode;
        private List<Album> albums = new List<Album>();
        private List<Song> avaliableSongsFull = new List<Song>();
        private List<Song> avaliableSongs = new List<Song>();
        private List<Song> addedSongs = new List<Song>();

        public EditAlbumForm() {
            InitializeComponent();

            this.editMode = false;
            this.setEdit(false);
            this.loadExternalData();
            this.SetDisplayMember();
        }

        private void EditAlbumForm_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
            this.SetDisplayMember();
        }
        private void loadExternalData()
        {
            this.albums = null;
            this.albums = DBObjectController.GetAllAlbums().ToList();
            this.listBoxAvaliableAlbums.DataSource = null;
            this.listBoxAvaliableAlbums.DataSource = this.albums;
            this.SetDisplayMember();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string albumName = this.textBoxAlbumName.Text.Trim();
            if (albumName == string.Empty)
            {
                MessageBox.Show("Album name cannot be empty");
                return;
            }
            List<Song> songs = DBObjectController.GetAllTracks().ToList();
            int albumIndex = this.listBoxAvaliableAlbums.SelectedIndex;
            Album album = this.albums[albumIndex];

            album.Name = albumName;
            foreach (Song song in this.addedSongs)
            {
                if (!album.Songs.Contains(song))
                {
                    album.AddTrack(song);
                }
            }
            try
            {
                DBObjectController.StoreObject(album);
            }
            catch
            {

                MessageBox.Show("Error while updating record");
                return;
            }
            MessageBox.Show("Album updated");
            this.setEdit(false);
            loadAlbumData(albumIndex);
            this.loadExternalData();

        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            this.setEdit(true);
        }

        private void setEdit(bool editMode)
        {
            if (editMode == true) {
                listBoxAvaliableAlbums.Enabled = false;
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = false;

            }
            else
            {
                listBoxAvaliableAlbums.Enabled = true;
                buttonDelete.Enabled = true;
            }
            textBoxAlbumName.Enabled = editMode;
            listBoxAddedSgons.Enabled = editMode;
            listBoxAvaliableSongs.Enabled = editMode;
            buttonSave.Enabled = editMode;
            buttoncancel.Enabled = editMode;
            buttonRemoveSong.Enabled = editMode;
            buttonAddSong.Enabled = editMode;
            this.editMode = editMode;
            this.SetDisplayMember();
        }

        private void buttoncancel_Click(object sender, EventArgs e) {
            this.setEdit(false);
        }

        private void listBoxAvaliableAlbums_Click(object sender, EventArgs e) {
            
        }
        private void clearForm()
        {
            this.listBoxAddedSgons.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            this.textBoxAlbumName.Clear();
        }
        private void SetListsDisplayMember()
        {
            this.listBoxAddedSgons.DisplayMember = "";
            
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int albumIndex = this.listBoxAvaliableAlbums.SelectedIndex;
            if (albumIndex < 0)
            {
                this.clearForm();
                return;
            }
            Album album = this.albums[albumIndex];
            foreach (Band band in DBObjectController.GetBandsByAlbum(album))
            {
                band.Albums.Remove(album);
                DBObjectController.StoreObject(band);
            }
            try
            {
                DBObjectController.DeleteObject(album);
            }
            catch (Exception)
            {
                    
                throw;
            }
            this.ClearAlbumData();
            this.loadExternalData();
        }
        private void ClearAlbumData()
        {
            this.listBoxAddedSgons.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            this.textBoxAlbumName.Clear();
        }
        private void loadAlbumData(int selectedIndex)
        {
            if (selectedIndex < 0)
            {
                return;
            }
            this.addedSongs = null;
            this.avaliableSongs = new List<Song>();

            Album album = this.albums[selectedIndex];
            this.textBoxAlbumName.Text = album.Name;
            this.addedSongs = album.Songs;
            this.avaliableSongsFull.Clear();
            this.avaliableSongsFull = DBObjectController.GetAllTracks().ToList();
            foreach (Song song in this.avaliableSongsFull)
            {
                if (!this.addedSongs.Contains(song))
                {
                    this.avaliableSongs.Add(song);
                }
            }
            this.listBoxAddedSgons.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxAddedSgons.DataSource = this.addedSongs;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
        }

        private void listBoxAvaliableAlbums_SelectedIndexChanged(object sender, EventArgs e) {
            this.loadAlbumData(((ListBox)sender).SelectedIndex);
        }

        private void buttonRemoveSong_Click(object sender, EventArgs e) {
            MessageBox.Show("Test");
            if (this.listBoxAddedSgons.Items.Count == 0) return;
            if (this.listBoxAddedSgons.SelectedIndex < 0) return;

            int songIndex = this.listBoxAddedSgons.SelectedIndex;
            Song song = this.addedSongs[songIndex];
            this.addedSongs.RemoveAt(songIndex);
            this.avaliableSongs.Add(song);

            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxAddedSgons.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.listBoxAddedSgons.DataSource = this.addedSongs;
            this.SetDisplayMember();

        }

        private void buttonAddSong_Click(object sender, EventArgs e) {
            if (this.listBoxAvaliableSongs.Items.Count == 0) return;
            if (this.listBoxAvaliableSongs.SelectedIndex < 0) return;

            int songIndex = this.listBoxAvaliableSongs.SelectedIndex;
            Song song = this.avaliableSongs[songIndex];
            this.avaliableSongs.RemoveAt(songIndex);
            this.addedSongs.Add(song);

            this.listBoxAvaliableSongs.DataSource = this.listBoxAddedSgons.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.listBoxAddedSgons.DataSource = this.addedSongs;
            this.SetDisplayMember();
        }

        private void buttonRemoveSong_Click_1(object sender, EventArgs e) {           
            if (this.listBoxAddedSgons.Items.Count == 0) return;
            if (this.listBoxAddedSgons.SelectedIndex < 0) return;

            int songIndex = this.listBoxAddedSgons.SelectedIndex;
            Song song = this.addedSongs[songIndex];
            this.addedSongs.RemoveAt(songIndex);
            this.avaliableSongs.Add(song);

            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxAddedSgons.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.listBoxAddedSgons.DataSource = this.addedSongs;
            this.SetDisplayMember();
        }

        private void EditAlbumForm_FormClosed(object sender, FormClosedEventArgs e) {
            MdiParent.MainMenuStrip.Enabled = true;
        }

        private void SetDisplayMember()
        {
            this.listBoxAddedSgons.DisplayMember = "Name";
            this.listBoxAvaliableAlbums.DisplayMember = "Name";
            this.listBoxAvaliableSongs.DisplayMember = "Name";
        }
    }
}