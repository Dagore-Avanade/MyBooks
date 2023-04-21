using MyBooks.Data;
using MyBooks.Data.Entities;
using MyBooks.WinForm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyBooks.WinForm.Services
{
    internal class AuthorsService
    {
        readonly LibraryContext libraryContext = new();
        public AuthorViewModel[] AllViewModel()
        {
            return libraryContext.Authors.Select(author => new AuthorViewModel()
            {
                AuthorId = author.AuthorId,
                FirstName = author.FirstName,
                LastName = author.LastName
            }).ToArray();
        }
        public List<Author> All()
        {
            return libraryContext.Authors.ToList();
        }
        public bool Add(Author author)
        {
            var existingAuthor = libraryContext.Authors.FirstOrDefault(a =>
                a.FirstName == author.FirstName &&
                a.LastName == author.LastName
            );
            if (existingAuthor is null)
            {
                libraryContext.Authors.Add(author);
                libraryContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
