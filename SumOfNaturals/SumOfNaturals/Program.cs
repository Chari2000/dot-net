using System;

namespace SumOfNaturals
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter how many natural numbers you want to add:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i < 10) 
                { 
                Console.Write(i + "+");
                }
                else 
                {
                    Console.Write(i);
                }
                sum += i;
            }
            Console.WriteLine("="+sum);
        }
    }
}
