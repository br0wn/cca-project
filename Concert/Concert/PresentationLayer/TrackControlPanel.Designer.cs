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
            this.dataGridViewTracks = new System.Windows.Forms.DataGridView();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTrack = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxTrackNameCurrent = new System.Windows.Forms.TextBox();
            this.textBoxTrackLengthCurrent = new System.Windows.Forms.TextBox();
            this.labelTrackNameCurrent = new System.Windows.Forms.Label();
            this.labelTrackLengthCurrent = new System.Windows.Forms.Label();
            this.groupBoxNewTrack = new System.Windows.Forms.GroupBox();
            this.labelTrackName = new System.Windows.Forms.Label();
            this.textBoxTrackName = new System.Windows.Forms.TextBox();
            this.textBoxTrackLength = new System.Windows.Forms.TextBox();
            this.labelTrackLength = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).BeginInit();
            this.groupBoxTrack.SuspendLayout();
            this.groupBoxNewTrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTracks
            // 
            this.dataGridViewTracks.AllowUserToAddRows = false;
            this.dataGridViewTracks.AllowUserToDeleteRows = false;
            this.dataGridViewTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackName,
            this.TrackLength});
            this.dataGridViewTracks.Location = new System.Drawing.Point(17, 19);
            this.dataGridViewTracks.Name = "dataGridViewTracks";
            this.dataGridViewTracks.ReadOnly = true;
            this.dataGridViewTracks.Size = new System.Drawing.Size(246, 136);
            this.dataGridViewTracks.TabIndex = 0;
            // 
            // TrackName
            // 
            this.TrackName.HeaderText = "Name";
            this.TrackName.Name = "TrackName";
            this.TrackName.ReadOnly = true;
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
            this.groupBoxTrack.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTrack.Name = "groupBoxTrack";
            this.groupBoxTrack.Size = new System.Drawing.Size(285, 219);
            this.groupBoxTrack.TabIndex = 1;
            this.groupBoxTrack.TabStop = false;
            this.groupBoxTrack.Text = "Track Control";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(17, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(40, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxTrackNameCurrent
            // 
            this.textBoxTrackNameCurrent.Location = new System.Drawing.Point(63, 192);
            this.textBoxTrackNameCurrent.Name = "textBoxTrackNameCurrent";
            this.textBoxTrackNameCurrent.Size = new System.Drawing.Size(88, 20);
            this.textBoxTrackNameCurrent.TabIndex = 2;
            // 
            // textBoxTrackLengthCurrent
            // 
            this.textBoxTrackLengthCurrent.Location = new System.Drawing.Point(157, 192);
            this.textBoxTrackLengthCurrent.Name = "textBoxTrackLengthCurrent";
            this.textBoxTrackLengthCurrent.Size = new System.Drawing.Size(88, 20);
            this.textBoxTrackLengthCurrent.TabIndex = 3;
            // 
            // labelTrackNameCurrent
            // 
            this.labelTrackNameCurrent.AutoSize = true;
            this.labelTrackNameCurrent.Location = new System.Drawing.Point(60, 176);
            this.labelTrackNameCurrent.Name = "labelTrackNameCurrent";
            this.labelTrackNameCurrent.Size = new System.Drawing.Size(41, 13);
            this.labelTrackNameCurrent.TabIndex = 2;
            this.labelTrackNameCurrent.Text = "Name :";
            // 
            // labelTrackLengthCurrent
            // 
            this.labelTrackLengthCurrent.AutoSize = true;
            this.labelTrackLengthCurrent.Location = new System.Drawing.Point(154, 176);
            this.labelTrackLengthCurrent.Name = "labelTrackLengthCurrent";
            this.labelTrackLengthCurrent.Size = new System.Drawing.Size(46, 13);
            this.labelTrackLengthCurrent.TabIndex = 4;
            this.labelTrackLengthCurrent.Text = "Length :";
            // 
            // groupBoxNewTrack
            // 
            this.groupBoxNewTrack.Controls.Add(this.buttonCancel);
            this.groupBoxNewTrack.Controls.Add(this.buttonAdd);
            this.groupBoxNewTrack.Controls.Add(this.textBoxTrackLength);
            this.groupBoxNewTrack.Controls.Add(this.labelTrackLength);
            this.groupBoxNewTrack.Controls.Add(this.textBoxTrackName);
            this.groupBoxNewTrack.Controls.Add(this.labelTrackName);
            this.groupBoxNewTrack.Location = new System.Drawing.Point(12, 237);
            this.groupBoxNewTrack.Name = "groupBoxNewTrack";
            this.groupBoxNewTrack.Size = new System.Drawing.Size(285, 100);
            this.groupBoxNewTrack.TabIndex = 2;
            this.groupBoxNewTrack.TabStop = false;
            this.groupBoxNewTrack.Text = "New track";
            // 
            // labelTrackName
            // 
            this.labelTrackName.AutoSize = true;
            this.labelTrackName.Location = new System.Drawing.Point(53, 22);
            this.labelTrackName.Name = "labelTrackName";
            this.labelTrackName.Size = new System.Drawing.Size(41, 13);
            this.labelTrackName.TabIndex = 0;
            this.labelTrackName.Text = "Name :";
            // 
            // textBoxTrackName
            // 
            this.textBoxTrackName.Location = new System.Drawing.Point(100, 19);
            this.textBoxTrackName.Name = "textBoxTrackName";
            this.textBoxTrackName.Size = new System.Drawing.Size(117, 20);
            this.textBoxTrackName.TabIndex = 1;
            // 
            // textBoxTrackLength
            // 
            this.textBoxTrackLength.Location = new System.Drawing.Point(100, 45);
            this.textBoxTrackLength.Name = "textBoxTrackLength";
            this.textBoxTrackLength.Size = new System.Drawing.Size(117, 20);
            this.textBoxTrackLength.TabIndex = 3;
            // 
            // labelTrackLength
            // 
            this.labelTrackLength.AutoSize = true;
            this.labelTrackLength.Location = new System.Drawing.Point(48, 48);
            this.labelTrackLength.Name = "labelTrackLength";
            this.labelTrackLength.Size = new System.Drawing.Size(46, 13);
            this.labelTrackLength.TabIndex = 2;
            this.labelTrackLength.Text = "Length :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(100, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(167, 71);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // TrackControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 347);
            this.Controls.Add(this.groupBoxNewTrack);
            this.Controls.Add(this.groupBoxTrack);
            this.Name = "TrackControlPanel";
            this.Text = "TrackControlPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).EndInit();
            this.groupBoxTrack.ResumeLayout(false);
            this.groupBoxTrack.PerformLayout();
            this.groupBoxNewTrack.ResumeLayout(false);
            this.groupBoxNewTrack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackLength;
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
    }
}