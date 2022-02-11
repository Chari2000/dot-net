using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExceptionHandling
{
    internal class RegexHandling
    {
        static void Main4(string[] args)
        {
            //this will return any pattern line ab,aab,aaab;
            //Regex re = new Regex("a*b");
            //this will return pattern like b,ab
            //Regex re = new Regex("a?b");
            Regex re = new Regex("[0-9]{4}$");

            Match match = re.Match("ba12456");
            if (match.Success)
            {
                Console.WriteLine("Mached the value " + match.Value);
            }
            else
            {
                Console.WriteLine("Enter a valid string");

            }
        }
    }
}