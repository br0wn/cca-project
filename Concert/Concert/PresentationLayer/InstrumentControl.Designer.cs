namespace Concert.PresentationLayer
{
    partial class InstrumentControl
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
            this.textBoxInstrument = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxNewInstrument = new System.Windows.Forms.GroupBox();
            this.textBoxCurrentInstrumentName = new System.Windows.Forms.TextBox();
            this.errorProviderInstrument = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewInstrument = new System.Windows.Forms.DataGridView();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxNewInstrument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInstrument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstrument)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInstrument
            // 
            this.textBoxInstrument.Location = new System.Drawing.Point(68, 21);
            this.textBoxInstrument.Name = "textBoxInstrument";
            this.textBoxInstrument.Size = new System.Drawing.Size(140, 20);
            this.textBoxInstrument.TabIndex = 4;
            this.textBoxInstrument.Validating += new System.ComponentModel.CancelEventHandler(this.SimpleTextValidation);
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
            // groupBoxNewInstrument
            // 
            this.groupBoxNewInstrument.Controls.Add(this.textBoxInstrument);
            this.groupBoxNewInstrument.Controls.Add(this.buttonAdd);
            this.groupBoxNewInstrument.Location = new System.Drawing.Point(12, 269);
            this.groupBoxNewInstrument.Name = "groupBoxNewInstrument";
            this.groupBoxNewInstrument.Size = new System.Drawing.Size(218, 54);
            this.groupBoxNewInstrument.TabIndex = 8;
            this.groupBoxNewInstrument.TabStop = false;
            this.groupBoxNewInstrument.Text = "Add new Instrument";
            // 
            // textBoxCurrentInstrumentName
            // 
            this.textBoxCurrentInstrumentName.Location = new System.Drawing.Point(80, 241);
            this.textBoxCurrentInstrumentName.Name = "textBoxCurrentInstrumentName";
            this.textBoxCurrentInstrumentName.Size = new System.Drawing.Size(140, 20);
            this.textBoxCurrentInstrumentName.TabIndex = 7;
            // 
            // errorProviderInstrument
            // 
            this.errorProviderInstrument.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderInstrument.ContainerControl = this;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(55, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewInstrument
            // 
            this.dataGridViewInstrument.AllowUserToAddRows = false;
            this.dataGridViewInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstrument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryName});
            this.dataGridViewInstrument.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewInstrument.MultiSelect = false;
            this.dataGridViewInstrument.Name = "dataGridViewInstrument";
            this.dataGridViewInstrument.ReadOnly = true;
            this.dataGridViewInstrument.Size = new System.Drawing.Size(218, 208);
            this.dataGridViewInstrument.TabIndex = 5;
            this.dataGridViewInstrument.SelectionChanged += new System.EventHandler(this.dataGridViewInstrument_SelectionChanged);
            this.dataGridViewInstrument.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewInstrument_UserDeletingRow);
            // 
            // CountryName
            // 
            this.CountryName.HeaderText = "Name";
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            this.CountryName.Width = 150;
            // 
            // InstrumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 330);
            this.Controls.Add(this.groupBoxNewInstrument);
            this.Controls.Add(this.textBoxCurrentInstrumentName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewInstrument);
            this.Name = "InstrumentControl";
            this.Text = "InstrumentControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstrumentControl_FormClosing);
            this.Load += new System.EventHandler(this.InstrumentControl_Load);
            this.groupBoxNewInstrument.ResumeLayout(false);
            this.groupBoxNewInstrument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInstrument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstrument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInstrument;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxNewInstrument;
        private System.Windows.Forms.TextBox textBoxCurrentInstrumentName;
        private System.Windows.Forms.ErrorProvider errorProviderInstrument;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewInstrument;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
    }
}