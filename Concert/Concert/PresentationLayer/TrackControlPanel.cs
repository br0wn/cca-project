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
using Concert.DBObjectDefinition;

namespace Concert.PresentationLayer
{
    public partial class TrackControlPanel : Form
    {
        private Regex digits = new Regex(@"\d+");

        public TrackControlPanel()
        {
            InitializeComponent();
            LoadTrackData();
            dataGridViewTracks.Select();
        }

        private void LoadTrackData()
        {
            dataGridViewTracks.Rows.Clear();
            foreach (Song item in DBObjectController.GetAllTracks())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewTracks, new object[] { 
                                                                    item.Name,
                                                                    item.Length });
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
                DBObjectController.StoreObject(new Song(name, length));
                MessageBox.Show("You have successfully added new track", "Success confirmation");
                ClearForm();
                LoadTrackData();
            }
        }

        private bool ErrorProviderSet()
        {
            return errorProviderTrack.GetError(textBoxTrackLength) == string.Empty &&
                   errorProviderTrack.GetError(textBoxTrackName) == string.Empty;
        }

        private void ClearForm()
        {
            textBoxTrackName.Clear();
            textBoxTrackLength.Clear();
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
            textBoxTrackName.Text = string.Empty;
            textBoxTrackLength.Text = string.Empty;
            errorProviderTrack.SetError(textBoxTrackName, string.Empty);
            errorProviderTrack.SetError(textBoxTrackLength, string.Empty);
        }

        private void buttonSave_Click(object sender, EventArgs e)
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

        private bool NoErrorProviderMsg()
        {
            return (errorProviderTrack.GetError(textBoxTrackNameCurrent) == string.Empty &&
                     errorProviderTrack.GetError(textBoxTrackLengthCurrent) == string.Empty );
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

        private void dataGridViewTracks_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            foreach (Album album in DBObjectController.GetAlbumsByTrack((Song)e.Row.Tag))
            {
                Song s = (Song)e.Row.Tag;
                album.Songs.Remove(s);
                DBObjectController.StoreObject(album);
            }
            DBObjectController.DeleteObject(e.Row.Tag);
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
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void TrackControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }
    }
}
