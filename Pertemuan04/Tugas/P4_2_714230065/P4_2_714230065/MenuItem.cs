using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P4_2_714230065
{
    abstract class MenuItem
    {
        protected string name;
        protected double price;

        // Constructor
        public MenuItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public abstract void GetDetails();

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}

