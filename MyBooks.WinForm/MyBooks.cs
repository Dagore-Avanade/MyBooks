using Microsoft.EntityFrameworkCore;
using MyBooks.Data;
using MyBooks.Data.Entities;
using MyBooks.WinForm.Services;
using System.Linq;

namespace MyBooks.WinForm
{
    public partial class MyBooks : Form
    {
        readonly BooksService booksService = new();
        public MyBooks()
        {
            InitializeComponent();
            LoadBooks();
        }
        public void LoadBooks()
        {
            listViewBooks.Items.Clear();
            listViewBooks.View = View.Details;
            listViewBooks.GridLines = true;

            foreach (var book in booksService.All())
            {
                var item = new ListViewItem(new string[]
                {
                    book.Title,
                    book.PublicationDate.ToString("dd-MM-yyyy"),
                    book.NumberOfPages.ToString(),
                    $"{book.Author?.FirstName} {book.Author?.LastName}",
                    $"{book.Genre?.Name}"
                });

                item.Tag = book;
                listViewBooks.Items.Add(item);
            }
            listViewBooks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ListViewBooks_DoubleClick(object sender, EventArgs e)
        {
            var book = (Book)listViewBooks.SelectedItems[0].Tag;
            if (book is not null)
                new BookDetails(book).Show();
        }

        private void NewGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewGenre().ShowDialog();
        }

        private void ListViewBooks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listViewBooks.FocusedItem;
                if (focusedItem is not null && focusedItem.Bounds.Contains(e.Location))
                {
                    itemContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = listViewBooks.SelectedItems[0];
            var book = (Book)item.Tag;
            var result = new NewBook(book).ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void DetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewBooks_DoubleClick(sender, e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = listViewBooks.SelectedItems[0];
            var book = (Book)item.Tag;
            var result = MessageBox.Show($"¿Está seguro(a) de querer eliminar \"{book.Title}\"?", "Confirmación requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                booksService.Delete(book);
                LoadBooks();
            }
        }

        private void NewAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewAuthor().ShowDialog();
        }

        private void NewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewBook().ShowDialog();
            LoadBooks();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}