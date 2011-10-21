namespace Concert.PresentationLayer
{
    partial class NewBandForm
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
            this.labelBandName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxAddedArtists = new System.Windows.Forms.ListBox();
            this.listBoxAvailableArtists = new System.Windows.Forms.ListBox();
            this.buttonAddArtist = new System.Windows.Forms.Button();
            this.buttonRemoveArtist = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAddedArtists = new System.Windows.Forms.Label();
            this.labelAvailableArtists = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBandName
            // 
            this.labelBandName.AutoSize = true;
            this.labelBandName.Location = new System.Drawing.Point(13, 13);
            this.labelBandName.Name = "labelBandName";
            this.labelBandName.Size = new System.Drawing.Size(64, 13);
            this.labelBandName.TabIndex = 0;
            this.labelBandName.Text = "Band name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBoxAddedArtists
            // 
            this.listBoxAddedArtists.FormattingEnabled = true;
            this.listBoxAddedArtists.Location = new System.Drawing.Point(17, 70);
            this.listBoxAddedArtists.Name = "listBoxAddedArtists";
            this.listBoxAddedArtists.Size = new System.Drawing.Size(120, 95);
            this.listBoxAddedArtists.TabIndex = 2;
            // 
            // listBoxAvailableArtists
            // 
            this.listBoxAvailableArtists.FormattingEnabled = true;
            this.listBoxAvailableArtists.Location = new System.Drawing.Point(189, 70);
            this.listBoxAvailableArtists.Name = "listBoxAvailableArtists";
            this.listBoxAvailableArtists.Size = new System.Drawing.Size(120, 95);
            this.listBoxAvailableArtists.TabIndex = 3;
            // 
            // buttonAddArtist
            // 
            this.buttonAddArtist.Location = new System.Drawing.Point(143, 120);
            this.buttonAddArtist.Name = "buttonAddArtist";
            this.buttonAddArtist.Size = new System.Drawing.Size(40, 23);
            this.buttonAddArtist.TabIndex = 4;
            this.buttonAddArtist.Text = "<";
            this.buttonAddArtist.UseVisualStyleBackColor = true;
            this.buttonAddArtist.Click += new System.EventHandler(this.buttonAddArtist_Click);
            // 
            // buttonRemoveArtist
            // 
            this.buttonRemoveArtist.Location = new System.Drawing.Point(143, 91);
            this.buttonRemoveArtist.Name = "buttonRemoveArtist";
            this.buttonRemoveArtist.Size = new System.Drawing.Size(40, 23);
            this.buttonRemoveArtist.TabIndex = 5;
            this.buttonRemoveArtist.Text = ">";
            this.buttonRemoveArtist.UseVisualStyleBackColor = true;
            this.buttonRemoveArtist.Click += new System.EventHandler(this.buttonRemoveArtist_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 185);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(234, 184);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancle";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelAddedArtists
            // 
            this.labelAddedArtists.AutoSize = true;
            this.labelAddedArtists.Location = new System.Drawing.Point(17, 54);
            this.labelAddedArtists.Name = "labelAddedArtists";
            this.labelAddedArtists.Size = new System.Drawing.Size(65, 13);
            this.labelAddedArtists.TabIndex = 6;
            this.labelAddedArtists.Text = "Band artists:";
            // 
            // labelAvailableArtists
            // 
            this.labelAvailableArtists.AutoSize = true;
            this.labelAvailableArtists.Location = new System.Drawing.Point(186, 54);
            this.labelAvailableArtists.Name = "labelAvailableArtists";
            this.labelAvailableArtists.Size = new System.Drawing.Size(83, 13);
            this.labelAvailableArtists.TabIndex = 7;
            this.labelAvailableArtists.Text = "Available artists:";
            // 
            // NewBandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 225);
            this.Controls.Add(this.labelAvailableArtists);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelAddedArtists);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxAvailableArtists);
            this.Controls.Add(this.buttonRemoveArtist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxAddedArtists);
            this.Controls.Add(this.buttonAddArtist);
            this.Controls.Add(this.labelBandName);
            this.Name = "NewBandForm";
            this.Text = "Add band";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewBandForm_FormClosing);
            this.Load += new System.EventHandler(this.NewBandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBandName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxAddedArtists;
        private System.Windows.Forms.ListBox listBoxAvailableArtists;
        private System.Windows.Forms.Button buttonAddArtist;
		private System.Windows.Forms.Button buttonRemoveArtist;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelAddedArtists;
		private System.Windows.Forms.Label labelAvailableArtists;
    }
}