using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept1
{
    public struct Student
    {
        public string Name;
        public string Class;
        public string Gender;
    }
    class Structure1
    {
        Student std = new Student();
        public void Getdata()
        {
            Console.WriteLine("Enter student name:");
            std.Name = Console.ReadLine();
            Console.WriteLine("Enter student class:");
            std.Class = Console.ReadLine();
            Console.WriteLine("Enter student Gender:");
            std.Gender = Console.ReadLine();
        }
        public void Showdata()
        {
            Console.WriteLine("Student name is:" + std.Name);
            Console.WriteLine("Student class is:" + std.Class);
            Console.WriteLine("Student Gender is:" + std.Gender);
        }
    }
    class Structure
    {
        
        static void Main2()
        {
            Structure1 s1 = new Structure1();
            s1.Getdata();
            s1.Showdata();
            
        }

    }
}
