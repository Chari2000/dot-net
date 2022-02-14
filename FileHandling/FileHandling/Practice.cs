using System;
using System.IO;

namespace FileHandling
{
    class Practice
    {
        static void Main2(string[] args)
        {            
            /*StreamWriter sw = new StreamWriter("D://File-write//class.txt");
            sw.WriteLine("hii friends");
            sw.Flush();
            sw.Close();
            */
           // Console.WriteLine("Hello World!");
     

           StreamReader sr = new StreamReader("D://File-write//class.txt");

            //this is used to specify from where to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();

            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
           
        }
    }
}