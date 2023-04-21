using MyBooks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyBooks.WinForm.ViewModels
{
    internal class GenreViewModel : Genre
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
