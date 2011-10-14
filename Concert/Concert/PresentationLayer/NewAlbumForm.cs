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
        }
        private List<Song> avaliableSongs = new List<Song>();
        private List<Song> addedSongs = new List<Song>();

        private void loadExternalData()
        {
            this.avaliableSongs = DBObjectController.GetAllTracks().ToList();
            this.listBoxAvaliableSongs.DataSource = this.avaliableSongs;
        }

        private void buttonCancle_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonRemoveSong_Click(object sender, EventArgs e) {

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
        }
    }
}
