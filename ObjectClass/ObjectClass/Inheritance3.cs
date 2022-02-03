using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectClass
{
    interface IAnimal
    {
        void animalsound();
        // void run();
    }

    class Pig : IAnimal
    {
        public void animalsound()
        {
            Console.WriteLine("The pig says wee wee");
        }
    }
    class SampleInterface
    {

        public static void Main()
        {
            Pig pig = new Pig();
            pig.animalsound();
        }

    }
}
