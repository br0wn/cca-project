namespace Concert.PresentationLayer
{
    partial class NewArtistForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerConcert = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InstrumentsListBox1 = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePickerConcert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artist";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birth date:";
            // 
            // dateTimePickerConcert
            // 
            this.dateTimePickerConcert.Location = new System.Drawing.Point(101, 117);
            this.dateTimePickerConcert.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerConcert.Name = "dateTimePickerConcert";
            this.dateTimePickerConcert.Size = new System.Drawing.Size(196, 22);
            this.dateTimePickerConcert.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InstrumentsListBox1);
            this.groupBox2.Location = new System.Drawing.Point(22, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 155);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instruments";
            // 
            // InstrumentsListBox1
            // 
            this.InstrumentsListBox1.FormattingEnabled = true;
            this.InstrumentsListBox1.ItemHeight = 16;
            this.InstrumentsListBox1.Location = new System.Drawing.Point(12, 26);
            this.InstrumentsListBox1.Name = "InstrumentsListBox1";
            this.InstrumentsListBox1.Size = new System.Drawing.Size(249, 116);
            this.InstrumentsListBox1.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(22, 332);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(82, 32);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(214, 332);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(82, 32);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 398);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewArtistForm";
            this.Text = "NewArtistForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerConcert;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox InstrumentsListBox1;
    }
}