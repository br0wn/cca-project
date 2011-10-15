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
        }

        private void EditAlbumForm_Load(object sender, EventArgs e) {
        }
        private void loadExternalData()
        {
            this.albums = null;
            this.albums = DBObjectController.GetAllAlbums().ToList();
            this.listBoxAvaliableAlbums.DataSource = null;
            this.listBoxAvaliableAlbums.DataSource = this.albums;
        }
        private void buttonSave_Click(object sender, EventArgs e) {
            this.setEdit(false);
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            this.setEdit(true);
        }

        private void setEdit(bool editMode)
        {
            if (editMode == true) {
                listBoxAvaliableAlbums.Enabled = false;
                buttonEdit.Enabled = true;
            }
            else
            {
                listBoxAvaliableAlbums.Enabled = true;
            }
            textBoxAlbumName.Enabled = editMode;
            listBoxAddedSgons.Enabled = editMode;
            listBoxAvaliableSongs.Enabled = editMode;
            buttonSave.Enabled = editMode;
            buttoncancel.Enabled = editMode;
            buttonRemoveSong.Enabled = editMode;
            buttonAddSong.Enabled = editMode;
            this.editMode = editMode;
        }

        private void buttoncancel_Click(object sender, EventArgs e) {
            this.setEdit(false);
        }

        private void listBoxAvaliableAlbums_Click(object sender, EventArgs e) {
            
        }
        private void loadAlbumSongs(int albumIndex)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e) {

        }
        private void loadAlbumData(int selectedIndex)
        {
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

    }
}