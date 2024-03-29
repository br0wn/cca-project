﻿using System;
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
    public partial class ConcertView : Form
    {
        private Regex digits = new Regex(@"^\d+$");
        private Regex date = new Regex(@"^\d\d?[.]\d\d?[.]\d{4}$");

        public ConcertView()
        {
            InitializeComponent();
            dateTimePickerConcertDateTo.Value = DateTime.Today;
            LoadConcertData();
        }

        private void LoadConcertData()
        {
            dataGridViewConcerts.Rows.Clear();
            IEnumerable<DBObjectDefinition.Concert> nekaj = DBObjectController.GetAllConcerts();
            foreach (DBObjectDefinition.Concert item in DBObjectController.GetAllConcerts())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewConcerts, new object[] { item.Name, item.TicketPrice.ToString(), item.Date.ToString("dd.MM.yyyy.") });
                row.Tag = item;
                dataGridViewConcerts.Rows.Add(row);
            }
        }

        private void RefreshLocationData()
        {
            DBObjectDefinition.Concert concert = (DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag;

            textBoxCountry.Text = concert.GeoLocation.Country.Name;
            textBoxAddress.Text = concert.GeoLocation.Address;
            textBoxPostalCode.Text = concert.GeoLocation.PostalCode.ToString();
            textBoxSeatCount.Text = concert.GeoLocation.SeatCount.ToString();
        }

        private void RefreshBandData()
        {
            dataGridViewBand.Rows.Clear();
            dataGridViewArtist.Rows.Clear();
            comboBoxAlbums.DataSource = null;
            if (dataGridViewConcerts.CurrentRow != null)
            {
                DBObjectDefinition.Concert c = (DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag;
                foreach (Band band in ((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag).Bands)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewBand, new object[] { band.Name });
                    row.Tag = band;
                    dataGridViewBand.Rows.Add(row);
                }
            }
        }

        private void RefreshArtistData()
        {
            if (dataGridViewBand.CurrentRow != null)
            {
                dataGridViewArtist.Rows.Clear();
                foreach (Artist artist in ((Band)dataGridViewBand.CurrentRow.Tag).Artists)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    string date = artist.BirthDate.ToString("dd.MM.yyyy");
                    row.CreateCells(dataGridViewArtist, new object[] { artist.FirstName + " " + artist.LastName,
                                                                       artist.BirthDate.ToString("dd.MM.yyyy")});
                    row.Tag = artist;
                    dataGridViewArtist.Rows.Add(row);
                }
            }
        }

        private void RefreshTrackData()
        {
            dataGridViewTracks.Rows.Clear();
            Album a = (Album)comboBoxAlbums.SelectedItem;
            foreach (Track track in DBObjectController.GetTracksByAlbum(a.ID))//((Album)comboBoxAlbums.SelectedItem).Tracks)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dataGridViewArtist, new object[] { track.Name, track.Length.ToString() });
                row.Tag = track;
                dataGridViewTracks.Rows.Add(row);
            }
        }

        private void dataGridViewConcerts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DBObjectController.DeleteObject((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag);
        }

        private void buttonAssignLocation_Click(object sender, EventArgs e)
        {
            if (dataGridViewConcerts.CurrentRow != null)
            {
                ConcertChangeLocation changeLocation = new ConcertChangeLocation();
                changeLocation.ShowDialog();
                if (changeLocation.geoLocation != null)
                {
                    ((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag).GeoLocation = changeLocation.geoLocation;
                    DBObjectController.StoreObject((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag);
                    RefreshLocationData();
                }
            }
        }

        private void dataGridViewConcerts_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).CurrentRow != null)
            {
                ClearErrorProvider();
                textBoxCurrentName.Text = ((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag).Name;
                textBoxCurrentDate.Text = ((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag).Date.ToString("dd.MM.yyyy");
                textBoxCurrentTicketPrice.Text = ((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag).TicketPrice.ToString();

                if (((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation != null)
                {
                    if (((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.Country != null)
                    {
                        textBoxCountry.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.Country.Name;
                    }
                    else
                    {
                        textBoxCountry.Text = "N/A";
                    }
                    textBoxAddress.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.Address;
                    textBoxPostalCode.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.PostalCode.ToString();
                    textBoxSeatCount.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.SeatCount.ToString();
                }
                else
                {
                    ClearCurrentLocation();
                }
                RefreshBandData();
            }
            else 
            {
                ClearErrorProvider();
                ClearCurrentForm();
            }
        }

        private void ClearErrorProvider()
        {
            errorProviderConcert.SetError(textBoxCurrentName, string.Empty);
            errorProviderConcert.SetError(textBoxCurrentDate, string.Empty);
            errorProviderConcert.SetError(textBoxCurrentTicketPrice, string.Empty);
        }

        private void ClearCurrentForm()
        {
            ClearCurrentSelection();
            ClearCurrentLocation();
        }

        private void ClearCurrentSelection()
        {
            textBoxCurrentName.Clear();
            textBoxCurrentTicketPrice.Clear();
            textBoxCurrentDate.Clear();
        }

        private void ClearCurrentLocation()
        {
            textBoxCountry.Clear();
            textBoxAddress.Clear();
            textBoxPostalCode.Clear();
            textBoxSeatCount.Clear();
        }

        private void dataGridViewBand_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBand.CurrentRow != null)
            {
                RefreshArtistData();
                comboBoxAlbums.DataSource = null;
                comboBoxAlbums.DataSource = ((Band)dataGridViewBand.CurrentRow.Tag).Albums;
                comboBoxAlbums.DisplayMember = "Name";
            }
            else
            {
                dataGridViewArtist.Rows.Clear();
                comboBoxAlbums.DataSource = null;
                dataGridViewTracks.Rows.Clear();
            }
        }

        private void ConcertView_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void ConcertView_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }

        private void dataGridViewArtist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PresentationLayer.EditArtist editArtistForm = new PresentationLayer.EditArtist((Artist)dataGridViewArtist.CurrentRow.Tag);
            editArtistForm.ShowDialog();
            RefreshArtistData();
        }

        private void textBoxCurrentName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text == string.Empty)
            {
                errorProviderConcert.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else
            {
                errorProviderConcert.SetError((TextBox)sender, string.Empty);
            }
        }

        private void textBoxCurrentTicketPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || (((TextBox)sender).Text) == string.Empty)
            {
                errorProviderConcert.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else if (!IsNumeric((((TextBox)sender).Text)))
            {
                errorProviderConcert.SetError((TextBox)sender, "Only numeric value is allowed");
            }
            else
            {
                errorProviderConcert.SetError((TextBox)sender, string.Empty);
            }
        }

        private void textBoxCurrentDate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text == string.Empty)
            {
                errorProviderConcert.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else if (!IsDate((((TextBox)sender).Text)))
            {
                errorProviderConcert.SetError((TextBox)sender, "Only numeric value is allowed");
            }
            else
            {
                errorProviderConcert.SetError((TextBox)sender, string.Empty);
            }
        }

        private bool IsNumeric(string text)
        {
            return digits.IsMatch(text);
        }

        private bool IsDate(string text)
        {
            return date.IsMatch(text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewConcerts.CurrentRow != null)
            {
                ValidateChildren();
                if (NoErrorProviderMsg())
                {
                    DBObjectDefinition.Concert concert = ((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag);
                    concert.Date        = DateTime.Parse(textBoxCurrentDate.Text);
                    concert.Name        = textBoxCurrentName.Text;
                    concert.TicketPrice = int.Parse(textBoxCurrentTicketPrice.Text);

                    DBObjectController.StoreObject(concert);

                    dataGridViewConcerts.CurrentRow.Cells[0].Value = textBoxCurrentName.Text;
                    dataGridViewConcerts.CurrentRow.Cells[1].Value = int.Parse(textBoxCurrentTicketPrice.Text);
                    dataGridViewConcerts.CurrentRow.Cells[2].Value = concert.Date.ToString("dd.MM.yyyy.");
                }
            }
            else
            {
                ClearCurrentForm();
                ClearErrorProvider();
            }
        }

        private bool NoErrorProviderMsg()
        {
            return errorProviderConcert.GetError(textBoxCurrentName) == string.Empty &&
                   errorProviderConcert.GetError(textBoxCurrentTicketPrice) == string.Empty &&
                   errorProviderConcert.GetError(textBoxCurrentDate) == string.Empty;
        }

        private void comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlbums.SelectedItem != null)
            {
                RefreshTrackData();
            }
            else
            {
                comboBoxAlbums.Items.Clear();
                dataGridViewTracks.Rows.Clear();
            }
        }

        private void dataGridViewTracks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Track s = (Track)dataGridViewTracks.CurrentRow.Tag;
            TrackControlPanel tcp = new TrackControlPanel((Track)dataGridViewTracks.CurrentRow.Tag);
            tcp.ShowDialog();
            RefreshTrackData();
        }

        private void RefreshConcertData()
        {
            if (ValidateTicketPrice() && dateTimePickerConcertDateFrom != null && dateTimePickerConcertDateTo != null)
            {
                dataGridViewConcerts.Rows.Clear();
                string from = string.IsNullOrEmpty(textBoxFindConcertTicketPriceFrom.Text) ? "0" : textBoxFindConcertTicketPriceFrom.Text;
                string to   = string.IsNullOrEmpty(textBoxFindConcertTicketPriceTo.Text) ? "1000" : textBoxFindConcertTicketPriceTo.Text;
                foreach (DBObjectDefinition.Concert item in DBObjectController.GetCustomConcerts(textBoxFindConcertName.Text,
                                                                               int.Parse(from),
                                                                               int.Parse(to),
                                                                               dateTimePickerConcertDateFrom.Value,
                                                                               dateTimePickerConcertDateTo.Value))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewConcerts, new object[] { item.Name, item.TicketPrice.ToString(), item.Date.ToString("dd.MM.yyyy.") });
                    row.Tag = item;
                    dataGridViewConcerts.Rows.Add(row);
                }
                RefreshBandData();
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            RefreshConcertData();
            if (dataGridViewConcerts.CurrentRow == null)
            {
                ClearCurrentForm();
            }
        }

        private bool ValidateTicketPrice()
        {
            string from = string.IsNullOrEmpty(textBoxFindConcertTicketPriceFrom.Text) ? "0" : textBoxFindConcertTicketPriceFrom.Text; 
            string to   = string.IsNullOrEmpty(textBoxFindConcertTicketPriceTo.Text) ? "1000" : textBoxFindConcertTicketPriceTo.Text; 
            return digits.IsMatch(from) && digits.IsMatch(to) ? true : false;
        }

        private void dataGridViewBand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Band band = (Band)dataGridViewBand.CurrentRow.Tag;
            EditBandForm editBandForm = new EditBandForm(band);
            editBandForm.ShowDialog();
            RefreshBandData();
        }

        private void dataGridViewBand_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DBObjectDefinition.Concert concert = (DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag;
            
            Band band = (Band)dataGridViewBand.CurrentRow.Tag;
            concert.Bands.Remove(band);
            
            DBObjectController.StoreObject(concert);
        }

        private void buttonAddBands_Click(object sender, EventArgs e)
        {
            if (dataGridViewConcerts.CurrentRow != null)
            {
                ConcertAddBand hireBand = new ConcertAddBand((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag);
                hireBand.ShowDialog();
                DBObjectController.StoreObject((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag);
                RefreshBandData();
            }
        }
    }
}
