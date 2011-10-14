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

        public EditAlbumForm() {
            InitializeComponent();
            this.editMode = false;
            this.setEdit(false);
            listBoxAvaliableAlbums.DataSource = DBObjectController.GetAllAlbums().ToList();
        }

        private void EditAlbumForm_Load(object sender, EventArgs e) {
            //this.listBoxAvaliableAlbums.DataSource = DB
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

        private void listBoxAvaliableAlbums_SelectedIndexChanged(object sender, EventArgs e) {

        }

    }
}