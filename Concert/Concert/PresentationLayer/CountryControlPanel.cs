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
    public partial class CountryControlPanel : Form
    {
        public CountryControlPanel()
        {
            InitializeComponent();
            LoadCountries();
        }

        public void LoadCountries()
        {
            dataGridViewCountry.Rows.Clear();
            foreach (Country country in DBObjectController.GetAllCountries())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewCountry, new object[] { country.Name });
                row.Tag = country;
                dataGridViewCountry.Rows.Add(row);
            }
        }

        private void dataGridViewCountry_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCountry.CurrentRow != null)
            {
                textBoxCurrentCountryName.Text = ((Country)dataGridViewCountry.CurrentRow.Tag).Name;
            }
            else
            {
                textBoxCurrentCountryName.Clear();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewCountry.CurrentRow != null)
            {
                if ( ValidateChildren() && NoErrorProviderMsg())
                ((Country)dataGridViewCountry.CurrentRow.Tag).Name = textBoxCurrentCountryName.Text;
                DBObjectController.SaveChanges();
            }
            else
            {
                textBoxCurrentCountryName.Clear();
            }
        }

        private bool NoErrorProviderMsg()
        {
            return string.IsNullOrEmpty(errorProviderCountry.GetError(textBoxCurrentCountryName));
        }

        private void dataGridViewCountry_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DBObjectController.DeleteObject((Country)dataGridViewCountry.CurrentRow.Tag);
            LoadCountries();
        }

        private void SimpleTextValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text == string.Empty)
            {
                errorProviderCountry.SetError((TextBox)sender, "Empty fields are not allowed");
            }
            else
            {
                errorProviderCountry.SetError((TextBox)sender, string.Empty);
            }
        }
    }
}
