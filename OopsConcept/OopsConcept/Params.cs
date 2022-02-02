using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConecpt
{
    class NormalParms
    {
        static int Sum(params int[] param1)
        {
            int val = 0;
            foreach (var item in param1)
            {
                val = val + item;
            }
            return val;
        }
        static void Main4(string[] args)
        {

            Console.WriteLine(Sum(11,15,16));
        }
    }
}
