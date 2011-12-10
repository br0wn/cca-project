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
    public partial class ConcertChangeLocation : Form
    {
        public ConcertChangeLocation()
        {
            InitializeComponent();
            LoadLocationData();
        }

        public Location geoLocation;

        private void LoadLocationData()
        {
            dataGridViewLocation.Rows.Clear();
            //foreach (Location item in DBObjectController.GetAllLocations())
            //{
            //    DataGridViewRow row = new DataGridViewRow();

            //    string country = item.Country != null ? item.Country.Name : "N/A"; 

            //    row.CreateCells(dataGridViewLocation, new object[] { country,
            //                                                         item.Address,
            //                                                         item.PostalCode,
            //                                                         item.SeatCount });
            //    row.Tag = item;
            //    dataGridViewLocation.Rows.Add(row);
            //}
        }

        private void dataGridViewLocation_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            geoLocation = (Location)((DataGridView)sender).Rows[e.RowIndex].Tag;
            this.Close();
        }
    }
}
