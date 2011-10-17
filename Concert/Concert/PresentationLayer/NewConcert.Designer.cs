namespace Concert.PresentationLayer
{
    partial class NewConcert
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
            this.dateTimePickerConcert = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.errorProviderConcert = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAddConcert = new System.Windows.Forms.Button();
            this.textBoxTicketPrice = new System.Windows.Forms.TextBox();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.textBoxConcertName = new System.Windows.Forms.TextBox();
            this.labelConcertName = new System.Windows.Forms.Label();
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.LocationCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationSeatCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.buttonSetLocation = new System.Windows.Forms.Button();
            this.buttonAddNewLocation = new System.Windows.Forms.Button();
            this.checkedListBoxBands = new System.Windows.Forms.CheckedListBox();
            this.groupBoxBands = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConcert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            this.groupBoxLocation.SuspendLayout();
            this.groupBoxBands.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerConcert
            // 
            this.dateTimePickerConcert.Location = new System.Drawing.Point(244, 12);
            this.dateTimePickerConcert.Name = "dateTimePickerConcert";
            this.dateTimePickerConcert.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerConcert.TabIndex = 13;
            this.dateTimePickerConcert.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerConcert_Validating);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(202, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "Date :";
            // 
            // errorProviderConcert
            // 
            this.errorProviderConcert.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderConcert.ContainerControl = this;
            // 
            // buttonAddConcert
            // 
            this.buttonAddConcert.Location = new System.Drawing.Point(313, 341);
            this.buttonAddConcert.Name = "buttonAddConcert";
            this.buttonAddConcert.Size = new System.Drawing.Size(100, 23);
            this.buttonAddConcert.TabIndex = 11;
            this.buttonAddConcert.Text = "Add concert!!!";
            this.buttonAddConcert.UseVisualStyleBackColor = true;
            this.buttonAddConcert.Click += new System.EventHandler(this.buttonAddConcert_Click);
            // 
            // textBoxTicketPrice
            // 
            this.textBoxTicketPrice.Location = new System.Drawing.Point(82, 38);
            this.textBoxTicketPrice.Name = "textBoxTicketPrice";
            this.textBoxTicketPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxTicketPrice.TabIndex = 10;
            this.textBoxTicketPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTicketPrice_Validating);
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Location = new System.Drawing.Point(7, 41);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(69, 13);
            this.labelTicketPrice.TabIndex = 9;
            this.labelTicketPrice.Text = "Ticket price :";
            // 
            // textBoxConcertName
            // 
            this.textBoxConcertName.Location = new System.Drawing.Point(82, 12);
            this.textBoxConcertName.Name = "textBoxConcertName";
            this.textBoxConcertName.Size = new System.Drawing.Size(100, 20);
            this.textBoxConcertName.TabIndex = 8;
            this.textBoxConcertName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxConcertName_Validating);
            // 
            // labelConcertName
            // 
            this.labelConcertName.AutoSize = true;
            this.labelConcertName.Location = new System.Drawing.Point(35, 15);
            this.labelConcertName.Name = "labelConcertName";
            this.labelConcertName.Size = new System.Drawing.Size(41, 13);
            this.labelConcertName.TabIndex = 7;
            this.labelConcertName.Text = "Name :";
            // 
            // dataGridViewLocation
            // 
            this.dataGridViewLocation.AllowUserToAddRows = false;
            this.dataGridViewLocation.AllowUserToDeleteRows = false;
            this.dataGridViewLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocationCountry,
            this.LocationAddress,
            this.LocationPostalCode,
            this.LocationSeatCount});
            this.dataGridViewLocation.Location = new System.Drawing.Point(20, 30);
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.ReadOnly = true;
            this.dataGridViewLocation.Size = new System.Drawing.Size(446, 105);
            this.dataGridViewLocation.TabIndex = 14;
            // 
            // LocationCountry
            // 
            this.LocationCountry.HeaderText = "Country";
            this.LocationCountry.Name = "LocationCountry";
            this.LocationCountry.ReadOnly = true;
            // 
            // LocationAddress
            // 
            this.LocationAddress.HeaderText = "Address";
            this.LocationAddress.Name = "LocationAddress";
            this.LocationAddress.ReadOnly = true;
            // 
            // LocationPostalCode
            // 
            this.LocationPostalCode.HeaderText = "Postal code";
            this.LocationPostalCode.Name = "LocationPostalCode";
            this.LocationPostalCode.ReadOnly = true;
            // 
            // LocationSeatCount
            // 
            this.LocationSeatCount.HeaderText = "Seat count";
            this.LocationSeatCount.Name = "LocationSeatCount";
            this.LocationSeatCount.ReadOnly = true;
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.Controls.Add(this.buttonSetLocation);
            this.groupBoxLocation.Controls.Add(this.buttonAddNewLocation);
            this.groupBoxLocation.Controls.Add(this.dataGridViewLocation);
            this.groupBoxLocation.Location = new System.Drawing.Point(12, 83);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(480, 195);
            this.groupBoxLocation.TabIndex = 15;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Location Information";
            // 
            // buttonSetLocation
            // 
            this.buttonSetLocation.Location = new System.Drawing.Point(20, 153);
            this.buttonSetLocation.Name = "buttonSetLocation";
            this.buttonSetLocation.Size = new System.Drawing.Size(110, 23);
            this.buttonSetLocation.TabIndex = 16;
            this.buttonSetLocation.Text = "Use this location";
            this.buttonSetLocation.UseVisualStyleBackColor = true;
            this.buttonSetLocation.Click += new System.EventHandler(this.buttonSetLocation_Click);
            // 
            // buttonAddNewLocation
            // 
            this.buttonAddNewLocation.Location = new System.Drawing.Point(149, 153);
            this.buttonAddNewLocation.Name = "buttonAddNewLocation";
            this.buttonAddNewLocation.Size = new System.Drawing.Size(89, 23);
            this.buttonAddNewLocation.TabIndex = 15;
            this.buttonAddNewLocation.Text = "*New Location";
            this.buttonAddNewLocation.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxBands
            // 
            this.checkedListBoxBands.FormattingEnabled = true;
            this.checkedListBoxBands.Location = new System.Drawing.Point(16, 28);
            this.checkedListBoxBands.Name = "checkedListBoxBands";
            this.checkedListBoxBands.Size = new System.Drawing.Size(156, 94);
            this.checkedListBoxBands.TabIndex = 17;
            // 
            // groupBoxBands
            // 
            this.groupBoxBands.Controls.Add(this.checkedListBoxBands);
            this.groupBoxBands.Location = new System.Drawing.Point(12, 300);
            this.groupBoxBands.Name = "groupBoxBands";
            this.groupBoxBands.Size = new System.Drawing.Size(200, 143);
            this.groupBoxBands.TabIndex = 18;
            this.groupBoxBands.TabStop = false;
            this.groupBoxBands.Text = "Band Information";
            // 
            // NewConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 455);
            this.Controls.Add(this.groupBoxBands);
            this.Controls.Add(this.groupBoxLocation);
            this.Controls.Add(this.dateTimePickerConcert);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonAddConcert);
            this.Controls.Add(this.textBoxTicketPrice);
            this.Controls.Add(this.labelTicketPrice);
            this.Controls.Add(this.textBoxConcertName);
            this.Controls.Add(this.labelConcertName);
            this.Name = "NewConcert";
            this.Text = "NewConcert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewConcert_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewConcert_FormClosed);
            this.Load += new System.EventHandler(this.NewConcert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConcert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxBands.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerConcert;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ErrorProvider errorProviderConcert;
        private System.Windows.Forms.Button buttonAddConcert;
        private System.Windows.Forms.TextBox textBoxTicketPrice;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.TextBox textBoxConcertName;
        private System.Windows.Forms.Label labelConcertName;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.Button buttonSetLocation;
        private System.Windows.Forms.Button buttonAddNewLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationSeatCount;
        private System.Windows.Forms.CheckedListBox checkedListBoxBands;
        private System.Windows.Forms.GroupBox groupBoxBands;
    }
}