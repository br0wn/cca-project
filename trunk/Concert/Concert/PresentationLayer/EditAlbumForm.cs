using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.DataAccessLayer;

namespace Concert.PresentationLayer {
    public partial class EditAlbumForm : Form
    {
        private bool editMode;
        private List<Album> albums = new List<Album>();
        private List<Track> avaliableSongsFull = new List<Track>();
        private List<Track> avaliableSongs = new List<Track>();
        private List<Track> addedSongs = new List<Track>();
        private bool albumSaved;

        public EditAlbumForm() {
            InitializeComponent();
            this.albumSaved = false;
            this.editMode = false;
            this.SetEdit(false);
            this.LoadExternalData();
            this.SetDisplayMember();
        }
        private void EditAlbumForm_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
            if (listBoxAvaliableAlbums.SelectedIndex < 0)
            {
                this.buttonEdit.Enabled = false;                
            }
            this.SetDisplayMember();
        }
        private void LoadExternalData()
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
            int albumIndex = this.listBoxAvaliableAlbums.SelectedIndex;
            Album album    = this.albums[albumIndex];

            album.Name     = albumName;
            
            album.Track.Clear();
            foreach (Track addedSong in this.addedSongs)
            {
                album.Track.Add(addedSong);
            }
            try {

                DBObjectController.SaveChanges();
            }
            catch {
                MessageBox.Show("Error while updating record");
                return;
            }
            MessageBox.Show("Album updated");
            this.SetEdit(false);
            this.albumSaved = true;
            LoadAlbumData(albumIndex);
            this.LoadExternalData();

        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            this.SetEdit(true);
        }

        private void SetEdit(bool editMode)
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
            listBoxAddedSongs.Enabled = editMode;
            listBoxAvaliableSongs.Enabled = editMode;
            buttonSave.Enabled = editMode;
            buttoncancel.Enabled = editMode;
            buttonRemoveSong.Enabled = editMode;
            buttonAddSong.Enabled = editMode;
            this.editMode = editMode;
            this.SetDisplayMember();
        }

        private void buttoncancel_Click(object sender, EventArgs e) {
            this.SetEdit(false);
        }

        private void listBoxAvaliableAlbums_Click(object sender, EventArgs e) {
            
        }
        private void ClearForm()
        {
            this.listBoxAddedSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            this.textBoxAlbumName.Clear();
        }
        private void SetListsDisplayMember()
        {
            this.listBoxAddedSongs.DisplayMember = "Name";
            
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int albumIndex = this.listBoxAvaliableAlbums.SelectedIndex;
            if (albumIndex < 0)
            {
                this.ClearForm();
                return;
            }
            Album album = this.albums[albumIndex];
            try
            {
                DBObjectController.DeleteObject(album);
            }
            catch (Exception)
            {
                    
                throw;
            }
            this.ClearAlbumData();
            this.LoadExternalData();
            this.buttonEdit.Enabled = true;
        }
        private void ClearAlbumData()
        {
            this.listBoxAddedSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            this.textBoxAlbumName.Clear();
        }
        private void LoadAlbumData(int selectedIndex)
        {
            if (selectedIndex < 0 && this.albumSaved)
            {
                this.albumSaved = false;                
                return;
            }
            else if (selectedIndex < 0 && albumSaved == false)
            {
                this.buttonEdit.Enabled = false;
                return;
            }
            this.addedSongs = null;
            this.avaliableSongs = new List<Track>();

            Album album = this.albums[selectedIndex];
            this.textBoxAlbumName.Text = album.Name;
            this.addedSongs = album.Track.ToList();
            this.avaliableSongsFull.Clear();
            this.avaliableSongsFull = DBObjectController.GetAvailableTracks().ToList();
            foreach (Track song in this.avaliableSongsFull.Where(song => !this.addedSongs.Contains(song)))
            {
                this.avaliableSongs.Add(song);
            }
            this.listBoxAddedSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxAddedSongs.DataSource = this.addedSongs;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.SetDisplayMember();
        }

        private void listBoxAvaliableAlbums_SelectedIndexChanged(object sender, EventArgs e) {
            this.LoadAlbumData(((ListBox)sender).SelectedIndex);
        }

        private void buttonRemoveSong_Click(object sender, EventArgs e) {
            MessageBox.Show("Test");
            if (this.listBoxAddedSongs.Items.Count == 0) return;
            if (this.listBoxAddedSongs.SelectedIndex < 0) return;

            int songIndex = this.listBoxAddedSongs.SelectedIndex;
            Track song = this.addedSongs[songIndex];
            this.addedSongs.RemoveAt(songIndex);
            this.avaliableSongs.Add(song);

            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxAddedSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.listBoxAddedSongs.DataSource = this.addedSongs;
            this.SetDisplayMember();

        }

        private void buttonAddSong_Click(object sender, EventArgs e) {
            if (this.listBoxAvaliableSongs.Items.Count == 0) return;
            if (this.listBoxAvaliableSongs.SelectedIndex < 0) return;

            int songIndex = this.listBoxAvaliableSongs.SelectedIndex;
            Track song = this.avaliableSongs[songIndex];
            this.avaliableSongs.RemoveAt(songIndex);
            this.addedSongs.Add(song);

            this.listBoxAvaliableSongs.DataSource = this.listBoxAddedSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.listBoxAddedSongs.DataSource = this.addedSongs;
            this.SetDisplayMember();
        }

        private void buttonRemoveSong_Click_1(object sender, EventArgs e) {           
            if (this.listBoxAddedSongs.Items.Count == 0) return;
            if (this.listBoxAddedSongs.SelectedIndex < 0) return;

            int songIndex = this.listBoxAddedSongs.SelectedIndex;
            Track song = this.addedSongs[songIndex];
            this.addedSongs.RemoveAt(songIndex);
            this.avaliableSongs.Add(song);

            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxAddedSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.listBoxAddedSongs.DataSource = this.addedSongs;
            this.SetDisplayMember();
        }

        private void EditAlbumForm_FormClosed(object sender, FormClosedEventArgs e) {
            MdiParent.MainMenuStrip.Enabled = true;
        }

        private void SetDisplayMember()
        {
            this.listBoxAddedSongs.DisplayMember = "Name";
            this.listBoxAvaliableAlbums.DisplayMember = "Name";
            this.listBoxAvaliableSongs.DisplayMember = "Name";
        }
    }
}