using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class String
    {
        static void Main4(string[] args)
        {

            string s = "some value";
            s = "chari";
            //replace
            //split
            //startswith
            //substring
            //tolower
            //toupper
            s = s.Replace("chari", "1,2,3");
            var valuearray = s.Split(',');
            Console.WriteLine("Values after spliting");
            for (int i = 0; i < valuearray.Length; i++)
            {
                Console.WriteLine(valuearray[i]);
            }
            Console.WriteLine(s);
            StringBuilder sb = new StringBuilder("Hello world");
            sb.Append("Hello");
            sb.Replace("Hello", "Hello 1");
            sb.Insert(0, "New value");
            Console.WriteLine(sb);
        }
    }
}
