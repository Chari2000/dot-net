using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Person1
    {
        public string Name;
        public Person1(string name)
        {
            Name= name;
        }
        public void Show()
        {
                Console.WriteLine(Name);
        }
        ~Person1()
        {

        }
    }
    class Inheritance
    {
        static void Main6(string[] args)
        {
            Person1 p1 = new Person1("ramesh");
            p1.Show();
            Person1 p2 = new Person1("suresh");
            p2.Show();
            Person1 p3 = new Person1("kamesh");
            p3.Show();
        }

    }
}
