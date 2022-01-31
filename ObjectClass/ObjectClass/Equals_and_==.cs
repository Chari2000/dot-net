using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Equals_and___
    {
            static void Main(string[] args)
            {
                string name = "chari";
                string Myname = name;

                var doubleeql = (name == Myname);//true
                var eql = name.Equals(Myname);//true
                Console.WriteLine(doubleeql);
                Console.WriteLine(eql);
                Console.WriteLine("-------------------------------");
                object nameObj = "chari";
                char[] values = { 'c', 'h', 'a', 'r', 'i' };
                object myName = new string(values);
                var doubleeql2 = (nameObj == myName);//false
                var eql2 = nameObj.Equals(myName);//true
                Console.WriteLine(doubleeql2);
                Console.WriteLine(eql2);
            }
        }
    }

