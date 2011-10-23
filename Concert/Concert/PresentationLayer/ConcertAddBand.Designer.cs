namespace Concert.PresentationLayer
{
    partial class ConcertAddBand
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
            this.checkedListBoxBands = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxBands
            // 
            this.checkedListBoxBands.FormattingEnabled = true;
            this.checkedListBoxBands.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxBands.Name = "checkedListBoxBands";
            this.checkedListBoxBands.Size = new System.Drawing.Size(120, 169);
            this.checkedListBoxBands.TabIndex = 0;
            // 
            // ConcertAddBand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(121, 170);
            this.Controls.Add(this.checkedListBoxBands);
            this.Name = "ConcertAddBand";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConcertAddBand_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxBands;
    }
}