using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public interface IA
    {
        void method1();
    }
    public interface IB : IA 
    {
        void method2();
    }
    class IC : IB 
    {
        public void method2()
        {
            Console.WriteLine("Implemented method 2");
        }
        public void method1()
        {
            Console.WriteLine("Implemented method 1");
        }
    }
    class Interface1
    {
        static void Main12(string[] args)

        {
            IC ic = new IC();
            ic.method1();
            ic.method2();
        }
    }
}
