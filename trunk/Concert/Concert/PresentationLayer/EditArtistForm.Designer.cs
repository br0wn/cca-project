namespace Concert.PresentationLayer
{
    partial class EditArtistForm
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
            this.ArtistsListBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerConcert = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkedListBoxInstruments = new System.Windows.Forms.CheckedListBox();
            this.groupBox2.SuspendLayout();
            this.Edit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArtistsListBox1
            // 
            this.ArtistsListBox1.FormattingEnabled = true;
            this.ArtistsListBox1.Location = new System.Drawing.Point(11, 11);
            this.ArtistsListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArtistsListBox1.Name = "ArtistsListBox1";
            this.ArtistsListBox1.Size = new System.Drawing.Size(245, 95);
            this.ArtistsListBox1.TabIndex = 0;
            this.ArtistsListBox1.Click += new System.EventHandler(this.ArtistsListBox1_Click);
            this.ArtistsListBox1.SelectedIndexChanged += new System.EventHandler(this.ArtistsListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birth date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name:";
            // 
            // dateTimePickerConcert
            // 
            this.dateTimePickerConcert.Location = new System.Drawing.Point(84, 69);
            this.dateTimePickerConcert.Name = "dateTimePickerConcert";
            this.dateTimePickerConcert.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerConcert.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxInstruments);
            this.groupBox2.Location = new System.Drawing.Point(16, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(215, 126);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instruments";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.button2);
            this.Edit.Controls.Add(this.button1);
            this.Edit.Controls.Add(this.groupBox2);
            this.Edit.Controls.Add(this.textBox2);
            this.Edit.Controls.Add(this.textBox1);
            this.Edit.Controls.Add(this.dateTimePickerConcert);
            this.Edit.Controls.Add(this.label3);
            this.Edit.Controls.Add(this.label2);
            this.Edit.Controls.Add(this.label1);
            this.Edit.Location = new System.Drawing.Point(9, 193);
            this.Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Size = new System.Drawing.Size(246, 288);
            this.Edit.TabIndex = 21;
            this.Edit.TabStop = false;
            this.Edit.Text = "Edit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(9, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(245, 64);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 24);
            this.button3.TabIndex = 0;
            this.button3.Text = "Delete selected artist";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkedListBoxInstruments
            // 
            this.checkedListBoxInstruments.FormattingEnabled = true;
            this.checkedListBoxInstruments.Location = new System.Drawing.Point(25, 21);
            this.checkedListBoxInstruments.Name = "checkedListBoxInstruments";
            this.checkedListBoxInstruments.Size = new System.Drawing.Size(171, 94);
            this.checkedListBoxInstruments.TabIndex = 1;
            // 
            // EditArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ArtistsListBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditArtistForm";
            this.Text = "EditArtistForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditArtistForm_FormClosed);
            this.Load += new System.EventHandler(this.EditArtistForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ArtistsListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerConcert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox checkedListBoxInstruments;
    }
}