using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept1
{
    public partial class Customer
    {
        private int amount;
        public int Amount { get; set; }
        public void withdraw(int amount)
        {
            Console.WriteLine("Amount to be withdraw" + amount);
        }
    }
}
