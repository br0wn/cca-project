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
            this.components = new System.ComponentModel.Container();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.dataGridViewArtist = new System.Windows.Forms.DataGridView();
            this.ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBoxConcerts = new System.Windows.Forms.GroupBox();
            this.groupBoxFindConcert = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerConcertDateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFindConcertTicketPriceTo = new System.Windows.Forms.TextBox();
            this.labelFindConcertDate = new System.Windows.Forms.Label();
            this.dateTimePickerConcertDateFrom = new System.Windows.Forms.DateTimePicker();
            this.labelFindConcertTicketPrice = new System.Windows.Forms.Label();
            this.textBoxFindConcertTicketPriceFrom = new System.Windows.Forms.TextBox();
            this.labelFindConcertName = new System.Windows.Forms.Label();
            this.textBoxFindConcertName = new System.Windows.Forms.TextBox();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelCurrentTicketPrice = new System.Windows.Forms.Label();
            this.labelCurrentName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCurrentDate = new System.Windows.Forms.TextBox();
            this.textBoxCurrentTicketPrice = new System.Windows.Forms.TextBox();
            this.textBoxCurrentName = new System.Windows.Forms.TextBox();
            this.errorProviderConcert = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxBands = new System.Windows.Forms.GroupBox();
            this.tabControlArtistAlbum = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAlbum = new System.Windows.Forms.GroupBox();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.dataGridViewTracks = new System.Windows.Forms.DataGridView();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProviderFindInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAddBands = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).BeginInit();
            this.groupBoxLocation.SuspendLayout();
            this.groupBoxConcerts.SuspendLayout();
            this.groupBoxFindConcert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConcert)).BeginInit();
            this.groupBoxBands.SuspendLayout();
            this.tabControlArtistAlbum.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFindInput)).BeginInit();
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
            this.ArtistBirthDate});
            this.dataGridViewArtist.Location = new System.Drawing.Point(16, 26);
            this.dataGridViewArtist.Name = "dataGridViewArtist";
            this.dataGridViewArtist.ReadOnly = true;
            this.dataGridViewArtist.Size = new System.Drawing.Size(301, 150);
            this.dataGridViewArtist.TabIndex = 14;
            this.dataGridViewArtist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtist_CellDoubleClick);
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
            this.dataGridViewBand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BandName});
            this.dataGridViewBand.Location = new System.Drawing.Point(45, 24);
            this.dataGridViewBand.Name = "dataGridViewBand";
            this.dataGridViewBand.ReadOnly = true;
            this.dataGridViewBand.Size = new System.Drawing.Size(208, 233);
            this.dataGridViewBand.TabIndex = 13;
            this.dataGridViewBand.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBand_CellDoubleClick);
            this.dataGridViewBand.SelectionChanged += new System.EventHandler(this.dataGridViewBand_SelectionChanged);
            this.dataGridViewBand.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewBand_UserDeletingRow);
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
            this.dataGridViewConcerts.AllowUserToResizeColumns = false;
            this.dataGridViewConcerts.AllowUserToResizeRows = false;
            this.dataGridViewConcerts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConcertName,
            this.TicketPrice,
            this.Date});
            this.dataGridViewConcerts.Location = new System.Drawing.Point(20, 123);
            this.dataGridViewConcerts.Name = "dataGridViewConcerts";
            this.dataGridViewConcerts.Size = new System.Drawing.Size(360, 150);
            this.dataGridViewConcerts.TabIndex = 12;
            this.dataGridViewConcerts.SelectionChanged += new System.EventHandler(this.dataGridViewConcerts_SelectionChanged);
            this.dataGridViewConcerts.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewConcerts_UserDeletingRow);
            // 
            // ConcertName
            // 
            this.ConcertName.HeaderText = "Name";
            this.ConcertName.Name = "ConcertName";
            // 
            // TicketPrice
            // 
            this.TicketPrice.HeaderText = "Ticket price";
            this.TicketPrice.Name = "TicketPrice";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
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
            this.groupBoxLocation.Location = new System.Drawing.Point(394, 123);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(211, 150);
            this.groupBoxLocation.TabIndex = 15;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Location Information";
            // 
            // buttonAssignLocation
            // 
            this.buttonAssignLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAssignLocation.Location = new System.Drawing.Point(9, 24);
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
            // groupBoxConcerts
            // 
            this.groupBoxConcerts.Controls.Add(this.groupBoxFindConcert);
            this.groupBoxConcerts.Controls.Add(this.labelCurrentDate);
            this.groupBoxConcerts.Controls.Add(this.labelCurrentTicketPrice);
            this.groupBoxConcerts.Controls.Add(this.labelCurrentName);
            this.groupBoxConcerts.Controls.Add(this.buttonSave);
            this.groupBoxConcerts.Controls.Add(this.groupBoxLocation);
            this.groupBoxConcerts.Controls.Add(this.textBoxCurrentDate);
            this.groupBoxConcerts.Controls.Add(this.textBoxCurrentTicketPrice);
            this.groupBoxConcerts.Controls.Add(this.textBoxCurrentName);
            this.groupBoxConcerts.Controls.Add(this.dataGridViewConcerts);
            this.groupBoxConcerts.Location = new System.Drawing.Point(10, 12);
            this.groupBoxConcerts.Name = "groupBoxConcerts";
            this.groupBoxConcerts.Size = new System.Drawing.Size(628, 335);
            this.groupBoxConcerts.TabIndex = 17;
            this.groupBoxConcerts.TabStop = false;
            this.groupBoxConcerts.Text = "Concert Control Panel";
            // 
            // groupBoxFindConcert
            // 
            this.groupBoxFindConcert.Controls.Add(this.label2);
            this.groupBoxFindConcert.Controls.Add(this.dateTimePickerConcertDateTo);
            this.groupBoxFindConcert.Controls.Add(this.label1);
            this.groupBoxFindConcert.Controls.Add(this.textBoxFindConcertTicketPriceTo);
            this.groupBoxFindConcert.Controls.Add(this.labelFindConcertDate);
            this.groupBoxFindConcert.Controls.Add(this.dateTimePickerConcertDateFrom);
            this.groupBoxFindConcert.Controls.Add(this.labelFindConcertTicketPrice);
            this.groupBoxFindConcert.Controls.Add(this.textBoxFindConcertTicketPriceFrom);
            this.groupBoxFindConcert.Controls.Add(this.labelFindConcertName);
            this.groupBoxFindConcert.Controls.Add(this.textBoxFindConcertName);
            this.groupBoxFindConcert.Location = new System.Drawing.Point(20, 16);
            this.groupBoxFindConcert.Name = "groupBoxFindConcert";
            this.groupBoxFindConcert.Size = new System.Drawing.Size(587, 87);
            this.groupBoxFindConcert.TabIndex = 20;
            this.groupBoxFindConcert.TabStop = false;
            this.groupBoxFindConcert.Text = "Find Concerts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Date <=";
            // 
            // dateTimePickerConcertDateTo
            // 
            this.dateTimePickerConcertDateTo.Location = new System.Drawing.Point(444, 50);
            this.dateTimePickerConcertDateTo.Name = "dateTimePickerConcertDateTo";
            this.dateTimePickerConcertDateTo.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerConcertDateTo.TabIndex = 32;
            this.dateTimePickerConcertDateTo.Value = new System.DateTime(2011, 10, 23, 0, 0, 0, 0);
            this.dateTimePickerConcertDateTo.ValueChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ticket price <=";
            // 
            // textBoxFindConcertTicketPriceTo
            // 
            this.textBoxFindConcertTicketPriceTo.Location = new System.Drawing.Point(289, 47);
            this.textBoxFindConcertTicketPriceTo.Name = "textBoxFindConcertTicketPriceTo";
            this.textBoxFindConcertTicketPriceTo.Size = new System.Drawing.Size(65, 20);
            this.textBoxFindConcertTicketPriceTo.TabIndex = 30;
            this.textBoxFindConcertTicketPriceTo.Text = "1000";
            this.textBoxFindConcertTicketPriceTo.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // labelFindConcertDate
            // 
            this.labelFindConcertDate.AutoSize = true;
            this.labelFindConcertDate.Location = new System.Drawing.Point(396, 24);
            this.labelFindConcertDate.Name = "labelFindConcertDate";
            this.labelFindConcertDate.Size = new System.Drawing.Size(45, 13);
            this.labelFindConcertDate.TabIndex = 26;
            this.labelFindConcertDate.Text = "Date >=";
            // 
            // dateTimePickerConcertDateFrom
            // 
            this.dateTimePickerConcertDateFrom.Location = new System.Drawing.Point(444, 22);
            this.dateTimePickerConcertDateFrom.Name = "dateTimePickerConcertDateFrom";
            this.dateTimePickerConcertDateFrom.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerConcertDateFrom.TabIndex = 25;
            this.dateTimePickerConcertDateFrom.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerConcertDateFrom.ValueChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // labelFindConcertTicketPrice
            // 
            this.labelFindConcertTicketPrice.AutoSize = true;
            this.labelFindConcertTicketPrice.Location = new System.Drawing.Point(205, 24);
            this.labelFindConcertTicketPrice.Name = "labelFindConcertTicketPrice";
            this.labelFindConcertTicketPrice.Size = new System.Drawing.Size(78, 13);
            this.labelFindConcertTicketPrice.TabIndex = 24;
            this.labelFindConcertTicketPrice.Text = "Ticket price >=";
            // 
            // textBoxFindConcertTicketPriceFrom
            // 
            this.textBoxFindConcertTicketPriceFrom.Location = new System.Drawing.Point(289, 21);
            this.textBoxFindConcertTicketPriceFrom.Name = "textBoxFindConcertTicketPriceFrom";
            this.textBoxFindConcertTicketPriceFrom.Size = new System.Drawing.Size(65, 20);
            this.textBoxFindConcertTicketPriceFrom.TabIndex = 23;
            this.textBoxFindConcertTicketPriceFrom.Text = "0";
            this.textBoxFindConcertTicketPriceFrom.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // labelFindConcertName
            // 
            this.labelFindConcertName.AutoSize = true;
            this.labelFindConcertName.Location = new System.Drawing.Point(24, 35);
            this.labelFindConcertName.Name = "labelFindConcertName";
            this.labelFindConcertName.Size = new System.Drawing.Size(41, 13);
            this.labelFindConcertName.TabIndex = 22;
            this.labelFindConcertName.Text = "Name :";
            // 
            // textBoxFindConcertName
            // 
            this.textBoxFindConcertName.Location = new System.Drawing.Point(71, 33);
            this.textBoxFindConcertName.Name = "textBoxFindConcertName";
            this.textBoxFindConcertName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindConcertName.TabIndex = 21;
            this.textBoxFindConcertName.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Location = new System.Drawing.Point(264, 281);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(30, 13);
            this.labelCurrentDate.TabIndex = 19;
            this.labelCurrentDate.Text = "Date";
            // 
            // labelCurrentTicketPrice
            // 
            this.labelCurrentTicketPrice.AutoSize = true;
            this.labelCurrentTicketPrice.Location = new System.Drawing.Point(165, 281);
            this.labelCurrentTicketPrice.Name = "labelCurrentTicketPrice";
            this.labelCurrentTicketPrice.Size = new System.Drawing.Size(63, 13);
            this.labelCurrentTicketPrice.TabIndex = 18;
            this.labelCurrentTicketPrice.Text = "Ticket price";
            // 
            // labelCurrentName
            // 
            this.labelCurrentName.AutoSize = true;
            this.labelCurrentName.Location = new System.Drawing.Point(65, 281);
            this.labelCurrentName.Name = "labelCurrentName";
            this.labelCurrentName.Size = new System.Drawing.Size(35, 13);
            this.labelCurrentName.TabIndex = 17;
            this.labelCurrentName.Text = "Name";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 295);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(48, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCurrentDate
            // 
            this.textBoxCurrentDate.Location = new System.Drawing.Point(267, 297);
            this.textBoxCurrentDate.Name = "textBoxCurrentDate";
            this.textBoxCurrentDate.Size = new System.Drawing.Size(72, 20);
            this.textBoxCurrentDate.TabIndex = 15;
            this.textBoxCurrentDate.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCurrentDate_Validating);
            // 
            // textBoxCurrentTicketPrice
            // 
            this.textBoxCurrentTicketPrice.Location = new System.Drawing.Point(168, 297);
            this.textBoxCurrentTicketPrice.Name = "textBoxCurrentTicketPrice";
            this.textBoxCurrentTicketPrice.Size = new System.Drawing.Size(72, 20);
            this.textBoxCurrentTicketPrice.TabIndex = 14;
            this.textBoxCurrentTicketPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCurrentTicketPrice_Validating);
            // 
            // textBoxCurrentName
            // 
            this.textBoxCurrentName.Location = new System.Drawing.Point(67, 297);
            this.textBoxCurrentName.Name = "textBoxCurrentName";
            this.textBoxCurrentName.Size = new System.Drawing.Size(74, 20);
            this.textBoxCurrentName.TabIndex = 13;
            this.textBoxCurrentName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCurrentName_Validating);
            // 
            // errorProviderConcert
            // 
            this.errorProviderConcert.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderConcert.ContainerControl = this;
            // 
            // groupBoxBands
            // 
            this.groupBoxBands.Controls.Add(this.buttonAddBands);
            this.groupBoxBands.Controls.Add(this.dataGridViewBand);
            this.groupBoxBands.Controls.Add(this.tabControlArtistAlbum);
            this.groupBoxBands.Location = new System.Drawing.Point(10, 353);
            this.groupBoxBands.Name = "groupBoxBands";
            this.groupBoxBands.Size = new System.Drawing.Size(626, 274);
            this.groupBoxBands.TabIndex = 18;
            this.groupBoxBands.TabStop = false;
            this.groupBoxBands.Text = "Band Control Panel";
            // 
            // tabControlArtistAlbum
            // 
            this.tabControlArtistAlbum.Controls.Add(this.tabPage1);
            this.tabControlArtistAlbum.Controls.Add(this.tabPage2);
            this.tabControlArtistAlbum.Location = new System.Drawing.Point(267, 24);
            this.tabControlArtistAlbum.Name = "tabControlArtistAlbum";
            this.tabControlArtistAlbum.SelectedIndex = 0;
            this.tabControlArtistAlbum.Size = new System.Drawing.Size(346, 237);
            this.tabControlArtistAlbum.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxAlbum);
            this.tabPage1.Controls.Add(this.dataGridViewTracks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Albums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlbum
            // 
            this.groupBoxAlbum.Controls.Add(this.comboBoxAlbums);
            this.groupBoxAlbum.Location = new System.Drawing.Point(18, 6);
            this.groupBoxAlbum.Name = "groupBoxAlbum";
            this.groupBoxAlbum.Size = new System.Drawing.Size(200, 49);
            this.groupBoxAlbum.TabIndex = 17;
            this.groupBoxAlbum.TabStop = false;
            this.groupBoxAlbum.Text = "Album Information";
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(47, 19);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlbums.TabIndex = 16;
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged);
            // 
            // dataGridViewTracks
            // 
            this.dataGridViewTracks.AllowUserToAddRows = false;
            this.dataGridViewTracks.AllowUserToDeleteRows = false;
            this.dataGridViewTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackName,
            this.TrackLength});
            this.dataGridViewTracks.Location = new System.Drawing.Point(18, 55);
            this.dataGridViewTracks.Name = "dataGridViewTracks";
            this.dataGridViewTracks.ReadOnly = true;
            this.dataGridViewTracks.Size = new System.Drawing.Size(310, 150);
            this.dataGridViewTracks.TabIndex = 16;
            this.dataGridViewTracks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTracks_CellDoubleClick);
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
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewArtist);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artists";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProviderFindInput
            // 
            this.errorProviderFindInput.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFindInput.ContainerControl = this;
            // 
            // buttonAddBands
            // 
            this.buttonAddBands.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBands.Location = new System.Drawing.Point(13, 24);
            this.buttonAddBands.Name = "buttonAddBands";
            this.buttonAddBands.Size = new System.Drawing.Size(25, 25);
            this.buttonAddBands.TabIndex = 20;
            this.buttonAddBands.Text = "+";
            this.buttonAddBands.UseVisualStyleBackColor = true;
            this.buttonAddBands.Click += new System.EventHandler(this.buttonAddBands_Click);
            // 
            // ConcertView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 639);
            this.Controls.Add(this.groupBoxBands);
            this.Controls.Add(this.groupBoxConcerts);
            this.Name = "ConcertView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConcertView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConcertView_FormClosed);
            this.Load += new System.EventHandler(this.ConcertView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).EndInit();
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxLocation.PerformLayout();
            this.groupBoxConcerts.ResumeLayout(false);
            this.groupBoxConcerts.PerformLayout();
            this.groupBoxFindConcert.ResumeLayout(false);
            this.groupBoxFindConcert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConcert)).EndInit();
            this.groupBoxBands.ResumeLayout(false);
            this.tabControlArtistAlbum.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFindInput)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxConcerts;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelCurrentTicketPrice;
        private System.Windows.Forms.Label labelCurrentName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCurrentDate;
        private System.Windows.Forms.TextBox textBoxCurrentTicketPrice;
        private System.Windows.Forms.TextBox textBoxCurrentName;
        private System.Windows.Forms.ErrorProvider errorProviderConcert;
        private System.Windows.Forms.GroupBox groupBoxBands;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandName;
        private System.Windows.Forms.TabControl tabControlArtistAlbum;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistBirthDate;
        private System.Windows.Forms.GroupBox groupBoxAlbum;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.DataGridView dataGridViewTracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackLength;
        private System.Windows.Forms.GroupBox groupBoxFindConcert;
        private System.Windows.Forms.Label labelFindConcertDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerConcertDateFrom;
        private System.Windows.Forms.Label labelFindConcertName;
        private System.Windows.Forms.TextBox textBoxFindConcertName;
        private System.Windows.Forms.Label labelFindConcertTicketPrice;
        private System.Windows.Forms.TextBox textBoxFindConcertTicketPriceFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerConcertDateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFindConcertTicketPriceTo;
        private System.Windows.Forms.ErrorProvider errorProviderFindInput;
        private System.Windows.Forms.Button buttonAddBands;
    }
}