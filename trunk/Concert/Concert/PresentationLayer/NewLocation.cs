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
    public partial class NewLocation : Form
    {
        private Regex digits = new Regex(@"^\d+$");

        public NewLocation()
        {
            InitializeComponent();
            LoadLocationData();
            LoadCountryData();
            dataGridViewLocation.Select();
        }

        private void LoadLocationData()
        {
            dataGridViewLocation.Rows.Clear();
            foreach (Location location in DBObjectController.GetAllLocations())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewLocation, new object[] { location.Country.Name,
                                                                     location.Address, 
                                                                     location.PostalCode,
                                                                     location.SeatCount });
                row.Tag = location;
                dataGridViewLocation.Rows.Add(row);
            }
        }

        private void LoadCountryData()
        {
            comboBoxCountry.DataSource        = DBObjectController.GetAllCountries();
            comboBoxCountryCurrent.DataSource = DBObjectController.GetAllCountries();

            comboBoxCountry.DisplayMember        = "Name";
            comboBoxCountryCurrent.DisplayMember = "Name";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && NoErrorProviderMsg())
            {
                string address  = textBoxAddress.Text;
                int postalCode  = int.Parse(textBoxPostalCode.Text);
                int seatCount   = int.Parse(textBoxSeatCount.Text);
                Country country = (Country)comboBoxCountry.SelectedItem; 

                DBObjectController.StoreObject(new Location() {   Address    = address, 
                                                                SeatCount  = seatCount,
                                                                PostalCode = postalCode,
                                                                Country    = country });

                MessageBox.Show("Successfully added new location");
                
                ClearForm();
                LoadLocationData();
            }
        }

        private bool NoErrorProviderMsg()
        {
            return ( errorProviderLocation.GetError(comboBoxCountry)   == string.Empty  &&
                     errorProviderLocation.GetError(textBoxAddress)    == string.Empty  &&
                     errorProviderLocation.GetError(textBoxPostalCode) == string.Empty  &&
                     errorProviderLocation.GetError(textBoxSeatCount)  == string.Empty);
        }

        private bool NoCurrentErrorProviderMsg()
        {
            return ( errorProviderLocation.GetError(comboBoxCountryCurrent)   == string.Empty &&
                     errorProviderLocation.GetError(textBoxAddressCurrent)    == string.Empty &&
                     errorProviderLocation.GetError(textBoxPostalCodeCurrent) == string.Empty &&
                     errorProviderLocation.GetError(textBoxSeatCountCurrent)  == string.Empty);
        }

        private void ClearForm()
        {
            comboBoxCountry.SelectedIndex = 0;
            textBoxAddress.Clear();
            textBoxPostalCode.Clear();
            textBoxSeatCount.Clear();
        }


        private void comboBoxCountry_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedItem == null)
            {
                errorProviderLocation.SetError((ComboBox)sender, "Choose valid country");
            }
            else
            {
                errorProviderLocation.SetError((ComboBox)sender, String.Empty); 
            }
        }

        private void SimpleTextValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text == string.Empty)
            {
                errorProviderLocation.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else
            {
                errorProviderLocation.SetError((TextBox)sender, string.Empty);
            }
        }

        private void SimpleNumericValidation(object sender, CancelEventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderLocation.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else if (!IsNumeric(text))
            {
                errorProviderLocation.SetError((TextBox)sender, "Only numeric value is allowed");
            }
            else
            {
                errorProviderLocation.SetError((TextBox)sender, string.Empty);
            }
        }

        private bool IsNumeric(string text)
        {
            return digits.IsMatch(text);
        }

        private void ClearCurrentErrorProvider()
        {
            errorProviderLocation.SetError(comboBoxCountryCurrent, string.Empty);
            errorProviderLocation.SetError(textBoxAddressCurrent, string.Empty);
            errorProviderLocation.SetError(textBoxPostalCodeCurrent, string.Empty);
            errorProviderLocation.SetError(textBoxSeatCountCurrent, string.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            ResetErrorProvider();
        }

        private void ResetErrorProvider()
        {
            errorProviderLocation.SetError(comboBoxCountry, string.Empty);
            errorProviderLocation.SetError(textBoxAddress, string.Empty);
            errorProviderLocation.SetError(textBoxPostalCode, string.Empty);
            errorProviderLocation.SetError(textBoxSeatCount, string.Empty);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocation.CurrentRow != null)
            {
                ValidateCurrentSelection();
                if (NoCurrentErrorProviderMsg())
                {
                    Location location = (Location)dataGridViewLocation.CurrentRow.Tag;

                    location.Address    = textBoxAddressCurrent.Text;
                    location.SeatCount  = int.Parse(textBoxSeatCountCurrent.Text);
                    location.PostalCode = int.Parse(textBoxPostalCodeCurrent.Text);

                    location.Country = (Country)comboBoxCountryCurrent.SelectedItem;

                    dataGridViewLocation.CurrentRow.Cells[0].Value = location.Country.Name;
                    dataGridViewLocation.CurrentRow.Cells[1].Value = location.Address;
                    dataGridViewLocation.CurrentRow.Cells[2].Value = location.PostalCode;
                    dataGridViewLocation.CurrentRow.Cells[3].Value = location.SeatCount;

                    DBObjectController.SaveChanges();
                }
            }
            else
            {
                ClearCurrentSelection();
            }
        }

        private void ValidateCurrentSelection()
        {
            ValidateCurrentAddress();
            ValidateCurrentPostalCode();
            ValidateCurrentSeatCount();
        }

        private void ValidateCurrentAddress()
        {
            string text = textBoxAddressCurrent.Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderLocation.SetError(textBoxAddressCurrent, "Empty fields are not allowed");
            }
            else
            {
                errorProviderLocation.SetError(textBoxAddressCurrent, string.Empty);
            }
        }

        private void ValidateCurrentPostalCode()
        {
            string text = textBoxPostalCodeCurrent.Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderLocation.SetError(textBoxPostalCodeCurrent, "Empty fields are not allowed");
            }
            else if (!IsNumeric(text))
            {
                errorProviderLocation.SetError(textBoxPostalCodeCurrent, "Only numeric value is allowed");
            }
            else
            {
                errorProviderLocation.SetError(textBoxPostalCodeCurrent, string.Empty);
            }
        }

        private void ValidateCurrentSeatCount()
        {
            string text = textBoxSeatCountCurrent.Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderLocation.SetError(textBoxSeatCountCurrent, "Empty fields are not allowed");
            }
            else if (!IsNumeric(text))
            {
                errorProviderLocation.SetError(textBoxSeatCountCurrent, "Only numeric value is allowed");
            }
            else
            {
                errorProviderLocation.SetError(textBoxSeatCountCurrent, string.Empty);
            }
        }

        private void dataGridViewLocation_SelectionChanged(object sender, EventArgs e)
        {
            ClearCurrentErrorProvider();
            if (((DataGridView)sender).CurrentRow != null)
            {
                SelectCurrentCountry(((Location)((DataGridView)sender).CurrentRow.Tag).Country);
                textBoxAddressCurrent.Text = ((DataGridView)sender).CurrentRow.Cells[1].Value.ToString();
                textBoxPostalCodeCurrent.Text = ((DataGridView)sender).CurrentRow.Cells[2].Value.ToString();
                textBoxSeatCountCurrent.Text = ((DataGridView)sender).CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                ClearCurrentSelection();
            }
        }

        private void SelectCurrentCountry(Country country)
        {
            comboBoxCountryCurrent.SelectedItem = country;
        }

        private void ClearCurrentSelection()
        {
            textBoxAddressCurrent.Clear();
            textBoxPostalCodeCurrent.Clear();
            textBoxSeatCountCurrent.Clear();
        }

        private void NewLocation_Load(object sender, EventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = false;
            }
        }

        private void NewLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = true;
            }
        }

        private void dataGridViewLocation_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DBObjectController.DeleteObject((Location)e.Row.Tag);
        }
    }
}
