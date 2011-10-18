namespace Concert.PresentationLayer {
    partial class NewAlbumForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.listBoxAvaliableSongs = new System.Windows.Forms.ListBox();
            this.buttonRemoveSong = new System.Windows.Forms.Button();
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.labelAlbumSongs = new System.Windows.Forms.Label();
            this.labelAvaliableSongs = new System.Windows.Forms.Label();
            this.buttonAddAlbum = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.listBoxAvaliableBands = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(10, 13);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(68, 13);
            this.labelAlbumName.TabIndex = 0;
            this.labelAlbumName.Text = "Album name:";
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Location = new System.Drawing.Point(84, 10);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(226, 20);
            this.textBoxAlbumName.TabIndex = 1;
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(8, 72);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(116, 147);
            this.listBoxSongs.TabIndex = 2;
            // 
            // listBoxAvaliableSongs
            // 
            this.listBoxAvaliableSongs.FormattingEnabled = true;
            this.listBoxAvaliableSongs.Location = new System.Drawing.Point(187, 72);
            this.listBoxAvaliableSongs.Name = "listBoxAvaliableSongs";
            this.listBoxAvaliableSongs.Size = new System.Drawing.Size(116, 147);
            this.listBoxAvaliableSongs.TabIndex = 3;
            // 
            // buttonRemoveSong
            // 
            this.buttonRemoveSong.Location = new System.Drawing.Point(130, 116);
            this.buttonRemoveSong.Name = "buttonRemoveSong";
            this.buttonRemoveSong.Size = new System.Drawing.Size(51, 29);
            this.buttonRemoveSong.TabIndex = 4;
            this.buttonRemoveSong.Text = ">";
            this.buttonRemoveSong.UseVisualStyleBackColor = true;
            this.buttonRemoveSong.Click += new System.EventHandler(this.buttonRemoveSong_Click);
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.Location = new System.Drawing.Point(130, 151);
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.Size = new System.Drawing.Size(51, 29);
            this.buttonAddSong.TabIndex = 5;
            this.buttonAddSong.Text = "<";
            this.buttonAddSong.UseVisualStyleBackColor = true;
            this.buttonAddSong.Click += new System.EventHandler(this.buttonAddSong_Click);
            // 
            // labelAlbumSongs
            // 
            this.labelAlbumSongs.AutoSize = true;
            this.labelAlbumSongs.Location = new System.Drawing.Point(11, 49);
            this.labelAlbumSongs.Name = "labelAlbumSongs";
            this.labelAlbumSongs.Size = new System.Drawing.Size(70, 13);
            this.labelAlbumSongs.TabIndex = 6;
            this.labelAlbumSongs.Text = "Album songs:";
            // 
            // labelAvaliableSongs
            // 
            this.labelAvaliableSongs.AutoSize = true;
            this.labelAvaliableSongs.Location = new System.Drawing.Point(184, 49);
            this.labelAvaliableSongs.Name = "labelAvaliableSongs";
            this.labelAvaliableSongs.Size = new System.Drawing.Size(84, 13);
            this.labelAvaliableSongs.TabIndex = 7;
            this.labelAvaliableSongs.Text = "Avaliable songs:";
            // 
            // buttonAddAlbum
            // 
            this.buttonAddAlbum.Location = new System.Drawing.Point(14, 350);
            this.buttonAddAlbum.Name = "buttonAddAlbum";
            this.buttonAddAlbum.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAlbum.TabIndex = 8;
            this.buttonAddAlbum.Text = "Add";
            this.buttonAddAlbum.UseVisualStyleBackColor = true;
            this.buttonAddAlbum.Click += new System.EventHandler(this.buttonAddAlbum_Click);
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(228, 350);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(75, 23);
            this.buttonCancle.TabIndex = 9;
            this.buttonCancle.Text = "Cancel";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // listBoxAvaliableBands
            // 
            this.listBoxAvaliableBands.FormattingEnabled = true;
            this.listBoxAvaliableBands.Location = new System.Drawing.Point(8, 224);
            this.listBoxAvaliableBands.Name = "listBoxAvaliableBands";
            this.listBoxAvaliableBands.Size = new System.Drawing.Size(294, 108);
            this.listBoxAvaliableBands.TabIndex = 10;
            // 
            // NewAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 389);
            this.Controls.Add(this.listBoxAvaliableBands);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonAddAlbum);
            this.Controls.Add(this.labelAvaliableSongs);
            this.Controls.Add(this.labelAlbumSongs);
            this.Controls.Add(this.buttonAddSong);
            this.Controls.Add(this.buttonRemoveSong);
            this.Controls.Add(this.listBoxAvaliableSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.textBoxAlbumName);
            this.Controls.Add(this.labelAlbumName);
            this.Name = "NewAlbumForm";
            this.Text = "Add new album";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewAlbumForm_FormClosed);
            this.Load += new System.EventHandler(this.NewAlbumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.ListBox listBoxAvaliableSongs;
        private System.Windows.Forms.Button buttonRemoveSong;
        private System.Windows.Forms.Button buttonAddSong;
        private System.Windows.Forms.Label labelAlbumSongs;
        private System.Windows.Forms.Label labelAvaliableSongs;
        private System.Windows.Forms.Button buttonAddAlbum;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.ListBox listBoxAvaliableBands;
    }
}