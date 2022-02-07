using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class IntInString : Exception
    {
        public IntInString(string message) : base(message)
        {

        }
    }
    class ExceptionHandling3
    {
        string Character = Console.ReadLine();
        string Special = "0123456789";
        int c = 0;
        public void TestChar()
        {
            for (int i = 0; i < Character.Length; i++)
            {
                for (int j = 0; j < Special.Length; j++)
                {
                    if (Character[i] == Special[j])
                    {
                        c = 1;
                    }
                }
            }
            if (c == 1)
            {
                throw (new IntInString("Integer found"));
            }
            else
            {
                Console.WriteLine("No integers are there");
            }

        }
        static void Main3(string[] args)
        {
            ExceptionHandling3 Exp = new ExceptionHandling3();
            try
            {
                Exp.TestChar();
            }
            catch (IntInString ex)
            {
                Console.WriteLine("Custom execption is {0}", ex.Message);
            }
        }
    }
}
