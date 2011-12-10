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
    public partial class NewBandForm : Form
    {
       public NewBandForm()
        {
            InitializeComponent();
			loadExternalData();
        }

        private List<Artist> availableArtists = new List<Artist>();
        private List<Artist> addedArtists = new List<Artist>();

		// internals

        private void loadExternalData()
        {
            //this.availableArtists = DBObjectController.GetAllArtists().ToList();

			this.listBoxAvailableArtists.DataSource = this.availableArtists;
        }

		private void refresh( )
		{
			this.textBox1.Text = "";
			this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = null;

			this.addedArtists = new List<Artist>( );
            //this.availableArtists = DBObjectController.GetAllArtists( ).ToList( );

			this.listBoxAvailableArtists.DataSource = this.availableArtists;
			this.listBoxAddedArtists.DataSource = this.addedArtists;

		}

        // EVENTS

        private void buttonRemoveArtist_Click(object sender, EventArgs e)
        {
            if (this.listBoxAddedArtists.Items.Count == 0 || listBoxAddedArtists.SelectedIndex < 0) return;

			int artistIndex = this.listBoxAddedArtists.SelectedIndex;
			Artist artist = this.addedArtists[ artistIndex ];
			this.addedArtists.RemoveAt( artistIndex );
			this.availableArtists.Add( artist );

			this.listBoxAvailableArtists.DataSource = this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = this.availableArtists;
			this.listBoxAddedArtists.DataSource = this.addedArtists;
        }

        private void buttonAddArtist_Click(object sender, EventArgs e)
        {
			if ( this.listBoxAvailableArtists.Items.Count == 0 || listBoxAvailableArtists.SelectedIndex < 0) return;

			int artistIndex =this.listBoxAvailableArtists.SelectedIndex;
			Artist artist = this.availableArtists[ artistIndex ];
			this.availableArtists.RemoveAt( artistIndex );
			this.addedArtists.Add( artist );

			this.listBoxAvailableArtists.DataSource = this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = this.availableArtists;
			this.listBoxAddedArtists.DataSource = this.addedArtists;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
			string bandName = this.textBox1.Text.Trim();

			if( bandName == string.Empty )
			{
				MessageBox.Show("Band title cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			} 

            //List<Artist> artists = DBObjectController.GetAllArtists().ToList();
			List<Artist> deletedArtists = new List<Artist>();
			
            //foreach( Artist artist in this.addedArtists )
            //{
            //    if( artists.Contains( artist ) ) continue;
            //    deletedArtists.Add( artist );
            //}

			if( deletedArtists.Count != 0 )
			{
				string message = "Some of the chosen artists or albums have been deleted!\n\n";
				message += "Artists:\n";
				message += deletedArtists.ToString( );
				message += "\n\n";

				MessageBox.Show( message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

            Band band = new Band();
            //band.Name = bandName;
			foreach(Artist artist in addedArtists )
			{
                //band.Artist.Add( artist );
			}

			try{
                //DBObjectController.StoreObject(band);
			}
			catch(Exception ex){
				MessageBox.Show( "Error while updating record: \n\n"+ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			MessageBox.Show("Band successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information );

			refresh( );
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void NewBandForm_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void NewBandForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }
    }
}
