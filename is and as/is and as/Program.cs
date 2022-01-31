using System;

namespace is_and_as
{
    class Program
    {
        static void Main1(string[] args)
        {
            string s = "Demo class";
            object obj = s;
            //as operator
            string s2 = obj as string;
            //type casting
            //boxing and unboxing
            if(s2!=null)
            {
                Console.WriteLine("Successfully casted");
                Console.WriteLine(s2);
            }
            
        }
    }
}
