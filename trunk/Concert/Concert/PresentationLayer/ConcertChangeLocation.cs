﻿using System;
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
            foreach (DBObjectDefinition.Location item in DBObjectController.GetAllLocations())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewLocation, new object[] {
                                                                        item.Country,
                                                                        item.Address,
                                                                        item.PostalCode,
                                                                        item.SeatCount });
                row.Tag = item;
                dataGridViewLocation.Rows.Add(row);
            }
        }

        private void dataGridViewLocation_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            geoLocation = (DBObjectDefinition.Location)((DataGridView)sender).Rows[e.RowIndex].Tag;
            this.Close();
        }
    }
}