using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_and_as
{
    class Class1
    {
        static void Main2(string[] args)
        {

            int index;
            Console.WriteLine("Previous value of index "+index.ToString());
            string result = GetNameValueout(out index);
            int refIndex = 1;
            GetNameValueref(ref refIndex);
            Console.WriteLine("Current value of index " + index.ToString());

        }

        public static string GetNameValueref(ref int id)
        {
            //string returnText = "DummyName" + id.ToString();
            //id += 1;

            return id.ToString();

        }
        public static string GetNameValueout(out int id)
        {
            id = 1;
            string returnText = "DummyName" + id.ToString();
            id += 1;
           // id = 1;
            return id.ToString();
        }
    }
}
