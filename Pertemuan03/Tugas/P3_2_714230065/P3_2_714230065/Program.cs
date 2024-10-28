using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulang;
            do
            {
                Console.Clear();

                Console.WriteLine("=== HITUNG PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas\n2. Hitung Keliling\n3. Keluar");
                Console.WriteLine("Pilih menu (1-3)");

                String menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.WriteLine("Masukkan panjang: ");
                    int input = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Masukkan lebar: ");
                    int input2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Luas Persegi Panjang: " + (input * input2));
                }
                else if (menu == "2")
                {
                    Console.WriteLine("Masukkan panjang: ");
                    int input = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Masukkan lebar: ");
                    int input2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Keliling Persegi Panjang: " + 2 * (input + input2));
                }
                else if (menu == "3")
                {
                    Console.WriteLine("Program selesai.");
                    Console.WriteLine("Terima kasih!");
                    break;
                }
                else
                {
                    Console.WriteLine("Menu tidak tersedia. Silahkan pilih menu yang valid.");
                }
                Console.Write("\nIngin mengulang kembali (Y/T)? ");

                ulang = Console.ReadLine().ToUpper();
                if (ulang == "T")
                {
                    Console.WriteLine("Terima Kasih!");
                }
            } while (ulang == "Y");

        }
    }
}
