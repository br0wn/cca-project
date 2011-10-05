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
    public partial class NewLocation : Form
    {
        private Regex digits = new Regex(@"\d+");

        public NewLocation()
        {
            InitializeComponent();
            LoadLocationData();
            dataGridViewLocation.Select();
        }

        private void LoadLocationData()
        {
            dataGridViewLocation.Rows.Clear();
            foreach (DBObjectDefinition.Location item in DBObjectController.GetAllLocations())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewLocation, new object[] {
                                                                        item.Country,
                                                                        item.Address,
                                                                        item.PostalCode,
                                                                        item.SeatCount });
                row.Tag = item;
                dataGridViewLocation.Rows.Add(row);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && NoErrorProviderMsg())
            {
                string country = textBoxCountry.Text;
                string address = textBoxAddress.Text;
                int postalCode = int.Parse(textBoxPostalCode.Text);
                int seatCount = int.Parse(textBoxSeatCount.Text);
                DBObjectController.StoreObject(new Concert.DBObjectDefinition.Location(country, address, postalCode, seatCount));
                MessageBox.Show("Successfully added new location");
                ClearForm();
                LoadLocationData();
            }
        }

        private bool NoErrorProviderMsg()
        {
            return ( errorProviderLocation.GetError(textBoxCountry) == string.Empty     &&
                     errorProviderLocation.GetError(textBoxAddress) == string.Empty     &&
                     errorProviderLocation.GetError(textBoxPostalCode) == string.Empty  &&
                     errorProviderLocation.GetError(textBoxSeatCount) == string.Empty);
        }

        private bool NoCurrentErrorProviderMsg()
        {
            return (errorProviderLocation.GetError(textBoxCountryCurrent) == string.Empty &&
                     errorProviderLocation.GetError(textBoxAddressCurrent) == string.Empty &&
                     errorProviderLocation.GetError(textBoxPostalCodeCurrent) == string.Empty &&
                     errorProviderLocation.GetError(textBoxSeatCountCurrent) == string.Empty);
        }

        private void ClearForm()
        {
            textBoxCountry.Clear();
            textBoxAddress.Clear();
            textBoxPostalCode.Clear();
            textBoxSeatCount.Clear();
        }

        private void textBoxCountry_Validating(object sender, CancelEventArgs e)
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

        private void textBoxAddress_Validating(object sender, CancelEventArgs e)
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

        private void textBoxPostalCode_Validating(object sender, CancelEventArgs e)
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

        private void textBoxSeatCount_Validating(object sender, CancelEventArgs e)
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

        private void dataGridViewLocation_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ClearCurrentErrorProvider();
            textBoxCountryCurrent.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxAddressCurrent.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPostalCodeCurrent.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSeatCountCurrent.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void ClearCurrentErrorProvider()
        {
            errorProviderLocation.SetError(textBoxCountryCurrent, string.Empty);
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
            errorProviderLocation.SetError(textBoxCountry, string.Empty);
            errorProviderLocation.SetError(textBoxAddress, string.Empty);
            errorProviderLocation.SetError(textBoxPostalCode, string.Empty);
            errorProviderLocation.SetError(textBoxSeatCount, string.Empty);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ValidateCurrentSelection();
            if (NoCurrentErrorProviderMsg())
            {
                DBObjectDefinition.Location location = (DBObjectDefinition.Location)dataGridViewLocation.CurrentRow.Tag;
                location.Country = textBoxCountryCurrent.Text;
                location.Address = textBoxAddressCurrent.Text;
                location.PostalCode = int.Parse(textBoxPostalCodeCurrent.Text);
                location.SeatCount = int.Parse(textBoxSeatCountCurrent.Text);
                DBObjectController.StoreObject(location);
                LoadLocationData();
            }
        }

        private void ValidateCurrentSelection()
        {
            ValidateCurrentCountry();
            ValidateCurrentAddress();
            ValidateCurrentPostalCode();
            ValidateCurrentSeatCount();
        }

        private void ValidateCurrentCountry()
        {
            string text = textBoxCountryCurrent.Text;
            if (string.IsNullOrWhiteSpace(text) || text == string.Empty)
            {
                errorProviderLocation.SetError(textBoxCountryCurrent, "Empty fields are not allowed");
            }
            else
            {
                errorProviderLocation.SetError(textBoxCountryCurrent, string.Empty);
            }
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
    }
}
