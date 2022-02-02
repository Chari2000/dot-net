using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class CallingConAndDes
    {
        CallingConAndDes()
        {
            Console.WriteLine("Constructor is called.");
        }
        ~CallingConAndDes()
        {
            Console.WriteLine("Destructor is called");
        }
        static void Main4(string[] args)
        {
            CallingConAndDes s = new CallingConAndDes();
            Console.WriteLine();
        }
    }
}
