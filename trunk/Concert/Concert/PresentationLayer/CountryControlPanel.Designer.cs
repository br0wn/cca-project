namespace Concert.PresentationLayer
{
    partial class CountryControlPanel
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
            this.dataGridViewCountry = new System.Windows.Forms.DataGridView();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCurrentCountryName = new System.Windows.Forms.TextBox();
            this.groupBoxNewCountry = new System.Windows.Forms.GroupBox();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProviderCountry = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).BeginInit();
            this.groupBoxNewCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCountry
            // 
            this.dataGridViewCountry.AllowUserToAddRows = false;
            this.dataGridViewCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryName});
            this.dataGridViewCountry.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCountry.MultiSelect = false;
            this.dataGridViewCountry.Name = "dataGridViewCountry";
            this.dataGridViewCountry.ReadOnly = true;
            this.dataGridViewCountry.Size = new System.Drawing.Size(218, 208);
            this.dataGridViewCountry.TabIndex = 0;
            this.dataGridViewCountry.SelectionChanged += new System.EventHandler(this.dataGridViewCountry_SelectionChanged);
            this.dataGridViewCountry.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewCountry_UserDeletingRow);
            // 
            // CountryName
            // 
            this.CountryName.HeaderText = "Name";
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            this.CountryName.Width = 150;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(55, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCurrentCountryName
            // 
            this.textBoxCurrentCountryName.Location = new System.Drawing.Point(80, 241);
            this.textBoxCurrentCountryName.Name = "textBoxCurrentCountryName";
            this.textBoxCurrentCountryName.Size = new System.Drawing.Size(123, 20);
            this.textBoxCurrentCountryName.TabIndex = 3;
            // 
            // groupBoxNewCountry
            // 
            this.groupBoxNewCountry.Controls.Add(this.textBoxCountryName);
            this.groupBoxNewCountry.Controls.Add(this.buttonAdd);
            this.groupBoxNewCountry.Location = new System.Drawing.Point(12, 269);
            this.groupBoxNewCountry.Name = "groupBoxNewCountry";
            this.groupBoxNewCountry.Size = new System.Drawing.Size(218, 54);
            this.groupBoxNewCountry.TabIndex = 4;
            this.groupBoxNewCountry.TabStop = false;
            this.groupBoxNewCountry.Text = "Add new Country";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(68, 21);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(123, 20);
            this.textBoxCountryName.TabIndex = 4;
            this.textBoxCountryName.Validating += new System.ComponentModel.CancelEventHandler(this.SimpleTextValidation);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // errorProviderCountry
            // 
            this.errorProviderCountry.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCountry.ContainerControl = this;
            // 
            // CountryControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 335);
            this.Controls.Add(this.groupBoxNewCountry);
            this.Controls.Add(this.textBoxCurrentCountryName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewCountry);
            this.Name = "CountryControlPanel";
            this.Text = "CountryControlPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountryControlPanel_FormClosing);
            this.Load += new System.EventHandler(this.CountryControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).EndInit();
            this.groupBoxNewCountry.ResumeLayout(false);
            this.groupBoxNewCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCurrentCountryName;
        private System.Windows.Forms.GroupBox groupBoxNewCountry;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProviderCountry;
    }
}