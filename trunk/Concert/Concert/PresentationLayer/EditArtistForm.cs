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
            LoadInstruments();
            LoadArtists();
            SelectArtist();
        }

        public EditArtistForm(Artist artist)
        {
            /*
            InitializeComponent();
            LoadArtists();
            LoadInstruments();
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
            this.listBoxArtist.DataSource = null;
            this.listBoxArtist.DataSource = DBObjectController.GetAllArtists();

            
            if (listBoxArtist.SelectedIndex < 0)
            {
                this.listBoxArtist.DataSource = null;
                
                buttonSave.Enabled   = false;
                buttonDelete.Enabled = false;

                ClearSelectedInstruments();

                return;
            }
            else buttonSave.Enabled = true;
        }

        private void ClearSelectedInstruments()
        {
            foreach (int index in checkedListBoxInstruments.CheckedIndices)
            {
                checkedListBoxInstruments.SetItemChecked(index, false);
            }
        }

        private void SelectInstruments(Artist art)
        {
            ClearSelectedInstruments();

            foreach (Instrument instrument in art.Instrument)
            {
                int index = instruments.FindIndex(i => i.Id == instrument.Id);
                checkedListBoxInstruments.SetItemChecked(index, true);
            }
        }

        private void SelectArtist() 
        {
            if (listBoxArtist.SelectedIndex < 0)
            {
                textBoxFirstName.Clear();
                textBoxLastName.Clear();

                dateTimePickerBirthDate.Value = DateTime.Today;
                
                ClearSelectedInstruments();
            }
            else
            {
                Artist artist = (Artist)listBoxArtist.SelectedItem;
                
                textBoxFirstName.Text    = artist.FirstName;
                textBoxLastName.Text     = artist.LastName;
                dateTimePickerBirthDate.Value = artist.BirthDate;

                SelectInstruments(artist);
            }
                     
        }

        private void listBoxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxArtist.SelectedIndex >= 0)
            {
                Artist artist = (Artist)listBoxArtist.SelectedItem;

                textBoxFirstName.Text         = artist.FirstName;
                textBoxLastName.Text          = artist.LastName.ToString();
                dateTimePickerBirthDate.Value = DateTime.Parse(artist.BirthDate.ToString("dd.MM.yyyy"));

                SelectInstruments(artist);
            }
            else
            {
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                dateTimePickerBirthDate.Value = DateTime.Now;
                ClearSelectedInstruments();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Artist artist = (Artist) listBoxArtist.SelectedItem;
            
            artist.FirstName = textBoxFirstName.Text;
            artist.LastName  = textBoxLastName.Text;
            artist.BirthDate = DateTime.Parse(dateTimePickerBirthDate.Value.ToString("dd.MM.yyyy"));

            artist.Instrument.Clear();
            foreach (int index  in checkedListBoxInstruments.SelectedIndices)
            {
                artist.Instrument.Add(instruments[index]);
            }

            if (textBoxFirstName.Text == string.Empty)
            {
                MessageBox.Show("Artist name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxLastName.Text == string.Empty)
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
            SelectArtist();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Artist artist = (Artist)listBoxArtist.SelectedItem;

            DBObjectController.DeleteObject(artist);

            LoadArtists();
            SelectArtist();
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
