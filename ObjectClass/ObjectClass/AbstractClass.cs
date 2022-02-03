using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectClass
{
    abstract class SampleA
    {
        public SampleA()
        {

        }

        abstract public void show();

    }
    class SampleB : SampleA
    {
        public SampleB()
        {

        }
        //overriding
        public override void show()
        {

        }
    }
    class AbstarctClass
    {
        static void Main7(string[] args)
        {
            SampleB b = new SampleB();
        }


    }
}