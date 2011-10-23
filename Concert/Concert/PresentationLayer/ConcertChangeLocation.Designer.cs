namespace Concert.PresentationLayer
{
    partial class ConcertChangeLocation
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
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.LocationCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationSeatCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewLocation.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.ReadOnly = true;
            this.dataGridViewLocation.Size = new System.Drawing.Size(462, 183);
            this.dataGridViewLocation.TabIndex = 16;
            this.dataGridViewLocation.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLocation_RowHeaderMouseDoubleClick);
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
            // ConcertChangeLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 184);
            this.Controls.Add(this.dataGridViewLocation);
            this.Name = "ConcertChangeLocation";
            this.Text = "ConcertChangeLocation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationSeatCount;

    }
}