using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept1
{
    class Problem1
    {
        public const int a = 6;
        public readonly int b;
        public Problem1(int c)
        {
            b = c;
            Console.WriteLine("Value of a={0} and b={1}.", a, b);
        }
    }
    class ConstVsReadonly
    {
        public static void Main7()
        {
            Problem1 p1 = new Problem1(5);
        }
    }
}
