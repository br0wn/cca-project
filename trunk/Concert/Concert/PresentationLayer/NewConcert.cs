using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Concert.DataAccessLayer;
using Concert.DBObjectDefinition;

namespace Concert.PresentationLayer
{
    public partial class NewConcert : Form
    {
        private Regex digits = new Regex(@"\d+");

        private Location location;

        List<Band> bands;

        public NewConcert()
        {
            bands = new List<Band>();
            InitializeComponent();
            LoadLocations();
            LoadBands();
        }

        private void LoadLocations()
        {
            dataGridViewLocation.Rows.Clear();
            foreach (DBObjectDefinition.Location item in DBObjectController.GetAllLocations())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewLocation, new object[] { item.Country, 
                                                                     item.Address, 
                                                                     item.PostalCode,
                                                                     item.SeatCount });
                row.Tag = item;
                dataGridViewLocation.Rows.Add(row);
            }
        }

        private void LoadBands()
        {
            foreach (Band item in DBObjectController.GetAllBands())
            {
                bands.Add(item);
                checkedListBoxBands.Items.Add(item.Name);
            }
            checkedListBoxBands.CheckOnClick = true;
        }

        private void buttonAddConcert_Click(object sender, EventArgs e)
        {
            if (location != null)
            {
                if (ValidateChildren())
                {
                    string name = textBoxConcertName.Text;
                    int ticketPrice = int.Parse(textBoxTicketPrice.Text);
                    DateTime date = dateTimePickerConcert.Value;
                    DBObjectDefinition.Concert concert = new Concert.DBObjectDefinition.Concert(name, ticketPrice, date.Date);
                    concert.GeoLocation = location;
                    AddHiredBands(concert);
                    DBObjectController.StoreObject(concert);
                    MessageBox.Show("You have successfully added new concert." + concert.Bands.Count, "Success confirmation");
                    ClearForm();
                }
            }
            else 
            {
                MessageBox.Show("Location is not set, please choose valid location.", "Information incomplete");
            }
        }

        private void AddHiredBands(DBObjectDefinition.Concert concert)
        {
            foreach (int index in checkedListBoxBands.CheckedIndices)
            {
                concert.AddBand(bands[index]);
            }
        }

        private void textBoxConcertName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text == string.Empty)
            {
                errorProviderConcert.SetError((TextBox)sender, "Empty fields are not allowed");
                e.Cancel = true;
            }
            else
            {
                errorProviderConcert.SetError((TextBox)sender, string.Empty);
                e.Cancel = false;
            }
        }

        private void textBoxTicketPrice_Validating(object sender, CancelEventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderConcert.SetError((TextBox)sender, "Empty fields are not allowed");
                e.Cancel = true;
            }
            else if (!IsNumeric(text))
            {
                errorProviderConcert.SetError((TextBox)sender, "Only numeric value is allowed");
                e.Cancel = true;
            }
            else
            {
                errorProviderConcert.SetError((TextBox)sender, string.Empty);
                e.Cancel = false;
            }
        }

        private void NewConcert_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private bool IsNumeric(string text)
        {
            return digits.IsMatch(text);
        }

        private void ClearForm()
        {
            textBoxConcertName.Clear();
            textBoxTicketPrice.Clear();
            dateTimePickerConcert.Value = DateTime.Now;
        }

        private void dateTimePickerConcert_Validating(object sender, CancelEventArgs e)
        {
            if (((DateTimePicker)sender).Value == null)
            {
                errorProviderConcert.SetError((DateTimePicker)sender, "You must choose specific date");
                e.Cancel = true;
            }
            else
            {
                errorProviderConcert.SetError((DateTimePicker)sender, string.Empty);
                e.Cancel = false;
            }
        }

        private void buttonSetLocation_Click(object sender, EventArgs e)
        {
            location = (Location)dataGridViewLocation.CurrentRow.Tag;
        }

        private void NewConcert_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void NewConcert_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }
    }
}
