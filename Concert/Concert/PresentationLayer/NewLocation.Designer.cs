namespace Concert.PresentationLayer
{
    partial class NewLocation
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
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxSeatCount = new System.Windows.Forms.TextBox();
            this.labelSeatCount = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProviderLocation = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.LocationCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationSeatCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxLocationPanel = new System.Windows.Forms.GroupBox();
            this.labelSeatCountCurrent = new System.Windows.Forms.Label();
            this.labelPostalCodeCurrent = new System.Windows.Forms.Label();
            this.labelAddressCurrent = new System.Windows.Forms.Label();
            this.labelCountryCurrent = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCountryCurrent = new System.Windows.Forms.TextBox();
            this.textBoxAddressCurrent = new System.Windows.Forms.TextBox();
            this.textBoxPostalCodeCurrent = new System.Windows.Forms.TextBox();
            this.textBoxSeatCountCurrent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            this.groupBoxLocation.SuspendLayout();
            this.groupBoxLocationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(93, 58);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(162, 20);
            this.textBoxAddress.TabIndex = 3;
            this.textBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAddress_Validating);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(36, 61);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(51, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address :";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(349, 23);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(67, 20);
            this.textBoxPostalCode.TabIndex = 5;
            this.textBoxPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPostalCode_Validating);
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(274, 26);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(69, 13);
            this.labelPostalCode.TabIndex = 4;
            this.labelPostalCode.Text = "Postal code :";
            // 
            // textBoxSeatCount
            // 
            this.textBoxSeatCount.Location = new System.Drawing.Point(349, 58);
            this.textBoxSeatCount.Name = "textBoxSeatCount";
            this.textBoxSeatCount.Size = new System.Drawing.Size(67, 20);
            this.textBoxSeatCount.TabIndex = 7;
            this.textBoxSeatCount.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSeatCount_Validating);
            // 
            // labelSeatCount
            // 
            this.labelSeatCount.AutoSize = true;
            this.labelSeatCount.Location = new System.Drawing.Point(278, 61);
            this.labelSeatCount.Name = "labelSeatCount";
            this.labelSeatCount.Size = new System.Drawing.Size(65, 13);
            this.labelSeatCount.TabIndex = 6;
            this.labelSeatCount.Text = "Seat count :";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(93, 23);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountry.TabIndex = 9;
            this.textBoxCountry.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCountry_Validating);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(36, 26);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(49, 13);
            this.labelCountry.TabIndex = 8;
            this.labelCountry.Text = "Country :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(180, 95);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // errorProviderLocation
            // 
            this.errorProviderLocation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLocation.ContainerControl = this;
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
            this.dataGridViewLocation.Location = new System.Drawing.Point(9, 28);
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.ReadOnly = true;
            this.dataGridViewLocation.Size = new System.Drawing.Size(452, 183);
            this.dataGridViewLocation.TabIndex = 15;
            this.dataGridViewLocation.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocation_RowEnter);
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
            this.groupBoxLocation.Controls.Add(this.buttonCancel);
            this.groupBoxLocation.Controls.Add(this.textBoxCountry);
            this.groupBoxLocation.Controls.Add(this.labelAddress);
            this.groupBoxLocation.Controls.Add(this.buttonAdd);
            this.groupBoxLocation.Controls.Add(this.textBoxAddress);
            this.groupBoxLocation.Controls.Add(this.labelPostalCode);
            this.groupBoxLocation.Controls.Add(this.labelCountry);
            this.groupBoxLocation.Controls.Add(this.textBoxPostalCode);
            this.groupBoxLocation.Controls.Add(this.textBoxSeatCount);
            this.groupBoxLocation.Controls.Add(this.labelSeatCount);
            this.groupBoxLocation.Location = new System.Drawing.Point(6, 288);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(476, 132);
            this.groupBoxLocation.TabIndex = 16;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "New location";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(268, 95);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxLocationPanel
            // 
            this.groupBoxLocationPanel.Controls.Add(this.labelSeatCountCurrent);
            this.groupBoxLocationPanel.Controls.Add(this.labelPostalCodeCurrent);
            this.groupBoxLocationPanel.Controls.Add(this.labelAddressCurrent);
            this.groupBoxLocationPanel.Controls.Add(this.labelCountryCurrent);
            this.groupBoxLocationPanel.Controls.Add(this.buttonSave);
            this.groupBoxLocationPanel.Controls.Add(this.textBoxCountryCurrent);
            this.groupBoxLocationPanel.Controls.Add(this.dataGridViewLocation);
            this.groupBoxLocationPanel.Controls.Add(this.textBoxAddressCurrent);
            this.groupBoxLocationPanel.Controls.Add(this.textBoxPostalCodeCurrent);
            this.groupBoxLocationPanel.Controls.Add(this.textBoxSeatCountCurrent);
            this.groupBoxLocationPanel.Location = new System.Drawing.Point(6, 4);
            this.groupBoxLocationPanel.Name = "groupBoxLocationPanel";
            this.groupBoxLocationPanel.Size = new System.Drawing.Size(476, 278);
            this.groupBoxLocationPanel.TabIndex = 17;
            this.groupBoxLocationPanel.TabStop = false;
            this.groupBoxLocationPanel.Text = "Location Control";
            // 
            // labelSeatCountCurrent
            // 
            this.labelSeatCountCurrent.AutoSize = true;
            this.labelSeatCountCurrent.Location = new System.Drawing.Point(391, 223);
            this.labelSeatCountCurrent.Name = "labelSeatCountCurrent";
            this.labelSeatCountCurrent.Size = new System.Drawing.Size(65, 13);
            this.labelSeatCountCurrent.TabIndex = 20;
            this.labelSeatCountCurrent.Text = "Seat count :";
            // 
            // labelPostalCodeCurrent
            // 
            this.labelPostalCodeCurrent.AutoSize = true;
            this.labelPostalCodeCurrent.Location = new System.Drawing.Point(316, 223);
            this.labelPostalCodeCurrent.Name = "labelPostalCodeCurrent";
            this.labelPostalCodeCurrent.Size = new System.Drawing.Size(69, 13);
            this.labelPostalCodeCurrent.TabIndex = 19;
            this.labelPostalCodeCurrent.Text = "Postal code :";
            // 
            // labelAddressCurrent
            // 
            this.labelAddressCurrent.AutoSize = true;
            this.labelAddressCurrent.Location = new System.Drawing.Point(155, 223);
            this.labelAddressCurrent.Name = "labelAddressCurrent";
            this.labelAddressCurrent.Size = new System.Drawing.Size(51, 13);
            this.labelAddressCurrent.TabIndex = 18;
            this.labelAddressCurrent.Text = "Address :";
            // 
            // labelCountryCurrent
            // 
            this.labelCountryCurrent.AutoSize = true;
            this.labelCountryCurrent.Location = new System.Drawing.Point(60, 223);
            this.labelCountryCurrent.Name = "labelCountryCurrent";
            this.labelCountryCurrent.Size = new System.Drawing.Size(49, 13);
            this.labelCountryCurrent.TabIndex = 17;
            this.labelCountryCurrent.Text = "Country :";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(9, 237);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(47, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCountryCurrent
            // 
            this.textBoxCountryCurrent.Location = new System.Drawing.Point(58, 239);
            this.textBoxCountryCurrent.Name = "textBoxCountryCurrent";
            this.textBoxCountryCurrent.Size = new System.Drawing.Size(76, 20);
            this.textBoxCountryCurrent.TabIndex = 9;
            // 
            // textBoxAddressCurrent
            // 
            this.textBoxAddressCurrent.Location = new System.Drawing.Point(158, 239);
            this.textBoxAddressCurrent.Name = "textBoxAddressCurrent";
            this.textBoxAddressCurrent.Size = new System.Drawing.Size(137, 20);
            this.textBoxAddressCurrent.TabIndex = 3;
            // 
            // textBoxPostalCodeCurrent
            // 
            this.textBoxPostalCodeCurrent.Location = new System.Drawing.Point(318, 239);
            this.textBoxPostalCodeCurrent.Name = "textBoxPostalCodeCurrent";
            this.textBoxPostalCodeCurrent.Size = new System.Drawing.Size(49, 20);
            this.textBoxPostalCodeCurrent.TabIndex = 5;
            // 
            // textBoxSeatCountCurrent
            // 
            this.textBoxSeatCountCurrent.Location = new System.Drawing.Point(394, 239);
            this.textBoxSeatCountCurrent.Name = "textBoxSeatCountCurrent";
            this.textBoxSeatCountCurrent.Size = new System.Drawing.Size(48, 20);
            this.textBoxSeatCountCurrent.TabIndex = 7;
            // 
            // NewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 448);
            this.Controls.Add(this.groupBoxLocationPanel);
            this.Controls.Add(this.groupBoxLocation);
            this.Name = "NewLocation";
            this.Text = "NewLocation";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxLocation.PerformLayout();
            this.groupBoxLocationPanel.ResumeLayout(false);
            this.groupBoxLocationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxSeatCount;
        private System.Windows.Forms.Label labelSeatCount;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProviderLocation;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationSeatCount;
        private System.Windows.Forms.GroupBox groupBoxLocationPanel;
        private System.Windows.Forms.Label labelSeatCountCurrent;
        private System.Windows.Forms.Label labelPostalCodeCurrent;
        private System.Windows.Forms.Label labelAddressCurrent;
        private System.Windows.Forms.Label labelCountryCurrent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCountryCurrent;
        private System.Windows.Forms.TextBox textBoxAddressCurrent;
        private System.Windows.Forms.TextBox textBoxPostalCodeCurrent;
        private System.Windows.Forms.TextBox textBoxSeatCountCurrent;
        private System.Windows.Forms.Button buttonCancel;

    }
}