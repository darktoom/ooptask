using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooptask
{
    internal class LibraryItem
    {
     int ItemId { get; set; }
        bool  IsAvailable { get; set; } = true;
    




        public void checkout() { 
        if (IsAvailable=false)
                Console.WriteLine($"not available"); 
        
                
        
        }
        public void ReturnItem()
        {
            if (IsAvailable)

            Console.WriteLine("Item is available");
        }
        public override string ToString()
        {
            return $"{ItemId},{IsAvailable}";
        }


    }
}
