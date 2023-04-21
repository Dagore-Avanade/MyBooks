using System;
using System.Collections.Generic;

namespace MyBooks.Data.Entities
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
