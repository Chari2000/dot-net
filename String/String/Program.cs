using System;

namespace String
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter any string:");
            string str = Console.ReadLine();
            int l = str.Length;
            int i = 0, alp = 0,num=0,spl=0 ;
            while(i<l)
            {
                if((str[i]>='a' && str[i]<='z')||(str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    num++;
                }
                else
                {
                    spl++;
                }
                i++;
            }
            Console.WriteLine("You entered " + alp + " alphabets," + num + " numbers and " + spl + " special characters.");
        }
    }
}
