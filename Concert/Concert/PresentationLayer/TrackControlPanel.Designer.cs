namespace Concert.PresentationLayer
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
            this.dataGridViewTracks = new System.Windows.Forms.DataGridView();
            this.groupBoxTrack = new System.Windows.Forms.GroupBox();
            this.labelTrackLengthCurrent = new System.Windows.Forms.Label();
            this.labelTrackNameCurrent = new System.Windows.Forms.Label();
            this.textBoxTrackLengthCurrent = new System.Windows.Forms.TextBox();
            this.textBoxTrackNameCurrent = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxNewTrack = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTrackLength = new System.Windows.Forms.TextBox();
            this.labelTrackLength = new System.Windows.Forms.Label();
            this.textBoxTrackName = new System.Windows.Forms.TextBox();
            this.labelTrackName = new System.Windows.Forms.Label();
            this.errorProviderTrack = new System.Windows.Forms.ErrorProvider(this.components);
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).BeginInit();
            this.groupBoxTrack.SuspendLayout();
            this.groupBoxNewTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTrack)).BeginInit();
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
            this.dataGridViewTracks.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTracks_RowEnter);
            this.dataGridViewTracks.SelectionChanged += new System.EventHandler(this.dataGridViewTracks_SelectionChanged);
            this.dataGridViewTracks.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewTracks_UserDeletedRow);
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
            this.groupBoxNewTrack.Controls.Add(this.buttonCancel);
            this.groupBoxNewTrack.Controls.Add(this.buttonAdd);
            this.groupBoxNewTrack.Controls.Add(this.textBoxTrackLength);
            this.groupBoxNewTrack.Controls.Add(this.labelTrackLength);
            this.groupBoxNewTrack.Controls.Add(this.textBoxTrackName);
            this.groupBoxNewTrack.Controls.Add(this.labelTrackName);
            this.groupBoxNewTrack.Location = new System.Drawing.Point(12, 237);
            this.groupBoxNewTrack.Name = "groupBoxNewTrack";
            this.groupBoxNewTrack.Size = new System.Drawing.Size(350, 100);
            this.groupBoxNewTrack.TabIndex = 2;
            this.groupBoxNewTrack.TabStop = false;
            this.groupBoxNewTrack.Text = "New track";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(222, 71);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(131, 71);
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
            this.errorProviderTrack.ContainerControl = this;
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
            // TrackControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 347);
            this.Controls.Add(this.groupBoxNewTrack);
            this.Controls.Add(this.groupBoxTrack);
            this.Name = "TrackControlPanel";
            this.Text = "TrackControlPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).EndInit();
            this.groupBoxTrack.ResumeLayout(false);
            this.groupBoxTrack.PerformLayout();
            this.groupBoxNewTrack.ResumeLayout(false);
            this.groupBoxNewTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTrack)).EndInit();
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
    }
}