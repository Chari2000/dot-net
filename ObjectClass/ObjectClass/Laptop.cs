using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Laptop
    {
        static void Main9(string[] args)
        {
            Laptop1 lp = new Laptop1();

            lp.ShowDetails(Laptop1.Lenove, Laptop1.Price1000, Laptop1.i3, Laptop1.Ram2GB, Laptop1.HD500GB);
            Console.WriteLine("\n\n*************************************\n");

            lp.ShowDetails(Laptop1.Dell, Laptop1.Price1500, Laptop1.i5, Laptop1.Ram4GB, Laptop1.HD1TB);
            Console.WriteLine("\n\n*************************************\n");

            lp.ShowDetails(Laptop1.Sony, Laptop1.Price2000, Laptop1.i9, Laptop1.Ram8GB, Laptop1.HD1TB);
            Console.WriteLine("\n\n*************************************\n");

            Console.ReadKey();
        }
    }
    class Laptop1 : LaptopBase
    {
        public void ShowDetails(string name, string price, string processor, string ram, string hdd)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Processor : " + processor);
            Console.WriteLine("Ram : " + ram);
            Console.WriteLine("HDD : " + hdd);
        }
    }

    class LaptopBase
    {
        public const string i3 = "i3";
        public const string i5 = "i5";
        public const string i7 = "i7";
        public const string i9 = "i9";

        public const string Ram2GB = "2GB";
        public const string Ram4GB = "4GB";
        public const string Ram8GB = "8GB";

        public const string HD500GB = "500GB";
        public const string HD1TB = "1TB";

        public const string Price1000 = "$1000";
        public const string Price1500 = "$1500";
        public const string Price2000 = "$2000";

        public const string Lenove = "Lenovo";
        public const string Sony = "Sony";
        public const string Dell = "Dell";
    }
}