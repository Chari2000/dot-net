using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check leap year or not:");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%400==0 || (year%4==0 && year%100!=0))
            {
                Console.WriteLine("Given year is leap year");
            }
            else
            {
                Console.WriteLine("Given year is non-leap year");
            }
        }
    }
}
