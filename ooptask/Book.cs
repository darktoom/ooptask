using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooptask
{
    internal struct Book
    {
        string Title { get; set; }
        string Author { get; set; }
        string ISBN { get; set; }

      public  Book(string Title, string Author,string ISBN)
        {
            this.Title = Title; this.Author = Author; this.ISBN = ISBN;
        }

    }
}
