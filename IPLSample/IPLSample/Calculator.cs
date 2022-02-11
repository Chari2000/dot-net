using System;
using System.Collections.Generic;
using System.Text;

namespace IPLSample
{
    public delegate void CalDelegate(int a, int b,char oper);
    internal class Calculator
    {
        public void Calcul (int a, int b,char oper)
        {
            switch(oper)
            {
                case '+':Console.WriteLine("Addition:" + (a + b));
                    break;
                case '-':
                    Console.WriteLine("Substraction:" + (a - b));
                    break;
                case '*':
                    Console.WriteLine("Multiplication:" + (a * b));
                    break;
                case '/':
                    Console.WriteLine("Division:" + (a / b));
                    break;
            }
        }
        static void Main5(string[] args)
        {
            Calculator obj = new Calculator();

            CalDelegate ad = new CalDelegate(obj.Calcul);
            Console.WriteLine("Enter two integers:");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one operator:");
            char oper = Convert.ToChar(Console.ReadLine());
            ad(a, b, oper);
        }
    }
}
