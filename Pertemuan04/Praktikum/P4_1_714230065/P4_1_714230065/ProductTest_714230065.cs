using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230065
{
    public class ProductTest_714230065
    {
        static void Main(string[] args)
        {
           Book_714230065 product1 = new Book_714230065("Book", "C# Object Oriented Solution", "300");
            DVD_714230065 product2 = new DVD_714230065("Ethernal Sunshine of The Spotless Mind", "145");
           product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
