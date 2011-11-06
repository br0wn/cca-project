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
            Icon = Properties.Resources.pikachu;
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

		private void trackControlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TrackControlPanel trackPanel = new TrackControlPanel();
			trackPanel.MdiParent = this;
			trackPanel.Show();
		}

		private void newBandToolStripMenuItem_Click( object sender, EventArgs e )
		{
			NewBandForm newBandForm = new NewBandForm();
			newBandForm.MdiParent = this;
			newBandForm.Show();
		}

		private void editBandToolStripMenuItem_Click( object sender, EventArgs e )
		{
			EditBandForm editBandForm = new EditBandForm( );
			editBandForm.MdiParent = this;
			editBandForm.Show( );
		}

		private void locationControlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewLocation newLocation = new NewLocation();
			newLocation.MdiParent = this;
			newLocation.Show();
		}

		private void newArtistToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewArtistForm newArtistForm = new NewArtistForm();
			newArtistForm.MdiParent = this;
			newArtistForm.Show();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditArtist editArtistForm = new EditArtist();
			editArtistForm.MdiParent = this;
			editArtistForm.Show();
		}

        private void addNewAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAlbumForm newAlbumForm = new NewAlbumForm();
            newAlbumForm.MdiParent = this;
            newAlbumForm.Show();
        }

        private void newAlbumToolStripMenuItem_Click(object sender, EventArgs e) {
            EditAlbumForm editAlbumForm = new EditAlbumForm();
            editAlbumForm.MdiParent = this;
            editAlbumForm.Show();
        }

        private void countryControlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryControlPanel countryControlPanel = new CountryControlPanel();
            countryControlPanel.MdiParent = this;
            countryControlPanel.Show();
        }

        private void instrumentControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstrumentControl instrumentControl = new InstrumentControl();
            instrumentControl.MdiParent = this;
            instrumentControl.Show();
        }

	}
}
