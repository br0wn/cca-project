using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.PresentationLayer;

namespace Concert.PresentationLayer
{
    public partial class MainControlPanel : Form
    {

        public MainControlPanel()
        {
            InitializeComponent();
        }

        private void showConcertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConcertView concertView = new ConcertView();
            concertView.MdiParent = this;
            concertView.Show();
        }

        private void addNewConcertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewConcert newConcert = new NewConcert();
            newConcert.MdiParent = this;
            newConcert.Show();
        }

        private void showLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocation newLocation = new NewLocation();
            newLocation.MdiParent = this;
            newLocation.Show();
        }

        private void trackControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackControlPanel trackPanel = new TrackControlPanel();
            trackPanel.MdiParent = this;
            trackPanel.Show();
        }
    }
}
