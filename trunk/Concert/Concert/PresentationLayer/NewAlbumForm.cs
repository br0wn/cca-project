﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Concert.DBObjectDefinition;
using Concert.DataAccessLayer;

namespace Concert.PresentationLayer {
    public partial class NewAlbumForm : Form {

        public NewAlbumForm() {
            InitializeComponent();
            this.LoadExternalData();
            this.SetDisplayMember();
        }
        //private List<Song> availableSongs = new List<Song>();
        //private List<Song> addedSongs = new List<Song>();
        //private List<Band> availableBands = new List<Band>();

        private void LoadExternalData()
        {
            //this.availableSongs = DBObjectController.GetAvailableTracks().ToList();
            //this.listBoxAvaliableSongs.DataSource = this.availableSongs;
            //this.availableBands = DBObjectController.GetAllBands().ToList();
            //this.listBoxAvaliableBands.DataSource = this.availableBands;
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
            //Song song = this.addedSongs[songIndex];
            //this.addedSongs.RemoveAt(songIndex);
            //this.availableSongs.Add(song);

            this.listBoxAvaliableSongs.DataSource = null;
            this.listBoxSongs.DataSource = null;
            //this.listBoxAvaliableSongs.DataSource = this.availableSongs;
            //this.listBoxSongs.DataSource = this.addedSongs;
            this.SetDisplayMember();

        }

        private void buttonAddSong_Click(object sender, EventArgs e) {
            if (this.listBoxAvaliableSongs.Items.Count == 0)
            {
                return;
            }

            int songIndex = this.listBoxAvaliableSongs.SelectedIndex;
            //Song song = this.availableSongs[songIndex];
            //this.availableSongs.RemoveAt(songIndex);
            //this.addedSongs.Add(song);

            this.listBoxSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            //this.listBoxAvaliableSongs.DataSource = this.availableSongs;
            //this.listBoxSongs.DataSource = this.addedSongs;
            this.SetDisplayMember();

        }

        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            if (listBoxAvaliableBands.SelectedIndex >= 0)
            {
                string albumName = this.textBoxAlbumName.Text.Trim();
                if (albumName == string.Empty)
                {
                    MessageBox.Show("Album name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Album album = new Album(albumName);
                ////foreach (Song song in this.addedSongs)
                //{
                //    album.AddTrack(song);
                //}
                //int bandIndex = this.listBoxAvaliableBands.SelectedIndex;
                //Band band = this.availableBands[bandIndex];
                ////band.Albums.Add(album);
                //band.AddAlbum(album);

                try
                {
                    //DBObjectController.StoreObject(album);
                    //DBObjectController.StoreObject(band);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding album");
                    return;
                }
                MessageBox.Show("Album added successfully!");
                this.ClearForm();
            }
            else
            {
                MessageBox.Show("Please select valid band, or add new band if one does not exist.", "Selected band error");
            }
        }

        private void ClearForm()
        {
            this.textBoxAlbumName.Clear();
            this.listBoxSongs.DataSource = null;
            this.listBoxAvaliableSongs.DataSource = null;
            //this.availableSongs.Clear();
            //this.addedSongs.Clear();
            this.LoadExternalData();
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
