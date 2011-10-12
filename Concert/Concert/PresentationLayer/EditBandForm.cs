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
		private bool editMode = false;

		private List<Band> bands = new List<Band>();

		
		public EditBandForm( )
		{
			InitializeComponent( );
			
		}

		// internals

		private void getBands( )
		{
			this.bands = null;
			this.bands = DBObjectController.GetAllBands().ToList();
			this.listBoxBands.DataSource = this.bands;
		}

		//events

		private void listBoxBands_SelectedIndexChanged( object sender, EventArgs e )
		{
			
		}

		private void buttonRemoveArtist_Click( object sender, EventArgs e )
		{

		}

		private void buttonAddArtist_Click( object sender, EventArgs e )
		{

		}

		private void buttonRemoveAlbum_Click( object sender, EventArgs e )
		{

		}

		private void buttonAddAlbum_Click( object sender, EventArgs e )
		{

		}

		private void buttonEdit_Click( object sender, EventArgs e )
		{

		}

		private void buttonSave_Click( object sender, EventArgs e )
		{

		}

		private void buttonCancel_Click( object sender, EventArgs e )
		{
			
		}
	}
}
