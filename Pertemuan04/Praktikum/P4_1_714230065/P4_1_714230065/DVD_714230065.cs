using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230065
{
    internal class DVD_714230065 : Product_714230065
    {
        protected string duration;

        public DVD_714230065(string title, string duration)
        {
            MyType = "DVD";
            MyTitle = title;
            this.duration = duration;
            Console.WriteLine("ini dari class DVD");
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        //Implementasi metode abstrak
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} minutes duration", MyType, MyTitle, Duration);
        }
    }
}
