﻿using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main1(string[] args)
        {
            //write in a file
            /*
            StreamWriter sw = new StreamWriter("D://File-write//Sample.txt");
            //to write a line in buffer
            sw.WriteLine("writing value in a file");
            //write in output steam
            sw.Flush();
            sw.Close();
            Console.WriteLine("Hello World!");
            */

            StreamReader sr = new StreamReader("D://File-write//Sample.txt");

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