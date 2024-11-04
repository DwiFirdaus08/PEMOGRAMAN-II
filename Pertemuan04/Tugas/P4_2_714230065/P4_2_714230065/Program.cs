using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat item menu satu per satu
            MenuItem item1 = new Food("Nasi Goreng", 12000);
            MenuItem item2 = new Food("Indomie", 2500);
            MenuItem item3 = new Drink("Es Teh", 5000);
            MenuItem item4 = new Drink("Jus Jeruk", 10000);

            // Menampilkan daftar menu 
            Console.WriteLine("Daftar Menu Restoran:");

            if (item1 is Food)
                item1.GetDetails();
            if (item2 is Food)
                item2.GetDetails();
            if (item3 is Drink)
                item3.GetDetails();
            if (item4 is Drink)
                item4.GetDetails();
        }
    }
}
