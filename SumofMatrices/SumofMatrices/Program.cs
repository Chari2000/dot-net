using System;

namespace SumofMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] s1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] s2 = new int[2, 2] { { 6, 9 }, { 4, 4 } };
            int[,] s3=new int[2,2];
            Console.WriteLine("First matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(s1[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Second matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(s2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Multiplication of two matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    s3[i, j] = s1[i, j] * s2[i, j];
                    Console.Write(s3[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
