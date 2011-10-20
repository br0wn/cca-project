using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.DataAccessLayer;
using Concert.DBObjectDefinition;

namespace Concert.PresentationLayer
{
    public partial class ConcertView : Form
    {
        public ConcertView()
        {
            InitializeComponent();
            LoadConcertData();
        }

        private void LoadConcertData()
        {
            dataGridViewConcerts.Rows.Clear();
            foreach (DBObjectDefinition.Concert item in DBObjectController.GetAllConcerts())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewConcerts, new object[] { item.Name, item.TicketPrice.ToString(), item.Date.ToString("dd.MM.yyyy.") });
                row.Tag = item;
                dataGridViewConcerts.Rows.Add(row);
            }
        }

        private void RefreshBandData()
        {
            if (dataGridViewConcerts.CurrentRow != null)
            {
                dataGridViewBand.Rows.Clear();
                DBObjectDefinition.Concert c = (DBObjectDefinition.Concert)((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag);
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
                foreach (Artist artist in ((DBObjectDefinition.Band)dataGridViewBand.CurrentRow.Tag).Artist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewBand, new object[] { artist.Firstname + " " + artist.Lastname,
                                                                     artist.BirthDate.ToString("dd.MM.YYYY"),
                                                                     artist.Instruments.ToString()});
                    row.Tag = artist;
                    dataGridViewArtist.Rows.Add(row);
                }
            }
        }

        private void dataGridViewConcerts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DBObjectController.DeleteObject(e.Row.Tag);
        }

        private void dataGridViewConcerts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAssignLocation_Click(object sender, EventArgs e)
        {
            ConcertChangeLocation changeLocation = new ConcertChangeLocation();
            changeLocation.ShowDialog();
            if (changeLocation.geoLocation != null)
            {
                ((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag).GeoLocation = changeLocation.geoLocation;
                DBObjectController.StoreObject((DBObjectDefinition.Concert)dataGridViewConcerts.CurrentRow.Tag);
                LoadConcertData();
            }
        }

        private void dataGridViewConcerts_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).CurrentRow != null)
            {
                if (((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation != null)
                {
                    textBoxCountry.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.Country;
                    textBoxAddress.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.Address;
                    textBoxPostalCode.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.PostalCode.ToString();
                    textBoxSeatCount.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).CurrentRow.Tag).GeoLocation.SeatCount.ToString();
                }
                else
                {
                    textBoxCountry.Text = string.Empty;
                    textBoxAddress.Text = string.Empty;
                    textBoxPostalCode.Text = string.Empty;
                    textBoxSeatCount.Text = string.Empty;
                }
                RefreshBandData();
            }
        }

        private void dataGridViewBand_SelectionChanged(object sender, EventArgs e)
        {
            RefreshArtistData();
        }

        private void ConcertView_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void ConcertView_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }
    }
}
