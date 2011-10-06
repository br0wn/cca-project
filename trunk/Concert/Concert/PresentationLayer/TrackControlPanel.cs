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

        }
    }
}
