namespace Concert.PresentationLayer
{
    partial class MainControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container( );
			this.statusStrip = new System.Windows.Forms.StatusStrip( );
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel( );
			this.toolTip = new System.Windows.Forms.ToolTip( this.components );
			this.menuStrip = new System.Windows.Forms.MenuStrip( );
			this.concertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.showConcertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.addNewConcertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.showLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.newLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.bandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.newBandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.editBandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.trackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.trackControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
			this.statusStrip.SuspendLayout( );
			this.menuStrip.SuspendLayout( );
			this.SuspendLayout( );
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.toolStripStatusLabel} );
			this.statusStrip.Location = new System.Drawing.Point( 0, 550 );
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size( 722, 22 );
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size( 38, 17 );
			this.toolStripStatusLabel.Text = "Status";
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.concertToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.bandToolStripMenuItem,
            this.artistToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.trackToolStripMenuItem} );
			this.menuStrip.Location = new System.Drawing.Point( 0, 0 );
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size( 722, 24 );
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// concertToolStripMenuItem
			// 
			this.concertToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.showConcertsToolStripMenuItem,
            this.addNewConcertToolStripMenuItem} );
			this.concertToolStripMenuItem.Name = "concertToolStripMenuItem";
			this.concertToolStripMenuItem.Size = new System.Drawing.Size( 57, 20 );
			this.concertToolStripMenuItem.Text = "Concert";
			// 
			// showConcertsToolStripMenuItem
			// 
			this.showConcertsToolStripMenuItem.Name = "showConcertsToolStripMenuItem";
			this.showConcertsToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
			this.showConcertsToolStripMenuItem.Text = "Show concerts";
			this.showConcertsToolStripMenuItem.Click += new System.EventHandler( this.showConcertsToolStripMenuItem_Click );
			// 
			// addNewConcertToolStripMenuItem
			// 
			this.addNewConcertToolStripMenuItem.Name = "addNewConcertToolStripMenuItem";
			this.addNewConcertToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
			this.addNewConcertToolStripMenuItem.Text = "Add new concert";
			this.addNewConcertToolStripMenuItem.Click += new System.EventHandler( this.addNewConcertToolStripMenuItem_Click );
			// 
			// locationToolStripMenuItem
			// 
			this.locationToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.showLocationsToolStripMenuItem,
            this.newLocationToolStripMenuItem} );
			this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
			this.locationToolStripMenuItem.Size = new System.Drawing.Size( 59, 20 );
			this.locationToolStripMenuItem.Text = "Location";
			// 
			// showLocationsToolStripMenuItem
			// 
			this.showLocationsToolStripMenuItem.Name = "showLocationsToolStripMenuItem";
			this.showLocationsToolStripMenuItem.Size = new System.Drawing.Size( 159, 22 );
			this.showLocationsToolStripMenuItem.Text = "Show Locations";
			this.showLocationsToolStripMenuItem.Click += new System.EventHandler( this.showLocationsToolStripMenuItem_Click );
			// 
			// newLocationToolStripMenuItem
			// 
			this.newLocationToolStripMenuItem.Name = "newLocationToolStripMenuItem";
			this.newLocationToolStripMenuItem.Size = new System.Drawing.Size( 159, 22 );
			this.newLocationToolStripMenuItem.Text = "New Location";
			this.newLocationToolStripMenuItem.Click += new System.EventHandler( this.newLocationToolStripMenuItem_Click );
			// 
			// bandToolStripMenuItem
			// 
			this.bandToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.newBandToolStripMenuItem,
            this.editBandToolStripMenuItem} );
			this.bandToolStripMenuItem.Name = "bandToolStripMenuItem";
			this.bandToolStripMenuItem.Size = new System.Drawing.Size( 43, 20 );
			this.bandToolStripMenuItem.Text = "Band";
			// 
			// newBandToolStripMenuItem
			// 
			this.newBandToolStripMenuItem.Name = "newBandToolStripMenuItem";
			this.newBandToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.newBandToolStripMenuItem.Text = "New Band";
			this.newBandToolStripMenuItem.Click += new System.EventHandler( this.newBandToolStripMenuItem_Click );
			// 
			// editBandToolStripMenuItem
			// 
			this.editBandToolStripMenuItem.Name = "editBandToolStripMenuItem";
			this.editBandToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.editBandToolStripMenuItem.Text = "Edit Band";
			this.editBandToolStripMenuItem.Click += new System.EventHandler( this.editBandToolStripMenuItem_Click );
			// 
			// artistToolStripMenuItem
			// 
			this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
			this.artistToolStripMenuItem.Size = new System.Drawing.Size( 45, 20 );
			this.artistToolStripMenuItem.Text = "Artist";
			// 
			// albumToolStripMenuItem
			// 
			this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
			this.albumToolStripMenuItem.Size = new System.Drawing.Size( 48, 20 );
			this.albumToolStripMenuItem.Text = "Album";
			// 
			// trackToolStripMenuItem
			// 
			this.trackToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.trackControlToolStripMenuItem} );
			this.trackToolStripMenuItem.Name = "trackToolStripMenuItem";
			this.trackToolStripMenuItem.Size = new System.Drawing.Size( 45, 20 );
			this.trackToolStripMenuItem.Text = "Track";
			// 
			// trackControlToolStripMenuItem
			// 
			this.trackControlToolStripMenuItem.Name = "trackControlToolStripMenuItem";
			this.trackControlToolStripMenuItem.Size = new System.Drawing.Size( 149, 22 );
			this.trackControlToolStripMenuItem.Text = "Track Control";
			this.trackControlToolStripMenuItem.Click += new System.EventHandler( this.trackControlToolStripMenuItem_Click );
			// 
			// MainControlPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 722, 572 );
			this.Controls.Add( this.statusStrip );
			this.Controls.Add( this.menuStrip );
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainControlPanel";
			this.Text = "MainControlPanel";
			this.statusStrip.ResumeLayout( false );
			this.statusStrip.PerformLayout( );
			this.menuStrip.ResumeLayout( false );
			this.menuStrip.PerformLayout( );
			this.ResumeLayout( false );
			this.PerformLayout( );

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem concertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConcertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewConcertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBandToolStripMenuItem;
    }
}



