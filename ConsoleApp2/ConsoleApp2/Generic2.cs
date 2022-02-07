using System;

namespace ConsoleApp2
{
    internal class Generic2
    {

        // we use < > to specify the parameter type
        //Generic class

        public class sample<T>
        {
            //field
            private T data;

            //property
            public T value
            {
                //accessors
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }

        public class Employee
        {
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public int EmpAge { get; set; }
            public double EmpSal { get; set; }
        }
        static void Main(string[] args)
        {

            sample<string> name = new sample<string>();
            name.value = "Chari";

            sample<float> version = new sample<float>();
            version.value = 5.0F;
            //display Name
            Console.WriteLine(name.value);
            //display version
            Console.WriteLine(version.value);

            //Object Initialzier
            Employee std = new Employee()
            {
                EmpID = 1,
                EmpName = "Chari",
                EmpAge = 27,
                EmpSal = 200000
            };
            Console.WriteLine("Student Information");
            Console.WriteLine(std.EmpID);
            Console.WriteLine(std.EmpName);
            Console.WriteLine(std.EmpAge);
            Console.WriteLine(std.EmpSal);
        }
    }
}