using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept1
{
    public static class sample
    {
        public static void NewMethod(this Class1 c1)
        {
            Console.WriteLine("I am extended method.");
        }
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
        public static string[] CommaSeparatedValue(this string str)
        {
            return str.Split(',');
        }
    }
    class ExtensionMethod
    {
        public static void Main9()
        {
            Class1 c1 = new Class1();
            Console.WriteLine(c1.disp());
            string[] sample = "1,2,3".CommaSeparatedValue();
            foreach(var item in sample)
            {
                Console.WriteLine(item);
            }
        }
    }
}
