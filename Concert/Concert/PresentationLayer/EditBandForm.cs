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
	public partial class EditBandForm : Form
	{
		private bool editMode;
		private bool EditMode
		{
			set
			{
				this.editMode = 
				this.buttonSave.Enabled =
				this.buttonCancel.Enabled =
				this.textBoxBandName.Enabled = 
				this.listBoxAddedArtists.Enabled = 
				this.listBoxAvailableArtists.Enabled =
				this.buttonAddArtist.Enabled =
				this.buttonRemoveArtist.Enabled =
				this.buttonDeleteAlbum.Enabled =
				this.listBoxBands.Enabled = value;

				this.listBoxBands.Enabled =
				this.buttonDelete.Enabled =
				this.buttonEdit.Enabled = !(value);
			}
			get
			{
				return this.editMode;
			}
		}

		private List<Band> bands = new List<Band>();
		private List<Artist> availableArtistsFullList = new List<Artist>();
		private List<Album> albums = new List<Album>( );

		private List<Artist> availableArtists = new List<Artist>();
		private List<Artist> addedArtists = new List<Artist>();

		
		public EditBandForm( )
		{
			InitializeComponent( );

			setListsDisplayMember( );
			getBands();

			this.EditMode = false;
		}

		public EditBandForm( Band band )
		{
			InitializeComponent( );

			setListsDisplayMember( );
			getBands( );

			int index = this.bands.IndexOf( band );
			if ( index >= 0 && index < this.bands.Count )
			{
				this.listBoxBands.SelectedIndex = index;
			}
			else
			{
				MessageBox.Show( "Band passed as argument does not exist! Selecting first band in list", "Warrning" );
			}

			this.EditMode = false;
		}

		// internals

		private void getBands( )
		{
			this.bands = null;
			this.bands = DBObjectController.GetAllBands().ToList();
			this.listBoxBands.DataSource = null;
			this.listBoxBands.DataSource = this.bands;
		}

		private void setListsDisplayMember( )
		{
			this.listBoxBands.DisplayMember = "Name";
			this.listBoxAddedArtists.DisplayMember = "FullName";
			this.listBoxAvailableArtists.DisplayMember = "FullName";
		}

		private void refreshArtistsFullList()
		{
			this.availableArtistsFullList.Clear();
			this.availableArtistsFullList = DBObjectController.GetAllArtists( ).ToList( );
		}

		private void refreshArtistsLists( )
		{
			this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = null;
			this.listBoxAddedArtists.DataSource = this.addedArtists;
			this.listBoxAvailableArtists.DataSource = this.availableArtists;

			setListsDisplayMember( );
		}

		private void refreshAlbumsList( )
		{
			this.listBoxAlbums.DataSource = null;
			this.listBoxAlbums.DataSource = this.albums;
			this.listBoxAlbums.DisplayMember = "Name";
		}

		private void loadBandData( int selectedIndex )
		{
			// dodat provjere selectedIndex-a i broja bendova
			if ( selectedIndex < 0 ) return;

			this.addedArtists = null;
			this.availableArtists = new List<Artist>();

			Band band = this.bands[ selectedIndex ];
			this.textBoxBandName.Text = band.Name;
			this.addedArtists = band.Artist;
			
			refreshArtistsFullList();
			foreach(Artist artist in this.availableArtistsFullList)
			{
				if( !this.addedArtists.Contains(artist) )
				{
					this.availableArtists.Add(artist);
				}
			}

			this.albums = new List<Album>( );
			foreach( Album album in this.bands[ selectedIndex ].Albums)
			{
				this.albums.Add( album );
			}

			refreshArtistsLists( );
			refreshAlbumsList( );
		}

		private void clearBandInfo( )
		{
			this.textBoxBandName.Text = "";
			this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = null;
			this.listBoxAlbums.DataSource = null;
			
		}

		//events

		private void listBoxBands_SelectedIndexChanged( object sender, EventArgs e )
		{
			loadBandData( ((ListBox)sender).SelectedIndex );
		}

		private void buttonRemoveArtist_Click( object sender, EventArgs e )
		{
			if ( this.listBoxAddedArtists.Items.Count == 0 ) return;
			if ( this.listBoxAddedArtists.SelectedIndex < 0 ) return;

			int artistIndex = this.listBoxAddedArtists.SelectedIndex;
			Artist artist = this.addedArtists[ artistIndex ];
			this.addedArtists.RemoveAt( artistIndex );
			this.availableArtists.Add( artist );

			refreshArtistsLists( );
		}

		private void buttonAddArtist_Click( object sender, EventArgs e )
		{
			if ( this.listBoxAvailableArtists.Items.Count == 0 ) return;
			if ( this.listBoxAvailableArtists.SelectedIndex < 0 ) return;

			int artistIndex =this.listBoxAvailableArtists.SelectedIndex;
			Artist artist = this.availableArtists[ artistIndex ];
			this.availableArtists.RemoveAt( artistIndex );
			this.addedArtists.Add( artist );

			refreshArtistsLists( );
		}

		private void buttonEdit_Click( object sender, EventArgs e )
		{
			if ( this.listBoxBands.SelectedIndex < 0 ) return;
			this.EditMode = true;
		}

		private void buttonSave_Click( object sender, EventArgs e )
		{
			string bandName = this.textBoxBandName.Text.Trim( );

			if ( bandName == string.Empty )
			{
				MessageBox.Show( "Band title cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			List<Artist> artists = DBObjectController.GetAllArtists( ).ToList( );
			List<Artist> deletedArtists = new List<Artist>( );

			foreach ( Artist artist in this.addedArtists )
			{
				if ( artists.Contains( artist ) ) continue;
				deletedArtists.Add( artist );
			}

			if ( deletedArtists.Count != 0 )
			{
				string message = "Some of the chosen artists or albums have been deleted!\n\n";
				message += "Artists:\n";
				message += deletedArtists.ToString( );
				message += "\n\n";

				MessageBox.Show( message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			int bandIndex = this.listBoxBands.SelectedIndex;
			Band band = this.bands[ bandIndex ];

			band.Name = bandName;
			foreach ( Artist artist in this.addedArtists )
			{
				if ( band.Artist.Contains( artist ) ) continue;
				band.AddArtist( artist );
			}

			foreach ( Album album in band.Albums )
			{
				if ( this.albums.Contains( album ) ) continue;
				band.Albums.Remove( album );
			}

			try
			{
				DBObjectController.StoreObject( band );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "Error while updating record: \n\n" + ex.ToString( ), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			MessageBox.Show( "Band successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information ); 

			this.EditMode = false;
			//loadBandData( bandIndex );
			
			this.listBoxBands.DataSource = null;
			this.listBoxBands.DataSource = bands;
			this.listBoxBands.SelectedIndex = bandIndex;

			setListsDisplayMember( );
		}

		private void buttonCancel_Click( object sender, EventArgs e )
		{
			this.EditMode = false;
			loadBandData( this.listBoxBands.SelectedIndex );
		}

		private void buttonDelete_Click( object sender, EventArgs e )
		{
			int selectedIndex = this.listBoxBands.SelectedIndex;
			if ( selectedIndex < 0 ) return;

			Band band = this.bands[ selectedIndex ];

			try
			{
				List<Concert.DBObjectDefinition.Concert> concerts = DBObjectController.GetConcertsByBand( band ).ToList( );
				foreach ( Concert.DBObjectDefinition.Concert concert in concerts )
				{
					concert.Bands.Remove( band );
					DBObjectController.StoreObject( concert );
				}

				foreach ( Album album in band.Albums )
				{
					DBObjectController.DeleteObject( album );
				}
				DBObjectController.DeleteObject( band );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "Cannot delete object!\n\n" + ex.ToString( ), "Error" );
				return;
			}

			bands.RemoveAt( selectedIndex );

			this.listBoxBands.DataSource = null;
			this.listBoxBands.DataSource = bands;

			this.listBoxBands.SelectedIndex = ( bands.Count == 0 ) ? -1 : 0 ;
			if ( this.bands.Count == 0 )
			{
				clearBandInfo( );
			}

			setListsDisplayMember( );
		}

		private void buttonDeleteAlbum_Click( object sender, EventArgs e )
		{
			int selectedIndex = this.listBoxAlbums.SelectedIndex;
			if ( selectedIndex < 0 ) return;

			this.albums.RemoveAt( selectedIndex );
			refreshAlbumsList( );
		}

		private void EditBandForm_Load( object sender, EventArgs e )
		{
			MdiParent.MainMenuStrip.Enabled = false;
		}

		private void EditBandForm_FormClosed( object sender, FormClosedEventArgs e )
		{
			MdiParent.MainMenuStrip.Enabled = true;
		}
	}
}
