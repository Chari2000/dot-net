using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter any string:");
            string s1 = Console.ReadLine();
            int v = 0,c=0,i,len;
            len = s1.Length;
            for (i = 0; i < len; i++)
            {
                if (s1[i] == 'a' || s1[i] == 'e' || s1[i] == 'i' || s1[i] == 'o' || s1[i] == 'u' || s1[i] == 'A' || s1[i] == 'E' || s1[i] == 'I' || s1[i] == 'O' || s1[i] == 'U')
                {
                    v++;
                }
                else if ((s1[i] >= 'a' && s1[i] <= 'z') ||
                 (s1[i] >= 'A' && s1[i] <= 'Z'))
                {
                    c++;
                }
            }
        Console.Write("\nVowel in the string: {0}\n", v);
        Console.Write("Consonant in the string: {0}\n\n", c);
        }
    }
}
