using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P4_2_714230065
{
    internal class Drink : MenuItem
    {
        public Drink(string name, double price) : base(name, price) { }

        public override void GetDetails()
        {
            Console.WriteLine($"Minuman: {Name}, Harga: {Price} IDR");
        }
    }
}
