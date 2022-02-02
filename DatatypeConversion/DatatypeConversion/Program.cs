using System;

namespace DatatypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
           // int? a = null;
            //(int)Nullable = a;
            //object o = null;
            //string s=(o).ToString(); 
            //string s = Convert.ToString(o);
            //int num1 = int.Parse("50");
            int num2;
            bool res= int.TryParse("2222", out num2);
            if(res)
            {
                Console.WriteLine("you entered an integer.");
            }
            else
            {
                Console.WriteLine("you should enter an integer.");
            }
        }
    }
}
