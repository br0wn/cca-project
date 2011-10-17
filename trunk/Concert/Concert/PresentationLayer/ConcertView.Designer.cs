namespace Concert.PresentationLayer
{
    partial class ConcertView
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
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.dataGridViewArtist = new System.Windows.Forms.DataGridView();
            this.ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistInstruments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCountry = new System.Windows.Forms.Label();
            this.dataGridViewBand = new System.Windows.Forms.DataGridView();
            this.BandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAddress = new System.Windows.Forms.Label();
            this.dataGridViewConcerts = new System.Windows.Forms.DataGridView();
            this.ConcertName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSeatCount = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.buttonAssignLocation = new System.Windows.Forms.Button();
            this.labelSeatCount = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.dataGridViewTracks = new System.Windows.Forms.DataGridView();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).BeginInit();
            this.groupBoxLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(97, 29);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.ReadOnly = true;
            this.textBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountry.TabIndex = 2;
            // 
            // dataGridViewArtist
            // 
            this.dataGridViewArtist.AllowUserToAddRows = false;
            this.dataGridViewArtist.AllowUserToDeleteRows = false;
            this.dataGridViewArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtistName,
            this.ArtistBirthDate,
            this.ArtistInstruments});
            this.dataGridViewArtist.Location = new System.Drawing.Point(12, 343);
            this.dataGridViewArtist.Name = "dataGridViewArtist";
            this.dataGridViewArtist.ReadOnly = true;
            this.dataGridViewArtist.Size = new System.Drawing.Size(564, 150);
            this.dataGridViewArtist.TabIndex = 14;
            // 
            // ArtistName
            // 
            this.ArtistName.HeaderText = "Name";
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.ReadOnly = true;
            this.ArtistName.Width = 150;
            // 
            // ArtistBirthDate
            // 
            this.ArtistBirthDate.HeaderText = "Birth date";
            this.ArtistBirthDate.Name = "ArtistBirthDate";
            this.ArtistBirthDate.ReadOnly = true;
            // 
            // ArtistInstruments
            // 
            this.ArtistInstruments.HeaderText = "Instruments";
            this.ArtistInstruments.Name = "ArtistInstruments";
            this.ArtistInstruments.ReadOnly = true;
            this.ArtistInstruments.Width = 270;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(42, 32);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(49, 13);
            this.labelCountry.TabIndex = 1;
            this.labelCountry.Text = "Country :";
            // 
            // dataGridViewBand
            // 
            this.dataGridViewBand.AllowUserToAddRows = false;
            this.dataGridViewBand.AllowUserToDeleteRows = false;
            this.dataGridViewBand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BandName});
            this.dataGridViewBand.Location = new System.Drawing.Point(12, 178);
            this.dataGridViewBand.Name = "dataGridViewBand";
            this.dataGridViewBand.ReadOnly = true;
            this.dataGridViewBand.Size = new System.Drawing.Size(209, 150);
            this.dataGridViewBand.TabIndex = 13;
            this.dataGridViewBand.SelectionChanged += new System.EventHandler(this.dataGridViewBand_SelectionChanged);
            // 
            // BandName
            // 
            this.BandName.HeaderText = "Name";
            this.BandName.Name = "BandName";
            this.BandName.ReadOnly = true;
            this.BandName.Width = 150;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(40, 58);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(51, 13);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address :";
            // 
            // dataGridViewConcerts
            // 
            this.dataGridViewConcerts.AllowUserToAddRows = false;
            this.dataGridViewConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConcertName,
            this.TicketPrice,
            this.Date});
            this.dataGridViewConcerts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewConcerts.Name = "dataGridViewConcerts";
            this.dataGridViewConcerts.Size = new System.Drawing.Size(345, 150);
            this.dataGridViewConcerts.TabIndex = 12;
            this.dataGridViewConcerts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConcerts_RowEnter);
            this.dataGridViewConcerts.SelectionChanged += new System.EventHandler(this.dataGridViewConcerts_SelectionChanged);
            this.dataGridViewConcerts.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewConcerts_UserDeletingRow);
            // 
            // ConcertName
            // 
            this.ConcertName.HeaderText = "Name";
            this.ConcertName.Name = "ConcertName";
            this.ConcertName.ReadOnly = true;
            // 
            // TicketPrice
            // 
            this.TicketPrice.HeaderText = "Ticket price";
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // textBoxSeatCount
            // 
            this.textBoxSeatCount.Location = new System.Drawing.Point(97, 108);
            this.textBoxSeatCount.Name = "textBoxSeatCount";
            this.textBoxSeatCount.ReadOnly = true;
            this.textBoxSeatCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeatCount.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(97, 55);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.Controls.Add(this.buttonAssignLocation);
            this.groupBoxLocation.Controls.Add(this.textBoxCountry);
            this.groupBoxLocation.Controls.Add(this.labelCountry);
            this.groupBoxLocation.Controls.Add(this.labelAddress);
            this.groupBoxLocation.Controls.Add(this.textBoxSeatCount);
            this.groupBoxLocation.Controls.Add(this.textBoxAddress);
            this.groupBoxLocation.Controls.Add(this.labelSeatCount);
            this.groupBoxLocation.Controls.Add(this.labelPostalCode);
            this.groupBoxLocation.Controls.Add(this.textBoxPostalCode);
            this.groupBoxLocation.Location = new System.Drawing.Point(363, 12);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(211, 150);
            this.groupBoxLocation.TabIndex = 15;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Location Information";
            // 
            // buttonAssignLocation
            // 
            this.buttonAssignLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAssignLocation.Location = new System.Drawing.Point(9, 26);
            this.buttonAssignLocation.Name = "buttonAssignLocation";
            this.buttonAssignLocation.Size = new System.Drawing.Size(27, 23);
            this.buttonAssignLocation.TabIndex = 9;
            this.buttonAssignLocation.Text = "*";
            this.buttonAssignLocation.UseVisualStyleBackColor = true;
            this.buttonAssignLocation.Click += new System.EventHandler(this.buttonAssignLocation_Click);
            // 
            // labelSeatCount
            // 
            this.labelSeatCount.AutoSize = true;
            this.labelSeatCount.Location = new System.Drawing.Point(32, 111);
            this.labelSeatCount.Name = "labelSeatCount";
            this.labelSeatCount.Size = new System.Drawing.Size(59, 13);
            this.labelSeatCount.TabIndex = 7;
            this.labelSeatCount.Text = "Seat cout :";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(22, 84);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(69, 13);
            this.labelPostalCode.TabIndex = 5;
            this.labelPostalCode.Text = "Postal code :";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(97, 81);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.ReadOnly = true;
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 6;
            // 
            // dataGridViewTracks
            // 
            this.dataGridViewTracks.AllowUserToAddRows = false;
            this.dataGridViewTracks.AllowUserToDeleteRows = false;
            this.dataGridViewTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackName,
            this.TrackLength});
            this.dataGridViewTracks.Location = new System.Drawing.Point(232, 178);
            this.dataGridViewTracks.Name = "dataGridViewTracks";
            this.dataGridViewTracks.ReadOnly = true;
            this.dataGridViewTracks.Size = new System.Drawing.Size(344, 150);
            this.dataGridViewTracks.TabIndex = 16;
            // 
            // TrackName
            // 
            this.TrackName.HeaderText = "Track";
            this.TrackName.Name = "TrackName";
            this.TrackName.ReadOnly = true;
            this.TrackName.Width = 150;
            // 
            // TrackLength
            // 
            this.TrackLength.HeaderText = "Length";
            this.TrackLength.Name = "TrackLength";
            this.TrackLength.ReadOnly = true;
            this.TrackLength.Width = 150;
            // 
            // ConcertView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 540);
            this.Controls.Add(this.dataGridViewTracks);
            this.Controls.Add(this.dataGridViewArtist);
            this.Controls.Add(this.dataGridViewBand);
            this.Controls.Add(this.dataGridViewConcerts);
            this.Controls.Add(this.groupBoxLocation);
            this.Name = "ConcertView";
            this.Text = "ConcertView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConcertView_FormClosed);
            this.Load += new System.EventHandler(this.ConcertView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).EndInit();
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.DataGridView dataGridViewArtist;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.DataGridView dataGridViewBand;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.DataGridView dataGridViewConcerts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConcertName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TextBox textBoxSeatCount;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.Label labelSeatCount;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Button buttonAssignLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistInstruments;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandName;
        private System.Windows.Forms.DataGridView dataGridViewTracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackLength;
    }
}