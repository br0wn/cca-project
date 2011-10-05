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

        private void dataGridViewConcerts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DBObjectController.DeleteObject(e.Row.Tag);
        }

        private void dataGridViewConcerts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (((DBObjectDefinition.Concert)((DataGridView)sender).Rows[e.RowIndex].Tag).GeoLocation != null)
            {
                textBoxCountry.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).Rows[e.RowIndex].Tag).GeoLocation.Country;
                textBoxAddress.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).Rows[e.RowIndex].Tag).GeoLocation.Address;
                textBoxPostalCode.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).Rows[e.RowIndex].Tag).GeoLocation.PostalCode.ToString();
                textBoxSeatCount.Text = ((DBObjectDefinition.Concert)((DataGridView)sender).Rows[e.RowIndex].Tag).GeoLocation.SeatCount.ToString();
            }
            else 
            {
                textBoxCountry.Text = string.Empty;
                textBoxAddress.Text = string.Empty;
                textBoxPostalCode.Text = string.Empty;
                textBoxSeatCount.Text = string.Empty;
            }
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
    }
}
