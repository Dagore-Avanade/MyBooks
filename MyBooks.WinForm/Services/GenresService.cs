using MyBooks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBooks.Data.Entities;
using MyBooks.WinForm.ViewModels;

namespace MyBooks.WinForm.Services
{
    internal class GenresService
    {
        readonly LibraryContext libraryContext = new();
        public GenreViewModel[] AllViewModel()
        {
            return libraryContext.Genres.Select(genre => new GenreViewModel()
            {
                GenreId = genre.GenreId,
                Name = genre.Name
            }).ToArray();
        }
        public bool Add(Genre genre)
        {
            var existingGenre = libraryContext.Genres.FirstOrDefault(g => g.Name == genre.Name);
            if (existingGenre is null)
            {
                libraryContext.Add(genre);
                Save();
                return true;
            }

            return false;
        }
        private void Save()
        {
            libraryContext.SaveChanges();
        }
    }
}
