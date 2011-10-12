using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.DBObjectDefinition;
using Concert.DataAccessLayer;

namespace Concert.PresentationLayer
{
    public partial class NewBandForm : Form
    {
        public NewBandForm()
        {
            InitializeComponent();

			//DBObjectController.StoreObject(
			//    new Artist("Petar", "Grdi", new DateTime(1989, 10, 25) )
			//);
			//DBObjectController.StoreObject(
			//    new Artist( "Ivan", "Smrdi", new DateTime( 1989, 1, 20 ) )
			//);
			//DBObjectController.StoreObject(
			//    new Album( "Ljubav i dva reketa" )
			//);
			//DBObjectController.StoreObject(
			//    new Album( "Pod kisnom lipom" )
			//);

			loadExternalData();
        }

        private List<Artist> availableArtists = new List<Artist>();
        private List<Album> availableAlbums = new List<Album>();

        private List<Artist> addedArtists = new List<Artist>();
        private List<Album> addedAlbums = new List<Album>();

        private void loadExternalData()
        {
			this.availableAlbums = DBObjectController.GetAllAlbums().ToList();
			this.availableArtists = DBObjectController.GetAllArtists().ToList();

			this.listBoxAvailableAlbums.DataSource = this.availableAlbums;
			this.listBoxAvailableArtists.DataSource = this.availableArtists;
        }

        // internals


		//private void refreshArtists()
		//{

		//}

		//private void refreshAlbums()
		//{

		//}


        // EVENTS

        private void buttonRemoveArtist_Click(object sender, EventArgs e)
        {
			if( this.listBoxAddedArtists.Items.Count == 0 ) return;

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
			if ( this.listBoxAvailableArtists.Items.Count == 0 ) return;

			int artistIndex =this.listBoxAvailableArtists.SelectedIndex;
			Artist artist = this.availableArtists[ artistIndex ];
			this.availableArtists.RemoveAt( artistIndex );
			this.addedArtists.Add( artist );

			this.listBoxAvailableArtists.DataSource = this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = this.availableArtists;
			this.listBoxAddedArtists.DataSource = this.addedArtists;
        }

        private void buttonRemoveAlbum_Click(object sender, EventArgs e)
        {
			if( this.listBoxAddedAlbums.Items.Count == 0 ) return;

			int albumIndex = this.listBoxAddedAlbums.SelectedIndex;
			Album album = this.addedAlbums[ albumIndex ];
			this.addedAlbums.RemoveAt( albumIndex );
			this.availableAlbums.Add( album );

			this.listBoxAvailableAlbums.DataSource = this.listBoxAddedAlbums.DataSource = null;
			this.listBoxAvailableAlbums.DataSource = this.availableAlbums;
			this.listBoxAddedAlbums.DataSource = this.addedAlbums;
        }

        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
			if ( this.listBoxAvailableAlbums.Items.Count == 0 ) return;

			int albumIndex =this.listBoxAvailableAlbums.SelectedIndex;
			Album album = this.availableAlbums[ albumIndex ];
			this.availableAlbums.RemoveAt( albumIndex );
			this.addedAlbums.Add( album );

			this.listBoxAvailableAlbums.DataSource = this.listBoxAddedAlbums.DataSource = null;
			this.listBoxAvailableAlbums.DataSource = this.availableAlbums;
			this.listBoxAddedAlbums.DataSource = this.addedAlbums;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
			string bandName = this.textBox1.Text.Trim();

			if( bandName == string.Empty )
			{
				MessageBox.Show("Band title cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			} 

			List<Artist> artists = DBObjectController.GetAllArtists().ToList();
			List<Album> albums = DBObjectController.GetAllAlbums().ToList();

			List<Artist> deletedArtists = new List<Artist>();
			List<Album> deletedAlbums = new List<Album>();
			
			foreach( Artist artist in this.addedArtists )
			{
				if( artists.Contains( artist ) ) continue;
				deletedArtists.Add( artist );
			}

			foreach( Album album in this.addedAlbums )
			{
				if( albums.Contains( album ) ) continue;
				deletedAlbums.Add( album );
			}

			if( !(deletedAlbums.Count == 0 && deletedArtists.Count == 0) )
			{
				string message = "Some of the chosen artists or albums have been deleted!\n\n";
				if( deletedAlbums.Count != 0 )
				{
					message += "Albums:\n";
					message += deletedAlbums.ToString();
					message += "\n\n";
				}
				if ( deletedArtists.Count != 0 )
				{
					message += "Artists:\n";
					message += deletedArtists.ToString( );
					message += "\n\n";
				}

				MessageBox.Show( message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			Band band = new Band( bandName, availableArtists, availableAlbums );
			MessageBox.Show("Band successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information ); 

			this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
