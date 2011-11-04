using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.DataAccessLayer;

namespace Concert.PresentationLayer
{
    public partial class EditArtistForm : Form
    {
        List<Instrument> instruments;

        public EditArtistForm()
        {
            InitializeComponent();
            LoadArtists();
            LoadInstruments();
            SelectArtist();
        }

        public EditArtistForm(Artist artist)
        {
          /*  InitializeComponent();
            LoadArtists();
            LoadInstruments();
            int index = .FindIndex(i => i.Id == instrument.Id);
        */
        }

        private void LoadInstruments()
        {
            instruments = new List<Instrument>();
            instruments.AddRange(DBObjectController.GetAllInstruments());
            foreach (Instrument instrument in DBObjectController.GetAllInstruments())
            {
                checkedListBoxInstruments.Items.Add(instrument.Name);
            }
        }

        private void LoadArtists() 
        {
            ArtistsListBox1.DisplayMember = "FirstName";
            this.ArtistsListBox1.DataSource = null;
            this.ArtistsListBox1.DataSource = DBObjectController.GetAllArtists();

            int artistIndex = this.ArtistsListBox1.SelectedIndex;
            
            if (artistIndex < 0)
            {
                this.ArtistsListBox1.DataSource = null;
                button1.Enabled = false;
                button3.Enabled = false;
                return;
            }
            else button1.Enabled = true;
        }

        private void SelectInstruments(Artist art)
        {
            foreach (int index in checkedListBoxInstruments.CheckedIndices)
            {
                checkedListBoxInstruments.SetItemChecked(index, false);
            }
            foreach (Instrument instrument in art.Instrument)
            {
                int index = instruments.FindIndex(i => i.Id == instrument.Id);
                checkedListBoxInstruments.SetItemChecked(index, true);
            }
        }

        private void SelectArtist() 
        {
            if (this.ArtistsListBox1.SelectedIndex<0)
            {
                textBox1.Clear();
                textBox2.Clear();
                dateTimePickerConcert.Value = DateTime.Today;
            }
            else
            {
                Artist artist = (Artist)ArtistsListBox1.SelectedItem;
                textBox1.Text = artist.FirstName;
                textBox2.Text = artist.LastName;
                dateTimePickerConcert.Value = artist.BirthDate;

                SelectInstruments(artist);
            }
                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArtistsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArtistsListBox1.SelectedIndex >= 0)
            {
                Artist artist = (Artist)ArtistsListBox1.SelectedItem;

                textBox1.Text = artist.FirstName;
                textBox2.Text = artist.LastName;

                dateTimePickerConcert.Value = artist.BirthDate;

                SelectInstruments(artist);
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                dateTimePickerConcert.Value = DateTime.Now;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Artist artist = (Artist) ArtistsListBox1.SelectedItem;
            artist.FirstName = textBox1.Text.Trim();
            artist.LastName  = textBox2.Text.Trim();
            artist.BirthDate = dateTimePickerConcert.Value;


            artist.Instrument.Clear();
            foreach (int index  in checkedListBoxInstruments.SelectedIndices)
            {
                artist.Instrument.Add(instruments[index]);
            }

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Artist name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Artist last name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBObjectController.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while editing artist");
                return;
            }
            MessageBox.Show("Artist edited successfully!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadArtists();
            Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Artist artist = (Artist)ArtistsListBox1.SelectedItem;

            DBObjectController.DeleteObject(artist);

            LoadArtists();
            Select();
            
        }

        private void EditArtistForm_Load(object sender, EventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = false;
            }
        }

        private void EditArtistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = true;
            }
        }
    }
}
