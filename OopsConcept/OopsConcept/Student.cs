using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class StdInfo
    {
        int StdID,tel,hindi,eng,maths,science;
        string StdName;
        public void GetStdInfo()
        {
            Console.WriteLine("Please enter student Id");
            StdID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            StdName = Console.ReadLine();
            Console.WriteLine("Please enter telugu marks");
            tel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter hindi marks");
            hindi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter english marks");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter maths marks");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter science marks");
            science = Convert.ToInt32(Console.ReadLine());

        }

        public void ShowStdData()
        {
            int tot = tel + hindi + eng + maths + science;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Student Data :");
            Console.WriteLine("Student Id : {0}", StdID);
            Console.WriteLine("Student Name : {0}", StdName);
            Console.WriteLine("Marks in Telugu: {0}", tel);
            Console.WriteLine("Marks in Hindi : {0}", hindi);
            Console.WriteLine("Marks in English: {0}", eng);
            Console.WriteLine("Marks in Maths: {0}", maths);
            Console.WriteLine("Marks in Science: {0}", science);
            Console.WriteLine("Total Marks: {0}", tot);

        }
    }
    class Student
    {
        static void Main(string[] args)
        {
            StdInfo[] s = new StdInfo[2];
            for (int i = 0; i < 2; i++)
            {
                StdInfo s1 = new StdInfo();
                s1.GetStdInfo();
                s[i] = s1;
            }
            for (int i = 0; i < 2; i++)
            {
                s[i].ShowStdData();
            }
        }
    }
}
