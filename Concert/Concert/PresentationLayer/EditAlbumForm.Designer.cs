namespace Concert.PresentationLayer {
    partial class EditAlbumForm {
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
            this.labelAvaliableAlbums = new System.Windows.Forms.Label();
            this.listBoxAvaliableAlbums = new System.Windows.Forms.ListBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.listBoxAddedSgons = new System.Windows.Forms.ListBox();
            this.buttonRemoveSong = new System.Windows.Forms.Button();
            this.listBoxAvaliableSongs = new System.Windows.Forms.ListBox();
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.labelAlbumSongs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAvaliableAlbums
            // 
            this.labelAvaliableAlbums.AutoSize = true;
            this.labelAvaliableAlbums.Location = new System.Drawing.Point(14, 11);
            this.labelAvaliableAlbums.Name = "labelAvaliableAlbums";
            this.labelAvaliableAlbums.Size = new System.Drawing.Size(89, 13);
            this.labelAvaliableAlbums.TabIndex = 0;
            this.labelAvaliableAlbums.Text = "Avaliable albums:";
            // 
            // listBoxAvaliableAlbums
            // 
            this.listBoxAvaliableAlbums.FormattingEnabled = true;
            this.listBoxAvaliableAlbums.Location = new System.Drawing.Point(17, 36);
            this.listBoxAvaliableAlbums.Name = "listBoxAvaliableAlbums";
            this.listBoxAvaliableAlbums.Size = new System.Drawing.Size(287, 134);
            this.listBoxAvaliableAlbums.TabIndex = 1;
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(24, 188);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(68, 13);
            this.labelAlbumName.TabIndex = 2;
            this.labelAlbumName.Text = "Album name:";
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Location = new System.Drawing.Point(102, 186);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(202, 20);
            this.textBoxAlbumName.TabIndex = 3;
            // 
            // listBoxAddedSgons
            // 
            this.listBoxAddedSgons.FormattingEnabled = true;
            this.listBoxAddedSgons.Location = new System.Drawing.Point(22, 249);
            this.listBoxAddedSgons.Name = "listBoxAddedSgons";
            this.listBoxAddedSgons.Size = new System.Drawing.Size(114, 121);
            this.listBoxAddedSgons.TabIndex = 4;
            // 
            // buttonRemoveSong
            // 
            this.buttonRemoveSong.Location = new System.Drawing.Point(142, 275);
            this.buttonRemoveSong.Name = "buttonRemoveSong";
            this.buttonRemoveSong.Size = new System.Drawing.Size(42, 29);
            this.buttonRemoveSong.TabIndex = 6;
            this.buttonRemoveSong.Text = ">";
            this.buttonRemoveSong.UseVisualStyleBackColor = true;
            // 
            // listBoxAvaliableSongs
            // 
            this.listBoxAvaliableSongs.FormattingEnabled = true;
            this.listBoxAvaliableSongs.Location = new System.Drawing.Point(190, 249);
            this.listBoxAvaliableSongs.Name = "listBoxAvaliableSongs";
            this.listBoxAvaliableSongs.Size = new System.Drawing.Size(114, 121);
            this.listBoxAvaliableSongs.TabIndex = 7;
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.Location = new System.Drawing.Point(142, 319);
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.Size = new System.Drawing.Size(42, 29);
            this.buttonAddSong.TabIndex = 8;
            this.buttonAddSong.Text = "<";
            this.buttonAddSong.UseVisualStyleBackColor = true;
            // 
            // labelAlbumSongs
            // 
            this.labelAlbumSongs.AutoSize = true;
            this.labelAlbumSongs.Location = new System.Drawing.Point(24, 223);
            this.labelAlbumSongs.Name = "labelAlbumSongs";
            this.labelAlbumSongs.Size = new System.Drawing.Size(70, 13);
            this.labelAlbumSongs.TabIndex = 9;
            this.labelAlbumSongs.Text = "Album songs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Avaliable songs:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(22, 388);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(229, 388);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 12;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(103, 388);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(119, 23);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // EditAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 443);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAlbumSongs);
            this.Controls.Add(this.buttonAddSong);
            this.Controls.Add(this.listBoxAvaliableSongs);
            this.Controls.Add(this.buttonRemoveSong);
            this.Controls.Add(this.listBoxAddedSgons);
            this.Controls.Add(this.textBoxAlbumName);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.listBoxAvaliableAlbums);
            this.Controls.Add(this.labelAvaliableAlbums);
            this.Name = "EditAlbumForm";
            this.Text = "Edit album";
            this.Load += new System.EventHandler(this.EditAlbumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAvaliableAlbums;
        private System.Windows.Forms.ListBox listBoxAvaliableAlbums;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.ListBox listBoxAddedSgons;
        private System.Windows.Forms.Button buttonRemoveSong;
        private System.Windows.Forms.ListBox listBoxAvaliableSongs;
        private System.Windows.Forms.Button buttonAddSong;
        private System.Windows.Forms.Label labelAlbumSongs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonEdit;
    }
}