﻿namespace Concert.PresentationLayer
{
    partial class TrackControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackControlPanel));
            this.dataGridViewTracks = new System.Windows.Forms.DataGridView();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTrack = new System.Windows.Forms.GroupBox();
            this.labelTrackLengthCurrent = new System.Windows.Forms.Label();
            this.labelTrackNameCurrent = new System.Windows.Forms.Label();
            this.textBoxTrackLengthCurrent = new System.Windows.Forms.TextBox();
            this.textBoxTrackNameCurrent = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxNewTrack = new System.Windows.Forms.GroupBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTrackLength = new System.Windows.Forms.TextBox();
            this.labelTrackLength = new System.Windows.Forms.Label();
            this.textBoxTrackName = new System.Windows.Forms.TextBox();
            this.labelTrackName = new System.Windows.Forms.Label();
            this.errorProviderTrack = new System.Windows.Forms.ErrorProvider(this.components);
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelWMPlayer = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBoxUploadTrack = new System.Windows.Forms.GroupBox();
            this.comboBoxAlbumName = new System.Windows.Forms.ComboBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).BeginInit();
            this.groupBoxTrack.SuspendLayout();
            this.groupBoxNewTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.panelWMPlayer.SuspendLayout();
            this.groupBoxUploadTrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTracks
            // 
            this.dataGridViewTracks.AllowUserToAddRows = false;
            this.dataGridViewTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackName,
            this.TrackLength});
            this.dataGridViewTracks.Location = new System.Drawing.Point(17, 19);
            this.dataGridViewTracks.Name = "dataGridViewTracks";
            this.dataGridViewTracks.ReadOnly = true;
            this.dataGridViewTracks.Size = new System.Drawing.Size(313, 136);
            this.dataGridViewTracks.TabIndex = 0;
            this.dataGridViewTracks.SelectionChanged += new System.EventHandler(this.dataGridViewTracks_SelectionChanged);
            this.dataGridViewTracks.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewTracks_UserDeletingRow);
            this.dataGridViewTracks.DoubleClick += new System.EventHandler(this.dataGridViewTracks_DoubleClick);
            // 
            // TrackName
            // 
            this.TrackName.HeaderText = "Name";
            this.TrackName.Name = "TrackName";
            this.TrackName.ReadOnly = true;
            this.TrackName.Width = 150;
            // 
            // TrackLength
            // 
            this.TrackLength.HeaderText = "Length";
            this.TrackLength.Name = "TrackLength";
            this.TrackLength.ReadOnly = true;
            // 
            // groupBoxTrack
            // 
            this.groupBoxTrack.Controls.Add(this.labelTrackLengthCurrent);
            this.groupBoxTrack.Controls.Add(this.labelTrackNameCurrent);
            this.groupBoxTrack.Controls.Add(this.textBoxTrackLengthCurrent);
            this.groupBoxTrack.Controls.Add(this.textBoxTrackNameCurrent);
            this.groupBoxTrack.Controls.Add(this.buttonSave);
            this.groupBoxTrack.Controls.Add(this.dataGridViewTracks);
            this.groupBoxTrack.Location = new System.Drawing.Point(12, 11);
            this.groupBoxTrack.Name = "groupBoxTrack";
            this.groupBoxTrack.Size = new System.Drawing.Size(350, 219);
            this.groupBoxTrack.TabIndex = 1;
            this.groupBoxTrack.TabStop = false;
            this.groupBoxTrack.Text = "Track Control";
            // 
            // labelTrackLengthCurrent
            // 
            this.labelTrackLengthCurrent.AutoSize = true;
            this.labelTrackLengthCurrent.Location = new System.Drawing.Point(209, 166);
            this.labelTrackLengthCurrent.Name = "labelTrackLengthCurrent";
            this.labelTrackLengthCurrent.Size = new System.Drawing.Size(46, 13);
            this.labelTrackLengthCurrent.TabIndex = 4;
            this.labelTrackLengthCurrent.Text = "Length :";
            // 
            // labelTrackNameCurrent
            // 
            this.labelTrackNameCurrent.AutoSize = true;
            this.labelTrackNameCurrent.Location = new System.Drawing.Point(62, 166);
            this.labelTrackNameCurrent.Name = "labelTrackNameCurrent";
            this.labelTrackNameCurrent.Size = new System.Drawing.Size(41, 13);
            this.labelTrackNameCurrent.TabIndex = 2;
            this.labelTrackNameCurrent.Text = "Name :";
            // 
            // textBoxTrackLengthCurrent
            // 
            this.textBoxTrackLengthCurrent.Location = new System.Drawing.Point(210, 182);
            this.textBoxTrackLengthCurrent.Name = "textBoxTrackLengthCurrent";
            this.textBoxTrackLengthCurrent.Size = new System.Drawing.Size(88, 20);
            this.textBoxTrackLengthCurrent.TabIndex = 3;
            // 
            // textBoxTrackNameCurrent
            // 
            this.textBoxTrackNameCurrent.Location = new System.Drawing.Point(63, 182);
            this.textBoxTrackNameCurrent.Name = "textBoxTrackNameCurrent";
            this.textBoxTrackNameCurrent.Size = new System.Drawing.Size(141, 20);
            this.textBoxTrackNameCurrent.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(17, 180);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(40, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxNewTrack
            // 
            this.groupBoxNewTrack.Controls.Add(this.labelAlbumName);
            this.groupBoxNewTrack.Controls.Add(this.comboBoxAlbumName);
            this.groupBoxNewTrack.Controls.Add(this.groupBoxUploadTrack);
            this.groupBoxNewTrack.Controls.Add(this.buttonCancel);
            this.groupBoxNewTrack.Controls.Add(this.buttonAdd);
            this.groupBoxNewTrack.Controls.Add(this.textBoxTrackLength);
            this.groupBoxNewTrack.Controls.Add(this.labelTrackLength);
            this.groupBoxNewTrack.Controls.Add(this.textBoxTrackName);
            this.groupBoxNewTrack.Controls.Add(this.labelTrackName);
            this.groupBoxNewTrack.Location = new System.Drawing.Point(12, 237);
            this.groupBoxNewTrack.Name = "groupBoxNewTrack";
            this.groupBoxNewTrack.Size = new System.Drawing.Size(594, 129);
            this.groupBoxNewTrack.TabIndex = 2;
            this.groupBoxNewTrack.TabStop = false;
            this.groupBoxNewTrack.Text = "New track";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(100, 58);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 8;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(16, 35);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(35, 13);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Path :";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(57, 32);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(198, 20);
            this.textBoxPath.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(222, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(131, 100);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTrackLength
            // 
            this.textBoxTrackLength.Location = new System.Drawing.Point(131, 45);
            this.textBoxTrackLength.Name = "textBoxTrackLength";
            this.textBoxTrackLength.Size = new System.Drawing.Size(141, 20);
            this.textBoxTrackLength.TabIndex = 3;
            this.textBoxTrackLength.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTrackLength_Validating);
            // 
            // labelTrackLength
            // 
            this.labelTrackLength.AutoSize = true;
            this.labelTrackLength.Location = new System.Drawing.Point(79, 48);
            this.labelTrackLength.Name = "labelTrackLength";
            this.labelTrackLength.Size = new System.Drawing.Size(46, 13);
            this.labelTrackLength.TabIndex = 2;
            this.labelTrackLength.Text = "Length :";
            // 
            // textBoxTrackName
            // 
            this.textBoxTrackName.Location = new System.Drawing.Point(131, 19);
            this.textBoxTrackName.Name = "textBoxTrackName";
            this.textBoxTrackName.Size = new System.Drawing.Size(141, 20);
            this.textBoxTrackName.TabIndex = 1;
            this.textBoxTrackName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTrackName_Validating);
            // 
            // labelTrackName
            // 
            this.labelTrackName.AutoSize = true;
            this.labelTrackName.Location = new System.Drawing.Point(84, 22);
            this.labelTrackName.Name = "labelTrackName";
            this.labelTrackName.Size = new System.Drawing.Size(41, 13);
            this.labelTrackName.TabIndex = 0;
            this.labelTrackName.Text = "Name :";
            // 
            // errorProviderTrack
            // 
            this.errorProviderTrack.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTrack.ContainerControl = this;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(225, 209);
            this.axWindowsMediaPlayer.TabIndex = 3;
            // 
            // panelWMPlayer
            // 
            this.panelWMPlayer.Controls.Add(this.axWindowsMediaPlayer);
            this.panelWMPlayer.Location = new System.Drawing.Point(375, 18);
            this.panelWMPlayer.Name = "panelWMPlayer";
            this.panelWMPlayer.Size = new System.Drawing.Size(225, 209);
            this.panelWMPlayer.TabIndex = 4;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::Concert.Properties.Resources.play;
            this.buttonPlay.Location = new System.Drawing.Point(181, 57);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(24, 24);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Visible = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // groupBoxUploadTrack
            // 
            this.groupBoxUploadTrack.Controls.Add(this.buttonPlay);
            this.groupBoxUploadTrack.Controls.Add(this.buttonUpload);
            this.groupBoxUploadTrack.Controls.Add(this.labelPath);
            this.groupBoxUploadTrack.Controls.Add(this.textBoxPath);
            this.groupBoxUploadTrack.Location = new System.Drawing.Point(296, 16);
            this.groupBoxUploadTrack.Name = "groupBoxUploadTrack";
            this.groupBoxUploadTrack.Size = new System.Drawing.Size(282, 96);
            this.groupBoxUploadTrack.TabIndex = 7;
            this.groupBoxUploadTrack.TabStop = false;
            this.groupBoxUploadTrack.Text = "Upload Track";
            // 
            // comboBoxAlbumName
            // 
            this.comboBoxAlbumName.FormattingEnabled = true;
            this.comboBoxAlbumName.Location = new System.Drawing.Point(131, 71);
            this.comboBoxAlbumName.Name = "comboBoxAlbumName";
            this.comboBoxAlbumName.Size = new System.Drawing.Size(141, 21);
            this.comboBoxAlbumName.TabIndex = 8;
            this.comboBoxAlbumName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxAlbumName_Validating);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(54, 74);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(71, 13);
            this.labelAlbumName.TabIndex = 9;
            this.labelAlbumName.Text = "Album name :";
            // 
            // TrackControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 378);
            this.Controls.Add(this.panelWMPlayer);
            this.Controls.Add(this.groupBoxNewTrack);
            this.Controls.Add(this.groupBoxTrack);
            this.Name = "TrackControlPanel";
            this.Text = "TrackControlPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrackControlPanel_FormClosed);
            this.Load += new System.EventHandler(this.TrackControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).EndInit();
            this.groupBoxTrack.ResumeLayout(false);
            this.groupBoxTrack.PerformLayout();
            this.groupBoxNewTrack.ResumeLayout(false);
            this.groupBoxNewTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.panelWMPlayer.ResumeLayout(false);
            this.groupBoxUploadTrack.ResumeLayout(false);
            this.groupBoxUploadTrack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTracks;
        private System.Windows.Forms.GroupBox groupBoxTrack;
        private System.Windows.Forms.Label labelTrackLengthCurrent;
        private System.Windows.Forms.Label labelTrackNameCurrent;
        private System.Windows.Forms.TextBox textBoxTrackLengthCurrent;
        private System.Windows.Forms.TextBox textBoxTrackNameCurrent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxNewTrack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTrackLength;
        private System.Windows.Forms.Label labelTrackLength;
        private System.Windows.Forms.TextBox textBoxTrackName;
        private System.Windows.Forms.Label labelTrackName;
        private System.Windows.Forms.ErrorProvider errorProviderTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackLength;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Panel panelWMPlayer;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.GroupBox groupBoxUploadTrack;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.ComboBox comboBoxAlbumName;
    }
}