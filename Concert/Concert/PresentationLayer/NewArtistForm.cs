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
    public partial class NewArtistForm : Form
    {
        List<Instrument> instruments;

        public NewArtistForm()
        {
            InitializeComponent();
            LoadInstruments();
            checkedListBoxInstruments.CheckOnClick = true;
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            string firstName   = textBox1.Text.Trim();
            string lastName    = textBox2.Text.Trim();
            DateTime birthdate = DateTime.Parse(dateTimePickerConcert.Value.ToString("dd.MM.yyyy"));

            Artist artist = new Artist() { FirstName = firstName,
                                           LastName  = lastName,
                                           BirthDate = birthdate };

            foreach (int index in checkedListBoxInstruments.CheckedIndices)
            {
                //artist.Instrument.Add(instruments[index]);
            }

            if (firstName == string.Empty)
            {
                MessageBox.Show("Artist name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lastName == string.Empty)
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
                MessageBox.Show("Error while addign artist");
                return;
            }
            MessageBox.Show("Artist added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearMethod();
        }

        private void clearMethod()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            foreach (int index in checkedListBoxInstruments.CheckedIndices)
            {
                checkedListBoxInstruments.SetItemChecked(index, false);
            }
        }

        private void NewArtistForm_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void NewArtistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }

        private void NewArtistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }
    }
}
