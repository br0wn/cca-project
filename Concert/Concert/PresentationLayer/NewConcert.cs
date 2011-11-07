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

namespace Concert.PresentationLayer
{
    public partial class NewConcert : Form
    {
        private Regex digits = new Regex(@"^\d+$");

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
            foreach (Location location in DBObjectController.GetAllLocations())
            {
                DataGridViewRow row = new DataGridViewRow();

                string country = location.Country != null ? location.Country.Name : "N/A";

                row.CreateCells(dataGridViewLocation, new object[] { country, 
                                                                     location.Address, 
                                                                     location.PostalCode,
                                                                     location.SeatCount });
                row.Tag = location;
                dataGridViewLocation.Rows.Add(row);
            }
        }

        private void LoadBands()
        {
            foreach (Band band in DBObjectController.GetAllBands())
            {
                bands.Add(band);
                checkedListBoxBands.Items.Add(band.Name);
            }
            checkedListBoxBands.CheckOnClick = true;
        }

        private void buttonAddConcert_Click(object sender, EventArgs e)
        {
            if (location != null)
            {
                if (ValidateChildren())
                {
                    string name     = textBoxConcertName.Text;
                    DateTime date   = dateTimePickerConcert.Value;
                    int ticketPrice = int.Parse(textBoxTicketPrice.Text);
                    
                    Concert concert = new Concert() { Name = name,
                                                      Date = date,
                                                      TicketPrice = ticketPrice,
                                                      Location = location };

                    AddHiredBands(concert);

                    DBObjectController.StoreObject( concert );

                    MessageBox.Show("You have successfully added new concert.", "Success confirmation");
                    ClearForm();
                }
            }
            else 
            {
                MessageBox.Show("Location is not set, please choose valid location.", "Information incomplete");
            }
        }

        private void AddHiredBands(Concert concert)
        {
            foreach (int index in checkedListBoxBands.CheckedIndices)
            {
                concert.Band.Add(bands[index]);
            }
            ClearHiredBands();
        }

        private void ClearHiredBands()
        {
            foreach (int index in checkedListBoxBands.CheckedIndices)
            {
                checkedListBoxBands.SetItemChecked(index, false);
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
            location = null;
            checkedListBoxBands.ClearSelected();
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
            if (dataGridViewLocation.CurrentRow != null)
            {
                location = (Location)dataGridViewLocation.CurrentRow.Tag;
            }
        }

        private void NewConcert_Load(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = false;
        }

        private void NewConcert_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
        }

        private void buttonAddNewLocation_Click(object sender, EventArgs e)
        {
            PresentationLayer.NewLocation locationForm = new PresentationLayer.NewLocation();
            locationForm.ShowDialog();
            MdiParent.MainMenuStrip.Enabled = false;
            LoadLocations();
        }

        private void dataGridViewLocation_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLocation.CurrentRow != null)
            {
                location = (Location)((DataGridView)sender).CurrentRow.Tag;
            }
        }
    }
}
