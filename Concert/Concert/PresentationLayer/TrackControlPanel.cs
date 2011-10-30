using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Concert.DataAccessLayer;
using System.IO;

namespace Concert.PresentationLayer
{
    public partial class TrackControlPanel : Form
    {
        private Regex digits = new Regex(@"^\d+$");

        public TrackControlPanel()
        {
            InitializeComponent();
            LoadTrackData();
            dataGridViewTracks.Select();
        }

        public TrackControlPanel(Track song)
        {
            InitializeComponent();
            LoadTrackData();
        }

        private void LoadTrackData()
        {
            dataGridViewTracks.Rows.Clear();
            foreach (Track item in DBObjectController.GetAllTracks())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewTracks, new object[] { item.Name, item.Length });
                row.Tag = item;
                dataGridViewTracks.Rows.Add(row);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (ErrorProviderSet())
            {
                string name = textBoxTrackName.Text;
                int length = int.Parse(textBoxTrackLength.Text);
                bool trackUploaded = !string.IsNullOrEmpty(textBoxPath.Text);
                DBObjectController.StoreObject(new Track(name, length, trackUploaded, textBoxPath.Text));
                MessageBox.Show("You have successfully added new track", "Success confirmation");
                ClearForm();
                LoadTrackData();
            }
        }

        private bool ErrorProviderSet()
        {
            return errorProviderTrack.GetError(textBoxTrackLength) == string.Empty &&
                   errorProviderTrack.GetError(textBoxTrackName)   == string.Empty;
        }

        private void ClearForm()
        {
            buttonPlay.Visible = false;
            textBoxTrackName.Clear();
            textBoxTrackLength.Clear();
            textBoxPath.Clear();
        }

        private void textBoxTrackName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text == string.Empty)
            {
                errorProviderTrack.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else
            {
                errorProviderTrack.SetError((TextBox)sender, string.Empty);
            }
        }

        private void textBoxTrackLength_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || (((TextBox)sender).Text) == string.Empty)
            {
                errorProviderTrack.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else if (!IsNumeric((((TextBox)sender).Text)))
            {
                errorProviderTrack.SetError((TextBox)sender, "Only numeric value is allowed");
            }
            else
            {
                errorProviderTrack.SetError((TextBox)sender, string.Empty);
            }
        }

        private bool IsNumeric(string text)
        {
            return digits.IsMatch(text);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.URL == textBoxPath.Text)
            {
                axWindowsMediaPlayer.URL = string.Empty;
            }
            ClearForm();
            errorProviderTrack.SetError(textBoxTrackName, string.Empty);
            errorProviderTrack.SetError(textBoxTrackLength, string.Empty);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewTracks.CurrentRow != null)
            {
                ValidateCurrentSelection();
                if (NoErrorProviderMsg())
                {
                    Song song = (Song)dataGridViewTracks.CurrentRow.Tag;
                    song.Name = textBoxTrackNameCurrent.Text;
                    song.Length = int.Parse(textBoxTrackLengthCurrent.Text);
                    DBObjectController.StoreObject(song);
                    LoadTrackData();
                }
            }
            else
            {
                ClearCurrentForm();
            }
        }

        private bool NoErrorProviderMsg()
        {
            return errorProviderTrack.GetError(textBoxTrackNameCurrent)   == string.Empty &&
                   errorProviderTrack.GetError(textBoxTrackLengthCurrent) == string.Empty;
        }

        private void ValidateCurrentSelection()
        {
            ValidateCurrentName();
            ValidateCurrentLength();
        }

        private void ValidateCurrentName()
        {
            string text = textBoxTrackNameCurrent.Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderTrack.SetError(textBoxTrackNameCurrent, "Empty fields are not allowed");
            }
            else
            {
                errorProviderTrack.SetError(textBoxTrackNameCurrent, string.Empty);
            }
        }

        private void ValidateCurrentLength()
        {
            string text = textBoxTrackLengthCurrent.Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderTrack.SetError(textBoxTrackLengthCurrent, "Empty fields are not allowed");
            }
            else if (!IsNumeric(text))
            {
                errorProviderTrack.SetError(textBoxTrackLengthCurrent, "Only numeric value is allowed");
            }
            else
            {
                errorProviderTrack.SetError(textBoxTrackLengthCurrent, string.Empty);
            }
        }

        private void ClearCurrentErrorProvider()
        {
            errorProviderTrack.SetError(textBoxTrackNameCurrent, string.Empty);
            errorProviderTrack.SetError(textBoxTrackLengthCurrent, string.Empty);
        }

        private void dataGridViewTracks_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).CurrentRow != null)
            {
                ClearCurrentErrorProvider();
                textBoxTrackNameCurrent.Text = ((DataGridView)sender).CurrentRow.Cells[0].Value.ToString();
                textBoxTrackLengthCurrent.Text = ((DataGridView)sender).CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                ClearCurrentForm();
            }
        }

        private void ClearCurrentForm()
        {
            textBoxTrackNameCurrent.Clear();
            textBoxTrackLengthCurrent.Clear();
        }

        private void TrackControlPanel_Load(object sender, EventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = false;
            }
        }

        private void TrackControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = true;
            }
            
        }

        private void dataGridViewTracks_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Song s = (Song)e.Row.Tag;
            foreach (Album album in DBObjectController.GetAlbumsByTrack((Song)e.Row.Tag))
            {
                album.Songs.Remove(s);
                DBObjectController.StoreObject(album);
            }
            if ( !string.IsNullOrEmpty(s.TrackPath))
            {
                string url = @"..\..\" + s.TrackPath;
                if (File.Exists(url))
                {
                    File.Delete(url);
                }
            }
            DBObjectController.DeleteObject(e.Row.Tag);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadDialog = new OpenFileDialog();
            uploadDialog.Filter = "Audio files (*.mp3)|*.mp3";
            uploadDialog.InitialDirectory = @"C:\";

            if (uploadDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = uploadDialog.FileName;
                buttonPlay.Visible = true;
            }
            else
            {
                buttonPlay.Visible = false;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = textBoxPath.Text;
        }

        private void dataGridViewTracks_DoubleClick(object sender, EventArgs e)
        {
            Song track = (Song)dataGridViewTracks.CurrentRow.Tag;
            if (!string.IsNullOrEmpty(track.TrackPath))
            {
                string[] subPath = Application.ExecutablePath.Split('\\');
                string url = "";
                for (int i = 0; i < subPath.Length - 3; i++)
                {
                    url += subPath[i] + "\\";
                }
                url += track.TrackPath;
                if ( File.Exists(url))
                {
                    axWindowsMediaPlayer.URL = url;
                }
            }
        }
    }
}
