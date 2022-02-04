using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept1
{
    class Student1
    {
        private int rn = 5;
        private string name;
        public int RollNumber
        {
            get
            {
                return rn;
            }
            set
            {
                rn = value;
            }
        }
        public string Name
        {
            set;get;
        }

    }
    class Property
    {
        static void Main4()
        {
            Student1 std = new Student1();
            Console.WriteLine(std.RollNumber);        }

    }
}
