using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectClass
{

    class DummyA
    {
        public void show()
        {
            Console.WriteLine("I am coming from A");
        }
    }
    class DummyB : DummyA
    {
        public void show()
        {
            Console.WriteLine("I am coming from B");
        }
    }
    class Overriding
    {

        static void Main8(string[] args)
        {
            DummyB B = new DummyB();
            B.show();//B

            DummyA A = new DummyB();
            A.show();//A  ==>B

            DummyA Obj = new DummyA();
            Obj.show(); //A

            Obj = new DummyB();
            Obj.show();//A  ===>B
        }
    }
}