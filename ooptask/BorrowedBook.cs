using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooptask
{
    internal class BorrowedBook:LibraryItem
    {
        Book bookDetials {  get; set; }
        string? BorrowerName { get; set; }
     public   DateTime? BorrowerDate { get; set; }
        public BorrowedBook(Book bookDetials,string BorrowerName,DateTime BorrowerDate) { 
            this.bookDetials = bookDetials;
            this.BorrowerName = BorrowerName;
            this.BorrowerDate = BorrowerDate;
           
        
        }

        public override string ToString() {
            return $"{bookDetials},{BorrowerName},{DateTime.Now}";
        }
    }
}
