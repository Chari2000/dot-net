using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNaturals
{
    class pattern
    {
        static void Main(string[] args)
        {
            int val = 4;
            int i, j, k;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int range = 0;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    // Console.Write("");  
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(arr[range]+" ");
                    range++;
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
