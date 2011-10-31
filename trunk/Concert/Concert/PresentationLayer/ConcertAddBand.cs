using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.DataAccessLayer;

namespace Concert.PresentationLayer
{
    public partial class ConcertAddBand : Form
    {
        List<Band> bands;

        private Concert concert;

        public ConcertAddBand()
        {
            InitializeComponent();
        }

        public ConcertAddBand(Concert concert)
        {
            this.concert = concert;
            InitializeComponent();
            bands = new List<Band>();
            checkedListBoxBands.CheckOnClick = true;
            foreach (Band band in DBObjectController.GetAdjectiveBands(concert.Band))
            {
                bands.Add(band);
                checkedListBoxBands.Items.Add(band.Name);
            }
        }

        private void ConcertAddBand_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (int index in checkedListBoxBands.CheckedIndices)
            {
                concert.Band.Add(bands[index]);
            }
            DBObjectController.SaveChanges();
        }
    }
}
