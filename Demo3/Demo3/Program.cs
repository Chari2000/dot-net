using System;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i=0;i<4;i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
