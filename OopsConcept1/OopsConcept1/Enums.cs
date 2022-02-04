using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept1
{
    enum WeekDays
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun
    }
    class Perimeter
    {
        public enum Shapes
        {
            circle,square
        }
        public void PrintPerimeter(int val,Shapes shape)
        {
            if(shape==0)
            {
                Console.WriteLine("Circumference of the circle:" + 2 * 3.14 * val);
            }
            else
            {
                Console.WriteLine("Circumference of the Square:" + 4* val);

            }
        }
    }
    class Enums
    {
        static void Main3()
        {
            Console.WriteLine("Value of Monday is:" + WeekDays.Mon);
            Console.WriteLine("Value of Monday is:" + (int)WeekDays.Mon);
            Perimeter p = new Perimeter();
            p.PrintPerimeter(3, Perimeter.Shapes.circle);
            p.PrintPerimeter(5, Perimeter.Shapes.square);

        }
    }
}
