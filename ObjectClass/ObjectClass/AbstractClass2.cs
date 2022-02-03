using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    abstract class Animal
    {
        public string Name;
        public void SetName(string name)
        {
            Name = name;
        }
        public void GetName()
        {
            Console.WriteLine(Name);
        }
        abstract public void Eat();
    }
    class Dog : Animal 
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
    class AbstractClass2
    {
        static void Main8(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName("Tommy");
            dog.GetName();
            dog.Eat();
        }

    }
}
