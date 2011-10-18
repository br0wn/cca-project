using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.DBObjectDefinition;
using Concert.DataAccessLayer;

namespace Concert.PresentationLayer
{
    public partial class EditArtistForm : Form
    {
        public EditArtistForm()
        {
            InitializeComponent();
            LoadArtists();
            Select();
            
        }

        private void LoadArtists() {
            this.ArtistsListBox1.DataSource = null;
            this.ArtistsListBox1.DataSource = DBObjectController.GetAllArtists().ToList();
            int artistIndex = this.ArtistsListBox1.SelectedIndex;
            if (artistIndex < 0)
            {
                this.ArtistsListBox1.DataSource = null; ;
                return;
            }
        }

        private void Select() {
            if (this.ArtistsListBox1.SelectedIndex<0)
            {
                textBox1.Clear();
                textBox2.Clear();
                dateTimePickerConcert.Value = DateTime.Today;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
            else
            {
                Artist artist = (Artist)ArtistsListBox1.SelectedItem;
                textBox1.Text = artist.Firstname;
                textBox2.Text = artist.Lastname;
                dateTimePickerConcert.Value = artist.BirthDate;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                foreach (string instrument in artist.Instruments)
                {
                    //MessageBox.Show(instrument);
                    switch (instrument)
                    {
                        case "Piano":
                            checkBox1.Checked = true;
                            break;
                        case "Bass guitar":
                            checkBox2.Checked = true;
                            break;
                        case "Drums":
                            checkBox3.Checked = true;
                            break;
                        case "Guitar":
                            checkBox4.Checked = true;
                            break;
                        case "Sax":
                            checkBox5.Checked = true;
                            break;
                        case "Percussion":
                            checkBox6.Checked = true;
                            break;
                    }
                }
            }
                     
        }

        private void defineInstruments(List<string> lista)
        {
            if (checkBox1.Checked) lista.Add("Piano");
            if (checkBox2.Checked) lista.Add("Bass guitar");
            if (checkBox3.Checked) lista.Add("Drums");
            if (checkBox4.Checked) lista.Add("Guitar");
            if (checkBox5.Checked) lista.Add("Sax");
            if (checkBox6.Checked) lista.Add("Percussion");
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArtistsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBObjectDefinition.Artist artist = (DBObjectDefinition.Artist) ArtistsListBox1.SelectedItem;
            artist.Firstname = textBox1.Text.Trim();
            artist.Lastname = textBox2.Text.Trim();
            artist.BirthDate = dateTimePickerConcert.Value;
            List<string> instruments = new List<string>();
            defineInstruments(instruments);
            artist.ResetInst();

            foreach (string instrument in instruments)
            {
                artist.AddInst(instrument);
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
                DBObjectController.StoreObject(artist);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while editing artist");
                return;
            }
            MessageBox.Show("Artist edited successfully!");
            LoadArtists();
            Select();
        }

        private void ArtistsListBox1_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBObjectDefinition.Artist artist = (DBObjectDefinition.Artist)ArtistsListBox1.SelectedItem;


            switch (MessageBox.Show("Are you sure you want to delete the selected artist?",
                            "Delete the artist",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DBObjectController.DeleteObject(artist);
                    break;

                case DialogResult.No:
                    // "No" processing
                    break;
            }
            LoadArtists();
            Select();
            
        }

        private void EditArtistForm_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void EditArtistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }
    }
}
