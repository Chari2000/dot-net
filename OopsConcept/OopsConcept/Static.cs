using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class staticSample
    {
        static staticSample()
        {

        }
        public static string a = "sample";
    }

    class Static
    {
        static void Main3(string[] args)
        {
            staticSample s = new staticSample();
            staticSample.a = "3";
            Console.WriteLine(staticSample.a);
        }
    }
}
