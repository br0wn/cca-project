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
				this.buttonRemoveArtist.Enabled = value;

				this.listBoxBands.Enabled =
				this.buttonEdit.Enabled = !(value);
			}
			get
			{
				return this.editMode;
			}
		}

		private List<Band> bands = new List<Band>();
		private List<Artist> availableArtistsFullList = new List<Artist>();

		private List<Artist> availableArtists = new List<Artist>();
		private List<Artist> addedArtists = new List<Artist>();

		
		public EditBandForm( )
		{
			InitializeComponent( );
			getBands();

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

		private void refreshArtistsFullList()
		{
			this.availableArtistsFullList.Clear();
			this.availableArtistsFullList = DBObjectController.GetAllArtists( ).ToList( );
		}

		private void loadBandData( int selectedIndex )
		{
			// dodat provjere selectedIndex-a i broja bendova

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

			this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = null;
			this.listBoxAddedArtists.DataSource = this.addedArtists;
			this.listBoxAvailableArtists.DataSource = this.availableArtists;
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

			this.listBoxAvailableArtists.DataSource = this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = this.availableArtists;
			this.listBoxAddedArtists.DataSource = this.addedArtists;
		}

		private void buttonAddArtist_Click( object sender, EventArgs e )
		{
			if ( this.listBoxAvailableArtists.Items.Count == 0 ) return;
			if ( this.listBoxAvailableArtists.SelectedIndex < 0 ) return;

			int artistIndex =this.listBoxAvailableArtists.SelectedIndex;
			Artist artist = this.availableArtists[ artistIndex ];
			this.availableArtists.RemoveAt( artistIndex );
			this.addedArtists.Add( artist );

			this.listBoxAvailableArtists.DataSource = this.listBoxAddedArtists.DataSource = null;
			this.listBoxAvailableArtists.DataSource = this.availableArtists;
			this.listBoxAddedArtists.DataSource = this.addedArtists;
		}

		private void buttonEdit_Click( object sender, EventArgs e )
		{
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
			loadBandData( bandIndex );
		}

		private void buttonCancel_Click( object sender, EventArgs e )
		{
			this.EditMode = false;
			loadBandData( this.listBoxBands.SelectedIndex );
		}
	}
}
