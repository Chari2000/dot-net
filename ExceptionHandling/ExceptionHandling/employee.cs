using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace ExceptionHandling
{
    internal class employee
    {
        public bool EmpSal(string sal)
        {
            Regex re = new Regex("[0-9]{5}$");
            Match match1 = re.Match(sal);
            if (match1.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EmpID(string id)
        {
            Regex re1 = new Regex("([A_Z]{3})*([0-9]{4})");
            Match match2 = re1.Match(id);
            if(match2.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            string sal= Console.ReadLine();
            Console.WriteLine("Enter employee ID");
            string id = Console.ReadLine();
            employee emp = new employee();
            
            if (emp.EmpID(id) && emp.EmpSal(sal))
            {
                Console.WriteLine("Employee Detailes are:");
                Console.WriteLine("Name:{0}"+name);
                Console.WriteLine("ID:{0}",id);
                Console.WriteLine("salary:{0}",sal);
            }
            else
            {
                Console.WriteLine("You entered wrong input");
            }
        }
    }
}
