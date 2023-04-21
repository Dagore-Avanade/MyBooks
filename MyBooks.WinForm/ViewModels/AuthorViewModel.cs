using MyBooks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooks.WinForm.ViewModels
{
    internal class AuthorViewModel : Author
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
