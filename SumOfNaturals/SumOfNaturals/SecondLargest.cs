using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNaturals
{
    class SecondLargest
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 44, 6, 79, 11, 22, 333, 2 };
            int l = a.Length;
            for(int i=0;i<l;i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    if (a[i] < a[j])
                    {
                        a[i] = a[i] + a[j];
                        a[j] = a[i] - a[j];
                        a[i] = a[i] - a[j];
                    }
                }
            }
            Console.WriteLine("Second largest element in the given array is:" + a[1]);
        }
    }
}
