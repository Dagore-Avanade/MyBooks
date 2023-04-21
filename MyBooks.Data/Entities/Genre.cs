using System;
using System.Collections.Generic;

namespace MyBooks.Data.Entities
{
    public partial class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        public int GenreId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
