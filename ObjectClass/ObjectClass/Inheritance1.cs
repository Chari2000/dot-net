using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Person
    {
        public int x;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age)
        {
            x = age; ;
            
        }
    }
    class  Student: Person 
    {
        public void Study()
        {
            Console.WriteLine("I'm studying on the screen");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + x + " year old on the screen");
        }
    }
    class Professor : Person 
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining on the screen");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + x + " year old on the screen");
        }
    }
    class Inheritance1
    {
        static void Main5(string[] args)
        {
            Person p1 = new Person();
            p1.Greet();
            Student s1 = new Student();
            s1.Greet();
            s1.SetAge(18);
            s1.ShowAge();
            Professor p2 = new Professor();
            p2.Greet();
            p2.SetAge(44);
            p2.ShowAge();
            p2.Explain();

        }

    }
}
