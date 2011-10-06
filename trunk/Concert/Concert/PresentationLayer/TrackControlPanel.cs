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


    }
}
