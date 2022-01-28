using System;

namespace _2DatatypesandArray
{
    class Program
    {
        public static void sum(int a,int b)
        {
            Console.WriteLine("a+b=" + (a + b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("a-b=" + (a - b));
        }
        public static void multiplication(int a, int b)
        {
            Console.WriteLine("a*b=" + (a * b));
        }

        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter any two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            sum(a, b);
            sub(a, b);
            multiplication(a, b);
            int[] array = { 22, 42, 88, 21 };
            Console.WriteLine("Array elements are:");
            for (i=0;i<4;i++)
            {
                Console.Write(array[i]+" ");
            }
            //boxing
            object obj;
            obj = (object)a;
            Console.WriteLine("\nboxing:"+obj);
            //unboxing
            a = (int)obj;
            Console.WriteLine("unboxing:"+a);
        }
    }
}
