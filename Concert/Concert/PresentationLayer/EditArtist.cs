using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concert.DataAccessLayer;
using Concert.DBObjectDefinition;

namespace Concert.PresentationLayer
{
    public partial class EditArtist : Form
    {
        List<Instrument> instruments  = new List<Instrument>();
        List<Artist> artists          = new List<Artist>();
        List<String> artistDataSource = new List<string>();

        public EditArtist()
        {
            InitializeComponent();
            LoadInstruments();
            LoadArtists();
        }

        public EditArtist(Artist artist)
        {
            InitializeComponent();
            LoadInstruments();
            LoadArtists();
            SelectArtist(artist);
        }

        private void LoadInstruments()
        {
            instruments.AddRange(DBObjectController.GetAllInstruments());

            foreach (Instrument instrument in instruments)
            {
                checkedListBoxInstrument.Items.Add(instrument.Name);
            }
        }

        private void LoadArtists()
        {
            artists.Clear();
            artists.AddRange(DBObjectController.GetAllArtists());

            artistDataSource.Clear();
            foreach (Artist artist in artists)
            {
                artistDataSource.Add(artist.FirstName + " " + artist.LastName);
            }

            listBoxArtist.DataSource = null;
            listBoxArtist.DataSource = artistDataSource;

            if (listBoxArtist.SelectedIndex < 0)
            {
                listBoxArtist.DataSource = null;

                ClearSelectedInstruments();
            }
        }

        private void ClearSelectedInstruments()
        {
            foreach (int index in checkedListBoxInstrument.CheckedIndices)
            {
                checkedListBoxInstrument.SetItemChecked(index, false);
            }
        }

        private void SelectInstruments(Artist art)
        {
            ClearSelectedInstruments();

            //foreach (Instrument instrument in art.Instrument)
            //{
            //    int index = instruments.FindIndex(i => i.Id == instrument.Id);
            //    checkedListBoxInstrument.SetItemChecked(index, true);
            //}
        }

        private void SelectArtist(Artist artis)
        {
            //int index = artists.FindIndex(a => a.Id == artis.Id);

            //listBoxArtist.SelectedIndex = index;
        }

        private void ClearForm()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();

            dateTimePickerBirthDate.Value = DateTime.Today;

            ClearSelectedInstruments();
        }

        private void listBoxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxArtist.SelectedIndex >= 0)
            {
                Artist artist = artists[listBoxArtist.SelectedIndex];

                //textBoxFirstName.Text         = artist.FirstName;
                //textBoxLastName.Text          = artist.LastName;
                //dateTimePickerBirthDate.Value = DateTime.Parse(artist.BirthDate.ToString("dd.MM.yyyy"));

                SelectInstruments(artist);
            }
            else
            {
                ClearForm();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBoxArtist.SelectedIndex >= 0)
            {
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

                Artist artist = artists[listBoxArtist.SelectedIndex];

                //artist.FirstName = textBoxFirstName.Text;
                //artist.LastName = textBoxLastName.Text;
                //artist.BirthDate = DateTime.Parse(dateTimePickerBirthDate.Value.ToString("dd.MM.yyyy"));

                //artist.Instrument.Clear();
                //foreach (int index in checkedListBoxInstrument.CheckedIndices)
                //{
                //    artist.Instrument.Add(instruments[index]);
                //}

                DBObjectController.SaveChanges();
                MessageBox.Show("Artist edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadArtists();
            }
            else
            {
                ClearForm();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxArtist.SelectedIndex >= 0)
            {
                Artist artist = artists[listBoxArtist.SelectedIndex];

                //DBObjectController.DeleteObject(artist);

                LoadArtists();
            }
            else
            {
                ClearForm();
            }
        }

        private void EditArtist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = true;
            }
        }

        private void EditArtist_Load(object sender, EventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = false;
            }
        }
    }
}
