namespace Concert.PresentationLayer
{
    partial class EditArtist
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
            this.checkedListBoxInstrument = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.listBoxArtist = new System.Windows.Forms.ListBox();
            this.groupBoxInstruments = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxInstruments.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxInstrument
            // 
            this.checkedListBoxInstrument.CheckOnClick = true;
            this.checkedListBoxInstrument.FormattingEnabled = true;
            this.checkedListBoxInstrument.Location = new System.Drawing.Point(18, 19);
            this.checkedListBoxInstrument.Name = "checkedListBoxInstrument";
            this.checkedListBoxInstrument.Size = new System.Drawing.Size(167, 109);
            this.checkedListBoxInstrument.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.groupBoxInstruments);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBox1.Controls.Add(this.labelBirthDate);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artist Information";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(20, 33);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(61, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name :";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(85, 30);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(129, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(85, 56);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(129, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(19, 59);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(62, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last name :";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(22, 86);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(58, 13);
            this.labelBirthDate.TabIndex = 4;
            this.labelBirthDate.Text = "Birth date :";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(85, 82);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerBirthDate.TabIndex = 5;
            // 
            // listBoxArtist
            // 
            this.listBoxArtist.FormattingEnabled = true;
            this.listBoxArtist.Location = new System.Drawing.Point(12, 12);
            this.listBoxArtist.Name = "listBoxArtist";
            this.listBoxArtist.Size = new System.Drawing.Size(232, 95);
            this.listBoxArtist.TabIndex = 6;
            this.listBoxArtist.SelectedIndexChanged += new System.EventHandler(this.listBoxArtist_SelectedIndexChanged);
            // 
            // groupBoxInstruments
            // 
            this.groupBoxInstruments.Controls.Add(this.checkedListBoxInstrument);
            this.groupBoxInstruments.Location = new System.Drawing.Point(14, 110);
            this.groupBoxInstruments.Name = "groupBoxInstruments";
            this.groupBoxInstruments.Size = new System.Drawing.Size(200, 138);
            this.groupBoxInstruments.TabIndex = 6;
            this.groupBoxInstruments.TabStop = false;
            this.groupBoxInstruments.Text = "Instruments :";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(32, 260);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(67, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(124, 260);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // EditArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 418);
            this.Controls.Add(this.listBoxArtist);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditArtist";
            this.Text = "EditArtist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditArtist_FormClosing);
            this.Load += new System.EventHandler(this.EditArtist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxInstruments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxInstrument;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ListBox listBoxArtist;
        private System.Windows.Forms.GroupBox groupBoxInstruments;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
    }
}