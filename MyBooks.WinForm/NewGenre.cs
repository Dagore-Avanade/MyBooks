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
    public partial class NewGenre : Form
    {
        GenresService genresService = new();
        public NewGenre()
        {
            InitializeComponent();
        }

        private void AddGenreBtn_Click(object sender, EventArgs e)
        {
            string genreName = genreTextBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(genreName))
            {
                try
                {
                    if (genresService.Add(new Genre() { Name = genreName }))
                        Close();
                    else
                        MessageBox.Show("El género introducido ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Error desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduce una cadena de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
