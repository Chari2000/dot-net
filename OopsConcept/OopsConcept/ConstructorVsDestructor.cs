using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Sample
    {
        int a, b;
        public Sample()
        {

        }
        ~Sample()
        {

        }
        public Sample(int _a,int _b)
        {
            a = _a;
            b = _b;
        }
    }
    class ConstructorVsDestructor
    {
        static void Main3(string[] args)
        {
            Sample obj = new Sample();
            Console.WriteLine();
        }
    }
}
