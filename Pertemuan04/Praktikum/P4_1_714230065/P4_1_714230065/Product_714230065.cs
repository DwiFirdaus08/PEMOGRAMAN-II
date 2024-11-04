using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230065
{
    internal abstract class Product_714230065
    {
        private string myType;
        private string myTitle;

        public Product_714230065()
        {

        }

        //contructor
        public Product_714230065(string type, string title)
        {
            myType = type;
            myTitle = title;

        }

        // Proreti untuk MyType
        public string MyType
        {
            get {  return myType; }
            set {  myType = value; }
        }

        // Proreti untuk MyTitle
        public string MyTitle
        {
            get { return myTitle ; }
            set { myTitle = value; }
        }

        //Metode abstrak untuk menampilkan informasi produk
        public abstract void DisplayInfo();
    }
}
