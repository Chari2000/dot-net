using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Parameters
    {
        static void Main(string[] args)
        {
            sample(10);
            sample(10, 20);
            sample(10, 20, 30);

            NamedSample(z: 10, x: 5, y: 11);
        }
        public static void sample(int x,int y=100,int z=500)
        {
            Console.WriteLine("{0},{1},{2}", x, y, z);
        }
        public static void NamedSample(int x,int y,int z)
        {
            Console.WriteLine("{0},{1},{2}", x, y, z);
        }
    }
}
