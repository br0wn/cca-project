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
        public NewArtistForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            DateTime birthdate = dateTimePickerConcert.Value;
            birthdate = birthdate.Date;
            List<string> instruments= new List<string>();
            defineInstruments(instruments);
            Artist artist = new Artist(firstName, lastName, birthdate);

            foreach (string instrument in instruments)
            {
                artist.AddInst(instrument);
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
            MessageBox.Show("Artist added successfully!");
            clearMethod();
        }
        private void defineInstruments(List<string> lista) {
            if (checkBox1.Checked) lista.Add("Piano");
            if (checkBox2.Checked) lista.Add("Bass guitar");
            if (checkBox3.Checked) lista.Add("Drums");
            if (checkBox4.Checked) lista.Add("Guitar");
            if (checkBox5.Checked) lista.Add("Sax");
            if (checkBox6.Checked) lista.Add("Vocal");
        }

        private void clearMethod()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            dateTimePickerConcert.Value = DateTime.Today;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        
        }

        private void NewArtistForm_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void NewArtistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void NewArtistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }
    }
}
