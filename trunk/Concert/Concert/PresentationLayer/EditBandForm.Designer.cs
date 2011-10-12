namespace Concert.PresentationLayer
{
	partial class EditBandForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			this.listBoxBands = new System.Windows.Forms.ListBox( );
			this.groupBoxAlbums = new System.Windows.Forms.GroupBox( );
			this.listBoxAvailableAlbums = new System.Windows.Forms.ListBox( );
			this.buttonRemoveAlbum = new System.Windows.Forms.Button( );
			this.listBoxAddedAlbums = new System.Windows.Forms.ListBox( );
			this.buttonAddAlbum = new System.Windows.Forms.Button( );
			this.groupBoxArtists = new System.Windows.Forms.GroupBox( );
			this.listBoxAvailableArtists = new System.Windows.Forms.ListBox( );
			this.buttonRemoveArtist = new System.Windows.Forms.Button( );
			this.listBoxAddedArtists = new System.Windows.Forms.ListBox( );
			this.buttonAddArtist = new System.Windows.Forms.Button( );
			this.textBox1 = new System.Windows.Forms.TextBox( );
			this.labelBandName = new System.Windows.Forms.Label( );
			this.groupBoxBandInfo = new System.Windows.Forms.GroupBox( );
			this.buttonCancel = new System.Windows.Forms.Button( );
			this.buttonEdit = new System.Windows.Forms.Button( );
			this.buttonSave = new System.Windows.Forms.Button( );
			this.groupBoxAlbums.SuspendLayout( );
			this.groupBoxArtists.SuspendLayout( );
			this.groupBoxBandInfo.SuspendLayout( );
			this.SuspendLayout( );
			// 
			// listBoxBands
			// 
			this.listBoxBands.FormattingEnabled = true;
			this.listBoxBands.Location = new System.Drawing.Point( 13, 13 );
			this.listBoxBands.Name = "listBoxBands";
			this.listBoxBands.Size = new System.Drawing.Size( 361, 121 );
			this.listBoxBands.TabIndex = 0;
			this.listBoxBands.SelectedIndexChanged += new System.EventHandler( this.listBoxBands_SelectedIndexChanged );
			// 
			// groupBoxAlbums
			// 
			this.groupBoxAlbums.Controls.Add( this.listBoxAvailableAlbums );
			this.groupBoxAlbums.Controls.Add( this.buttonRemoveAlbum );
			this.groupBoxAlbums.Controls.Add( this.listBoxAddedAlbums );
			this.groupBoxAlbums.Controls.Add( this.buttonAddAlbum );
			this.groupBoxAlbums.Location = new System.Drawing.Point( 26, 186 );
			this.groupBoxAlbums.Name = "groupBoxAlbums";
			this.groupBoxAlbums.Size = new System.Drawing.Size( 304, 123 );
			this.groupBoxAlbums.TabIndex = 11;
			this.groupBoxAlbums.TabStop = false;
			this.groupBoxAlbums.Text = "Bands";
			// 
			// listBoxAvailableAlbums
			// 
			this.listBoxAvailableAlbums.FormattingEnabled = true;
			this.listBoxAvailableAlbums.Location = new System.Drawing.Point( 178, 19 );
			this.listBoxAvailableAlbums.Name = "listBoxAvailableAlbums";
			this.listBoxAvailableAlbums.Size = new System.Drawing.Size( 120, 95 );
			this.listBoxAvailableAlbums.TabIndex = 3;
			// 
			// buttonRemoveAlbum
			// 
			this.buttonRemoveAlbum.Location = new System.Drawing.Point( 132, 40 );
			this.buttonRemoveAlbum.Name = "buttonRemoveAlbum";
			this.buttonRemoveAlbum.Size = new System.Drawing.Size( 40, 23 );
			this.buttonRemoveAlbum.TabIndex = 5;
			this.buttonRemoveAlbum.Text = ">";
			this.buttonRemoveAlbum.UseVisualStyleBackColor = true;
			this.buttonRemoveAlbum.Click += new System.EventHandler( this.buttonRemoveAlbum_Click );
			// 
			// listBoxAddedAlbums
			// 
			this.listBoxAddedAlbums.FormattingEnabled = true;
			this.listBoxAddedAlbums.Location = new System.Drawing.Point( 6, 19 );
			this.listBoxAddedAlbums.Name = "listBoxAddedAlbums";
			this.listBoxAddedAlbums.Size = new System.Drawing.Size( 120, 95 );
			this.listBoxAddedAlbums.TabIndex = 2;
			// 
			// buttonAddAlbum
			// 
			this.buttonAddAlbum.Location = new System.Drawing.Point( 132, 69 );
			this.buttonAddAlbum.Name = "buttonAddAlbum";
			this.buttonAddAlbum.Size = new System.Drawing.Size( 40, 23 );
			this.buttonAddAlbum.TabIndex = 4;
			this.buttonAddAlbum.Text = "<";
			this.buttonAddAlbum.UseVisualStyleBackColor = true;
			this.buttonAddAlbum.Click += new System.EventHandler( this.buttonAddAlbum_Click );
			// 
			// groupBoxArtists
			// 
			this.groupBoxArtists.Controls.Add( this.listBoxAvailableArtists );
			this.groupBoxArtists.Controls.Add( this.buttonRemoveArtist );
			this.groupBoxArtists.Controls.Add( this.listBoxAddedArtists );
			this.groupBoxArtists.Controls.Add( this.buttonAddArtist );
			this.groupBoxArtists.Location = new System.Drawing.Point( 26, 57 );
			this.groupBoxArtists.Name = "groupBoxArtists";
			this.groupBoxArtists.Size = new System.Drawing.Size( 304, 123 );
			this.groupBoxArtists.TabIndex = 10;
			this.groupBoxArtists.TabStop = false;
			this.groupBoxArtists.Text = "Artists";
			// 
			// listBoxAvailableArtists
			// 
			this.listBoxAvailableArtists.FormattingEnabled = true;
			this.listBoxAvailableArtists.Location = new System.Drawing.Point( 178, 19 );
			this.listBoxAvailableArtists.Name = "listBoxAvailableArtists";
			this.listBoxAvailableArtists.Size = new System.Drawing.Size( 120, 95 );
			this.listBoxAvailableArtists.TabIndex = 3;
			// 
			// buttonRemoveArtist
			// 
			this.buttonRemoveArtist.Location = new System.Drawing.Point( 132, 40 );
			this.buttonRemoveArtist.Name = "buttonRemoveArtist";
			this.buttonRemoveArtist.Size = new System.Drawing.Size( 40, 23 );
			this.buttonRemoveArtist.TabIndex = 5;
			this.buttonRemoveArtist.Text = ">";
			this.buttonRemoveArtist.UseVisualStyleBackColor = true;
			this.buttonRemoveArtist.Click += new System.EventHandler( this.buttonRemoveArtist_Click );
			// 
			// listBoxAddedArtists
			// 
			this.listBoxAddedArtists.FormattingEnabled = true;
			this.listBoxAddedArtists.Location = new System.Drawing.Point( 6, 19 );
			this.listBoxAddedArtists.Name = "listBoxAddedArtists";
			this.listBoxAddedArtists.Size = new System.Drawing.Size( 120, 95 );
			this.listBoxAddedArtists.TabIndex = 2;
			// 
			// buttonAddArtist
			// 
			this.buttonAddArtist.Location = new System.Drawing.Point( 132, 69 );
			this.buttonAddArtist.Name = "buttonAddArtist";
			this.buttonAddArtist.Size = new System.Drawing.Size( 40, 23 );
			this.buttonAddArtist.TabIndex = 4;
			this.buttonAddArtist.Text = "<";
			this.buttonAddArtist.UseVisualStyleBackColor = true;
			this.buttonAddArtist.Click += new System.EventHandler( this.buttonAddArtist_Click );
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point( 97, 20 );
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size( 221, 20 );
			this.textBox1.TabIndex = 9;
			// 
			// labelBandName
			// 
			this.labelBandName.AutoSize = true;
			this.labelBandName.Location = new System.Drawing.Point( 27, 23 );
			this.labelBandName.Name = "labelBandName";
			this.labelBandName.Size = new System.Drawing.Size( 64, 13 );
			this.labelBandName.TabIndex = 8;
			this.labelBandName.Text = "Band name:";
			// 
			// groupBoxBandInfo
			// 
			this.groupBoxBandInfo.Controls.Add( this.buttonCancel );
			this.groupBoxBandInfo.Controls.Add( this.buttonEdit );
			this.groupBoxBandInfo.Controls.Add( this.buttonSave );
			this.groupBoxBandInfo.Controls.Add( this.groupBoxAlbums );
			this.groupBoxBandInfo.Controls.Add( this.groupBoxArtists );
			this.groupBoxBandInfo.Controls.Add( this.textBox1 );
			this.groupBoxBandInfo.Controls.Add( this.labelBandName );
			this.groupBoxBandInfo.Location = new System.Drawing.Point( 13, 144 );
			this.groupBoxBandInfo.Name = "groupBoxBandInfo";
			this.groupBoxBandInfo.Size = new System.Drawing.Size( 360, 356 );
			this.groupBoxBandInfo.TabIndex = 12;
			this.groupBoxBandInfo.TabStop = false;
			this.groupBoxBandInfo.Text = "Band info";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point( 255, 315 );
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size( 75, 23 );
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler( this.buttonCancel_Click );
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point( 107, 316 );
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size( 142, 23 );
			this.buttonEdit.TabIndex = 13;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler( this.buttonEdit_Click );
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point( 26, 316 );
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size( 75, 23 );
			this.buttonSave.TabIndex = 12;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler( this.buttonSave_Click );
			// 
			// EditBandForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 390, 512 );
			this.Controls.Add( this.groupBoxBandInfo );
			this.Controls.Add( this.listBoxBands );
			this.Name = "EditBandForm";
			this.Text = "EditBandForm";
			this.groupBoxAlbums.ResumeLayout( false );
			this.groupBoxArtists.ResumeLayout( false );
			this.groupBoxBandInfo.ResumeLayout( false );
			this.groupBoxBandInfo.PerformLayout( );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxBands;
		private System.Windows.Forms.GroupBox groupBoxAlbums;
		private System.Windows.Forms.ListBox listBoxAvailableAlbums;
		private System.Windows.Forms.Button buttonRemoveAlbum;
		private System.Windows.Forms.ListBox listBoxAddedAlbums;
		private System.Windows.Forms.Button buttonAddAlbum;
		private System.Windows.Forms.GroupBox groupBoxArtists;
		private System.Windows.Forms.ListBox listBoxAvailableArtists;
		private System.Windows.Forms.Button buttonRemoveArtist;
		private System.Windows.Forms.ListBox listBoxAddedArtists;
		private System.Windows.Forms.Button buttonAddArtist;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelBandName;
		private System.Windows.Forms.GroupBox groupBoxBandInfo;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonSave;
	}
}