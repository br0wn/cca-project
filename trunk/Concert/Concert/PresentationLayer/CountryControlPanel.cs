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
                SimpleTextValidation(textBoxCurrentCountryName, new CancelEventArgs());
                if (NoErrorProviderMsg())
                {
                    string newName = textBoxCurrentCountryName.Text;

                    dataGridViewCountry.CurrentRow.Cells[0].Value      = newName;
                    ((Country)dataGridViewCountry.CurrentRow.Tag).Name = newName;
                    
                    DBObjectController.SaveChanges();
                }
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && string.IsNullOrEmpty(errorProviderCountry.GetError(textBoxCountryName)))
            {
                string name = textBoxCountryName.Text;
                
                DBObjectController.StoreObject(new Country() { Name = name });
                
                textBoxCountryName.Clear();

                LoadCountries();
            }
        }

        private void CountryControlPanel_Load(object sender, EventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = false;
            }
        }

        private void CountryControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiParent != null)
            {
                MdiParent.MainMenuStrip.Enabled = true;
            }
        }
    }
}
