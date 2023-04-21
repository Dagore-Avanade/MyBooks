using Microsoft.EntityFrameworkCore;
using MyBooks.Data;
using MyBooks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooks.WinForm.Services
{
    internal class BooksService
    {
        readonly LibraryContext libraryContext = new LibraryContext();
        public List<Book> All()
        {
            return libraryContext.Books
                .Include(book => book.Author)
                .Include(book => book.Genre)
                .ToList();
        }
        public Book? Get(int id)
        {
            return libraryContext.Books
                .Include(book => book.Author)
                .Include(book => book.Genre)
                .SingleOrDefault(book => book.BookId == id);
        }
        public void Delete(Book book)
        {
            libraryContext.Books.Remove(book);
            Save();
        }
        public void Add(Book book)
        {
            libraryContext.Books.Add(book);
            libraryContext.SaveChanges();
        }
        void Save()
        {
            libraryContext.SaveChanges();
        }
    }
}
