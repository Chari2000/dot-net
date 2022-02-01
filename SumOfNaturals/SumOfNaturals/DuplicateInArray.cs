using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNaturals
{
    class DuplicateInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 3, 4,1, 5,5};
            int l = arr.Length;
            int c=0;
            for (int i = 0; i < l; i++)
            {
                   for(int j=0;j<l;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        c++;
                    }
                }
                Console.WriteLine(arr[i]+" is repeated " + c + " times");
                c = 0;
            }

        }
        




    }
}
