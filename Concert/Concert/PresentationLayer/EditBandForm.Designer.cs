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
			this.textBoxBandName = new System.Windows.Forms.TextBox( );
			this.labelBandName = new System.Windows.Forms.Label( );
			this.groupBoxBandInfo = new System.Windows.Forms.GroupBox( );
			this.label2 = new System.Windows.Forms.Label( );
			this.label1 = new System.Windows.Forms.Label( );
			this.listBoxAvailableArtists = new System.Windows.Forms.ListBox( );
			this.buttonCancel = new System.Windows.Forms.Button( );
			this.buttonRemoveArtist = new System.Windows.Forms.Button( );
			this.buttonEdit = new System.Windows.Forms.Button( );
			this.listBoxAddedArtists = new System.Windows.Forms.ListBox( );
			this.buttonAddArtist = new System.Windows.Forms.Button( );
			this.buttonSave = new System.Windows.Forms.Button( );
			this.buttonDelete = new System.Windows.Forms.Button( );
			this.label3 = new System.Windows.Forms.Label( );
			this.buttonDeleteAlbum = new System.Windows.Forms.Button( );
			this.listBoxAlbums = new System.Windows.Forms.ListBox( );
			this.groupBoxBandInfo.SuspendLayout( );
			this.SuspendLayout( );
			// 
			// listBoxBands
			// 
			this.listBoxBands.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.listBoxBands.FormattingEnabled = true;
			this.listBoxBands.Location = new System.Drawing.Point( 13, 13 );
			this.listBoxBands.Name = "listBoxBands";
			this.listBoxBands.Size = new System.Drawing.Size( 248, 121 );
			this.listBoxBands.TabIndex = 0;
			this.listBoxBands.SelectedIndexChanged += new System.EventHandler( this.listBoxBands_SelectedIndexChanged );
			// 
			// textBoxBandName
			// 
			this.textBoxBandName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBoxBandName.Location = new System.Drawing.Point( 100, 31 );
			this.textBoxBandName.Name = "textBoxBandName";
			this.textBoxBandName.Size = new System.Drawing.Size( 221, 20 );
			this.textBoxBandName.TabIndex = 9;
			// 
			// labelBandName
			// 
			this.labelBandName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelBandName.AutoSize = true;
			this.labelBandName.Location = new System.Drawing.Point( 26, 34 );
			this.labelBandName.Name = "labelBandName";
			this.labelBandName.Size = new System.Drawing.Size( 64, 13 );
			this.labelBandName.TabIndex = 8;
			this.labelBandName.Text = "Band name:";
			// 
			// groupBoxBandInfo
			// 
			this.groupBoxBandInfo.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.groupBoxBandInfo.Controls.Add( this.listBoxAlbums );
			this.groupBoxBandInfo.Controls.Add( this.buttonDeleteAlbum );
			this.groupBoxBandInfo.Controls.Add( this.label3 );
			this.groupBoxBandInfo.Controls.Add( this.label2 );
			this.groupBoxBandInfo.Controls.Add( this.label1 );
			this.groupBoxBandInfo.Controls.Add( this.listBoxAvailableArtists );
			this.groupBoxBandInfo.Controls.Add( this.buttonCancel );
			this.groupBoxBandInfo.Controls.Add( this.buttonRemoveArtist );
			this.groupBoxBandInfo.Controls.Add( this.listBoxAddedArtists );
			this.groupBoxBandInfo.Controls.Add( this.buttonAddArtist );
			this.groupBoxBandInfo.Controls.Add( this.buttonSave );
			this.groupBoxBandInfo.Controls.Add( this.textBoxBandName );
			this.groupBoxBandInfo.Controls.Add( this.labelBandName );
			this.groupBoxBandInfo.Location = new System.Drawing.Point( 13, 144 );
			this.groupBoxBandInfo.Name = "groupBoxBandInfo";
			this.groupBoxBandInfo.Size = new System.Drawing.Size( 360, 362 );
			this.groupBoxBandInfo.TabIndex = 12;
			this.groupBoxBandInfo.TabStop = false;
			this.groupBoxBandInfo.Text = "Band info";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 198, 65 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 80, 13 );
			this.label2.TabIndex = 16;
			this.label2.Text = "Avaliable artists";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 26, 65 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 65, 13 );
			this.label1.TabIndex = 15;
			this.label1.Text = "Band artists:";
			// 
			// listBoxAvailableArtists
			// 
			this.listBoxAvailableArtists.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.listBoxAvailableArtists.FormattingEnabled = true;
			this.listBoxAvailableArtists.Location = new System.Drawing.Point( 201, 81 );
			this.listBoxAvailableArtists.Name = "listBoxAvailableArtists";
			this.listBoxAvailableArtists.Size = new System.Drawing.Size( 120, 95 );
			this.listBoxAvailableArtists.TabIndex = 3;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonCancel.Location = new System.Drawing.Point( 246, 320 );
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size( 75, 23 );
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler( this.buttonCancel_Click );
			// 
			// buttonRemoveArtist
			// 
			this.buttonRemoveArtist.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonRemoveArtist.Location = new System.Drawing.Point( 155, 102 );
			this.buttonRemoveArtist.Name = "buttonRemoveArtist";
			this.buttonRemoveArtist.Size = new System.Drawing.Size( 40, 23 );
			this.buttonRemoveArtist.TabIndex = 5;
			this.buttonRemoveArtist.Text = ">";
			this.buttonRemoveArtist.UseVisualStyleBackColor = true;
			this.buttonRemoveArtist.Click += new System.EventHandler( this.buttonRemoveArtist_Click );
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonEdit.Location = new System.Drawing.Point( 276, 42 );
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size( 97, 23 );
			this.buttonEdit.TabIndex = 13;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler( this.buttonEdit_Click );
			// 
			// listBoxAddedArtists
			// 
			this.listBoxAddedArtists.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.listBoxAddedArtists.FormattingEnabled = true;
			this.listBoxAddedArtists.Location = new System.Drawing.Point( 29, 81 );
			this.listBoxAddedArtists.Name = "listBoxAddedArtists";
			this.listBoxAddedArtists.Size = new System.Drawing.Size( 120, 95 );
			this.listBoxAddedArtists.TabIndex = 2;
			// 
			// buttonAddArtist
			// 
			this.buttonAddArtist.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonAddArtist.Location = new System.Drawing.Point( 155, 131 );
			this.buttonAddArtist.Name = "buttonAddArtist";
			this.buttonAddArtist.Size = new System.Drawing.Size( 40, 23 );
			this.buttonAddArtist.TabIndex = 4;
			this.buttonAddArtist.Text = "<";
			this.buttonAddArtist.UseVisualStyleBackColor = true;
			this.buttonAddArtist.Click += new System.EventHandler( this.buttonAddArtist_Click );
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonSave.Location = new System.Drawing.Point( 29, 320 );
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size( 75, 23 );
			this.buttonSave.TabIndex = 12;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler( this.buttonSave_Click );
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point( 276, 13 );
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size( 97, 23 );
			this.buttonDelete.TabIndex = 14;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler( this.buttonDelete_Click );
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 29, 192 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 44, 13 );
			this.label3.TabIndex = 18;
			this.label3.Text = "Albums:";
			// 
			// buttonDeleteAlbum
			// 
			this.buttonDeleteAlbum.Location = new System.Drawing.Point( 246, 211 );
			this.buttonDeleteAlbum.Name = "buttonDeleteAlbum";
			this.buttonDeleteAlbum.Size = new System.Drawing.Size( 75, 23 );
			this.buttonDeleteAlbum.TabIndex = 19;
			this.buttonDeleteAlbum.Text = "Delete";
			this.buttonDeleteAlbum.UseVisualStyleBackColor = true;
			this.buttonDeleteAlbum.Click += new System.EventHandler( this.buttonDeleteAlbum_Click );
			// 
			// listBoxAlbums
			// 
			this.listBoxAlbums.FormattingEnabled = true;
			this.listBoxAlbums.Location = new System.Drawing.Point( 32, 211 );
			this.listBoxAlbums.Name = "listBoxAlbums";
			this.listBoxAlbums.Size = new System.Drawing.Size( 208, 82 );
			this.listBoxAlbums.TabIndex = 20;
			// 
			// EditBandForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 390, 518 );
			this.Controls.Add( this.buttonDelete );
			this.Controls.Add( this.groupBoxBandInfo );
			this.Controls.Add( this.listBoxBands );
			this.Controls.Add( this.buttonEdit );
			this.Name = "EditBandForm";
			this.Text = "EditBandForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.EditBandForm_FormClosed );
			this.Load += new System.EventHandler( this.EditBandForm_Load );
			this.groupBoxBandInfo.ResumeLayout( false );
			this.groupBoxBandInfo.PerformLayout( );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxBands;
		private System.Windows.Forms.TextBox textBoxBandName;
		private System.Windows.Forms.Label labelBandName;
		private System.Windows.Forms.GroupBox groupBoxBandInfo;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxAvailableArtists;
		private System.Windows.Forms.Button buttonRemoveArtist;
		private System.Windows.Forms.ListBox listBoxAddedArtists;
		private System.Windows.Forms.Button buttonAddArtist;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonDeleteAlbum;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBoxAlbums;
	}
}