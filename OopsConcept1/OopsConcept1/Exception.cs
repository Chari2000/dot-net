using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept1
{
    class Exception
    {
        public static void Main()
        {
            try
            {
                int a = 0;
                var b = 10 / a;
                int[] ar = new int[2];
                Console.WriteLine(ar[3]);
            }
            catch(DivideByZeroException e)
            { 
                Console.WriteLine("Devide by zero"+e.Message);
            }
            catch (IndexOutOfRangeException e1)
            {
                Console.WriteLine("Index out of bound" + e1.Message);
            }
        }
            
    }
}
