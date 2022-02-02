using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class SubString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string with minimum length of 6:");
            string str = Console.ReadLine();
            int l = str.Length;
            for(int i=2;i<5;i++)
            {
                    Console.Write(str[i]);
            }
        }
    }
}
