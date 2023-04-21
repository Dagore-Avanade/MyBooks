using MyBooks.Data.Entities;
using MyBooks.WinForm.Services;
using MyBooks.WinForm.ViewModels;
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
    public partial class NewBook : Form
    {
        readonly AuthorsService authorsService = new();
        readonly GenresService genresService = new();
        readonly BooksService booksService = new();
        bool isUpdate;
        int bookId;
        public NewBook()
        {
            InitializeComponent();
            isUpdate = false;
            bookId = -1;
            authorComboBox.Items.AddRange(authorsService.AllViewModel());
            genreComboBox.Items.AddRange(genresService.AllViewModel());
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text.Trim();
            DateTime publicationDate = publicationDateTimePicker.Value;
            int numberOfPages = (int)numberOfPagesNumericUpDown.Value;
            var author = authorComboBox.SelectedItem;
            var genre = genreComboBox.SelectedItem;
            string description = descriptionTextBox.Text.Trim();

            if (publicationDateTimePicker.Checked && author is not null && genre is not null && !string.IsNullOrEmpty(title) && (bool)numberOfPagesNumericUpDown.Tag)
            {
                var newBook = new Book()
                {
                    Title = title,
                    PublicationDate = publicationDate,
                    NumberOfPages = numberOfPages,
                    Description = description,
                    AuthorId = ((AuthorViewModel)author).AuthorId,
                    GenreId = ((GenreViewModel)genre).GenreId
                };

                try
                {
                    if (isUpdate)
                    {
                        newBook.BookId = bookId;
                    }
                    else
                    {
                        booksService.Add(newBook);
                    }
                    Close();
                }
                catch
                {
                    MessageBox.Show("Error desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumberOfPagesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            numberOfPagesNumericUpDown.Tag = true;
        }
    }
}
