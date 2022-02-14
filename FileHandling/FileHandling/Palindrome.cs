using System;
using System.IO;

namespace FileHandling
{
    class Palindrome
    {
        public static bool checkPalindrome(string mainString)
        {
            string firstHalf = mainString.Substring(0, mainString.Length / 2);
            char[] arr = mainString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string secondHalf = temp.Substring(0, temp.Length / 2);

            return firstHalf.Equals(secondHalf);
        }
        static void Main(string[] args)
        {
            /*StreamWriter sw = new StreamWriter("D://File-write//palindrome.txt");
            Console.WriteLine("Enter anything to file");
            sw.WriteLine(Console.ReadLine());
            sw.Flush();
            sw.Close();
            */
            
            // Console.WriteLine("Hello World!");


            StreamReader sr = new StreamReader("D://File-write//Palindrome.txt");

            //this is used to specify from where to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();

            while (str != null)
            {
                Console.WriteLine(str);
                break;
            }
            if (checkPalindrome(str))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
            sr.Close();

        }
    }
}