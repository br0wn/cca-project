﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concert.PresentationLayer
{
    public partial class EditArtistForm : Form
    {
        public EditArtistForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArtistsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
