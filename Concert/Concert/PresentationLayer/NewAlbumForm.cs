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
    public partial class NewAlbumForm : Form {

        public NewAlbumForm() {
            InitializeComponent();
            this.loadExternalData();
            this.SetDisplayMember();
        }
        private List<Song> avaliableSongs = new List<Song>();
        private List<Song> addedSongs = new List<Song>();
        private List<Band> avaliableBands = new List<Band>();

        private void loadExternalData()
        {
            this.avaliableSongs = DBObjectController.GetAllTracks().ToList();
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.avaliableBands = DBObjectController.GetAllBands().ToList();
            this.listBoxAvaliableBands.DataSource = this.avaliableBands;
            this.SetDisplayMember();
        }

        private void buttonCancle_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonRemoveSong_Click(object sender, EventArgs e) {
            if (this.listBoxSongs.Items.Count == 0)
            {
                return;
            }

            int songIndex = this.listBoxSongs.SelectedIndex;
            Song song = this.addedSongs[songIndex];
            this.addedSongs.RemoveAt(songIndex);
            this.avaliableSongs.Add(song);

            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.listBoxSongs.DataSource = this.addedSongs;
            this.SetDisplayMember();

        }

        private void buttonAddSong_Click(object sender, EventArgs e) {
            if (this.listBoxAvaliableSongs.Items.Count == 0)
            {
                return;
            }

            int songIndex = this.listBoxAvaliableSongs.SelectedIndex;
            Song song = this.avaliableSongs[songIndex];
            this.avaliableSongs.RemoveAt(songIndex);
            this.addedSongs.Add(song);

            this.listBoxSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
            this.listBoxSongs.DataSource = this.addedSongs;
            this.SetDisplayMember();

        }

        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            string albumName = this.textBoxAlbumName.Text.Trim();
            if (albumName == string.Empty)
            {
                MessageBox.Show("Album name cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Album album = new Album(albumName);
            foreach (Song song in this.addedSongs)
            {
                album.AddTrack(song);
            }           
            try
            {
                if (checkBoxAddalbum.Checked)
                {
                    int bandIndex = this.listBoxAvaliableBands.SelectedIndex;
                    Band band = this.avaliableBands[bandIndex];
                    //band.Albums.Add(album);
                    band.AddAlbum(album);
                    DBObjectController.StoreObject(band);
                }
                DBObjectController.StoreObject(album);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while addign album");
                return;
            }
            MessageBox.Show("Album added successfully!");
            this.clearForm();
        }

        private void clearForm()
        {
            this.textBoxAlbumName.Clear();
            this.listBoxSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            this.avaliableSongs.Clear();
            this.addedSongs.Clear();
            this.loadExternalData();
        }

        private void NewAlbumForm_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void NewAlbumForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }
        private void SetDisplayMember()
        {
            this.listBoxAvaliableSongs.DisplayMember = "Name";
            this.listBoxSongs.DisplayMember = "Name";
            this.listBoxAvaliableBands.DisplayMember = "Name";
        }
    }
}
