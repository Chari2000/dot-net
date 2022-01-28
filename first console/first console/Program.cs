using System;

namespace first_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else
            {
                Console.WriteLine("a is not equal to b");
                if(a>b)
                {
                    Console.WriteLine("a is greater than b");
                }
                else
                {
                    Console.WriteLine("a is less than b");
                }
                a = a+b;
                b = a-b;
                a = a-b;
                Console.WriteLine("After swapping:"+a+","+b);
            }*/
            Console.WriteLine("Enter person's age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age>60)
            {
                Console.WriteLine("Person is senior citizen.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Person can vote.");
            }
            else
            {
                Console.WriteLine("Person cannot vote.");
            }

        }
    }
}
