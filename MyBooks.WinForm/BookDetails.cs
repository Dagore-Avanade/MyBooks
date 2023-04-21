using MyBooks.Data.Entities;
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
    public partial class BookDetails : Form
    {
        public BookDetails(Book book)
        {
            InitializeComponent();
            
            titleLabel.Text = $"Título: {book.Title}";
            publicationDateLabel.Text = $"Fecha de publicación: {book.PublicationDate:dd-mm-yyyy}";
            numberOfPagesLabel.Text = $"Número de páginas: {book.NumberOfPages}";
            authorLabel.Text = $"Autor(a): {book.Author?.FirstName} {book.Author?.LastName}";
            genreLabel.Text = $"Género: {book.Genre?.Name}";
            descriptionLabel.Text = book.Description;
        }
    }
}
