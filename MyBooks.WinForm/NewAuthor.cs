using MyBooks.Data.Entities;
using MyBooks.WinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooks.WinForm
{
    public partial class NewAuthor : Form
    {
        readonly AuthorsService authorsService = new();
        public NewAuthor()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string country = countryTextBox.Text.Trim();
            DateTime dateOfBirth = dateTimePickerBirth.Value;
            DateTime dateOfDeath = dateTimePickerDeath.Value;

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(country) && dateTimePickerBirth.Checked)
            {
                var author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Country = country,
                    DateOfBirth = dateOfBirth,
                    DateOfDeath = dateTimePickerDeath.Checked ? dateOfDeath : null
                };

                try
                {
                    if (authorsService.Add(author))
                        Close();
                    else
                        MessageBox.Show("El autor ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Error desconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
