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
            if (ValidateChildren())
            {
                string name = textBoxTrackName.Text;
                int length = int.Parse(textBoxTrackLength.Text);
                DBObjectController.StoreObject(new Song(name, length));
                MessageBox.Show("You have successfully added new track", "Success confirmation");
                ClearForm();
                LoadTrackData();
            }
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
            string text = ((TextBox)sender).Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderTrack.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else if (!IsNumeric(text))
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

        private void dataGridViewTracks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ClearCurrentErrorProvider();
            textBoxTrackNameCurrent.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTrackLengthCurrent.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void ClearCurrentErrorProvider()
        {
            errorProviderTrack.SetError(textBoxTrackNameCurrent, string.Empty);
            errorProviderTrack.SetError(textBoxTrackLengthCurrent, string.Empty);
        }

        private void dataGridViewTracks_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DBObjectController.DeleteObject(e.Row.Tag);
        }
    }
}
