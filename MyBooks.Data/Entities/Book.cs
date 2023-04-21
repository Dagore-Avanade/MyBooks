using System;
using System.Collections.Generic;

namespace MyBooks.Data.Entities
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime PublicationDate { get; set; }
        public int NumberOfPages { get; set; }
        public string? Description { get; set; }
        public int? AuthorId { get; set; }
        public int? GenreId { get; set; }

        public virtual Author? Author { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}
