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
            this.groupBoxArtists = new System.Windows.Forms.GroupBox();
            this.groupBoxAlbums = new System.Windows.Forms.GroupBox();
            this.listBoxAvailableAlbums = new System.Windows.Forms.ListBox();
            this.buttonRemoveAlbum = new System.Windows.Forms.Button();
            this.listBoxAddedAlbums = new System.Windows.Forms.ListBox();
            this.buttonAddAlbum = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxArtists.SuspendLayout();
            this.groupBoxAlbums.SuspendLayout();
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
            this.listBoxAddedArtists.Location = new System.Drawing.Point(6, 19);
            this.listBoxAddedArtists.Name = "listBoxAddedArtists";
            this.listBoxAddedArtists.Size = new System.Drawing.Size(120, 95);
            this.listBoxAddedArtists.TabIndex = 2;
            // 
            // listBoxAvailableArtists
            // 
            this.listBoxAvailableArtists.FormattingEnabled = true;
            this.listBoxAvailableArtists.Location = new System.Drawing.Point(178, 19);
            this.listBoxAvailableArtists.Name = "listBoxAvailableArtists";
            this.listBoxAvailableArtists.Size = new System.Drawing.Size(120, 95);
            this.listBoxAvailableArtists.TabIndex = 3;
            // 
            // buttonAddArtist
            // 
            this.buttonAddArtist.Location = new System.Drawing.Point(132, 69);
            this.buttonAddArtist.Name = "buttonAddArtist";
            this.buttonAddArtist.Size = new System.Drawing.Size(40, 23);
            this.buttonAddArtist.TabIndex = 4;
            this.buttonAddArtist.Text = "<";
            this.buttonAddArtist.UseVisualStyleBackColor = true;
            this.buttonAddArtist.Click += new System.EventHandler(this.buttonAddArtist_Click);
            // 
            // buttonRemoveArtist
            // 
            this.buttonRemoveArtist.Location = new System.Drawing.Point(132, 40);
            this.buttonRemoveArtist.Name = "buttonRemoveArtist";
            this.buttonRemoveArtist.Size = new System.Drawing.Size(40, 23);
            this.buttonRemoveArtist.TabIndex = 5;
            this.buttonRemoveArtist.Text = ">";
            this.buttonRemoveArtist.UseVisualStyleBackColor = true;
            this.buttonRemoveArtist.Click += new System.EventHandler(this.buttonRemoveArtist_Click);
            // 
            // groupBoxArtists
            // 
            this.groupBoxArtists.Controls.Add(this.listBoxAvailableArtists);
            this.groupBoxArtists.Controls.Add(this.buttonRemoveArtist);
            this.groupBoxArtists.Controls.Add(this.listBoxAddedArtists);
            this.groupBoxArtists.Controls.Add(this.buttonAddArtist);
            this.groupBoxArtists.Location = new System.Drawing.Point(12, 47);
            this.groupBoxArtists.Name = "groupBoxArtists";
            this.groupBoxArtists.Size = new System.Drawing.Size(304, 123);
            this.groupBoxArtists.TabIndex = 6;
            this.groupBoxArtists.TabStop = false;
            this.groupBoxArtists.Text = "Artists";
            // 
            // groupBoxAlbums
            // 
            this.groupBoxAlbums.Controls.Add(this.listBoxAvailableAlbums);
            this.groupBoxAlbums.Controls.Add(this.buttonRemoveAlbum);
            this.groupBoxAlbums.Controls.Add(this.listBoxAddedAlbums);
            this.groupBoxAlbums.Controls.Add(this.buttonAddAlbum);
            this.groupBoxAlbums.Location = new System.Drawing.Point(12, 176);
            this.groupBoxAlbums.Name = "groupBoxAlbums";
            this.groupBoxAlbums.Size = new System.Drawing.Size(304, 123);
            this.groupBoxAlbums.TabIndex = 7;
            this.groupBoxAlbums.TabStop = false;
            this.groupBoxAlbums.Text = "Bands";
            // 
            // listBoxAvailableAlbums
            // 
            this.listBoxAvailableAlbums.FormattingEnabled = true;
            this.listBoxAvailableAlbums.Location = new System.Drawing.Point(178, 19);
            this.listBoxAvailableAlbums.Name = "listBoxAvailableAlbums";
            this.listBoxAvailableAlbums.Size = new System.Drawing.Size(120, 95);
            this.listBoxAvailableAlbums.TabIndex = 3;
            // 
            // buttonRemoveAlbum
            // 
            this.buttonRemoveAlbum.Location = new System.Drawing.Point(132, 40);
            this.buttonRemoveAlbum.Name = "buttonRemoveAlbum";
            this.buttonRemoveAlbum.Size = new System.Drawing.Size(40, 23);
            this.buttonRemoveAlbum.TabIndex = 5;
            this.buttonRemoveAlbum.Text = ">";
            this.buttonRemoveAlbum.UseVisualStyleBackColor = true;
            this.buttonRemoveAlbum.Click += new System.EventHandler(this.buttonRemoveAlbum_Click);
            // 
            // listBoxAddedAlbums
            // 
            this.listBoxAddedAlbums.FormattingEnabled = true;
            this.listBoxAddedAlbums.Location = new System.Drawing.Point(6, 19);
            this.listBoxAddedAlbums.Name = "listBoxAddedAlbums";
            this.listBoxAddedAlbums.Size = new System.Drawing.Size(120, 95);
            this.listBoxAddedAlbums.TabIndex = 2;
            // 
            // buttonAddAlbum
            // 
            this.buttonAddAlbum.Location = new System.Drawing.Point(132, 69);
            this.buttonAddAlbum.Name = "buttonAddAlbum";
            this.buttonAddAlbum.Size = new System.Drawing.Size(40, 23);
            this.buttonAddAlbum.TabIndex = 4;
            this.buttonAddAlbum.Text = "<";
            this.buttonAddAlbum.UseVisualStyleBackColor = true;
            this.buttonAddAlbum.Click += new System.EventHandler(this.buttonAddAlbum_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 306);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(234, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancle";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NewBandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 340);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxAlbums);
            this.Controls.Add(this.groupBoxArtists);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBandName);
            this.Name = "NewBandForm";
            this.Text = "rid";
            this.groupBoxArtists.ResumeLayout(false);
            this.groupBoxAlbums.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBoxArtists;
        private System.Windows.Forms.GroupBox groupBoxAlbums;
        private System.Windows.Forms.ListBox listBoxAvailableAlbums;
        private System.Windows.Forms.Button buttonRemoveAlbum;
        private System.Windows.Forms.ListBox listBoxAddedAlbums;
        private System.Windows.Forms.Button buttonAddAlbum;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}