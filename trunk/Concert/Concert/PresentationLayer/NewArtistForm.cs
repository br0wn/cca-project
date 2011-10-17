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
            //MessageBox.Show(firstName +" "+ lastName + " " + birthdate.ToString() + " " + instruments.First().ToString());
        }
        private void defineInstruments(List<string> lista) {
            if (checkBox1.Checked) lista.Add("Piano");
            if (checkBox2.Checked) lista.Add("Bass guitar");
            if (checkBox3.Checked) lista.Add("Drums");
            if (checkBox4.Checked) lista.Add("Guitar");
            if (checkBox5.Checked) lista.Add("Sax");
            if (checkBox6.Checked) lista.Add("Percussion");
        }  


        private void groupBox2_Enter(object sender, EventArgs e)
        {
        
        }
    }
}
