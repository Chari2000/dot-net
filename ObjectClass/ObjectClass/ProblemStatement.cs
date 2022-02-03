using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Rectangle:Shape
    {
        protected double side1, side2;
    }
    class Circle:Shape
    {
        protected double radius;
    }
    class Shape

    {
        public void Area(double r)
        {
            double a = 3.143 * r * r;
            Console.WriteLine("Area of the circle is " + a);
        }
        public void Area(double s1,double s2)
        {
            double a2 = s1*s2;
            Console.WriteLine("Area of the Rctangle is " + a2);
        }
        public void Perimeter(double r)
        {
            double P =2* 3.143 * r;
            Console.WriteLine("Perimeter of the circle is " + P);
        }
        public void Perimeter(double s1,double s2)
        {
            double P2 = 2*(s1+s2);
            Console.WriteLine("Perimeter of the Rectangle is " + P2);
        }
    }
    class ProblemStatement
    {
        static void Main9(string[] args)
        {
            Circle cir = new Circle();
            Rectangle rect = new Rectangle();
            Console.WriteLine("Enter Radius of the cicle:");
            double radii = Convert.ToDouble(Console.ReadLine());
            cir.Area(radii);
            cir.Perimeter(radii);
            Console.WriteLine("Enter sides of the Rectangle:");
            double s1 = Convert.ToDouble(Console.ReadLine());
            double s2 = Convert.ToDouble(Console.ReadLine());

            rect.Area(s1,s2);
            rect.Perimeter(s1, s2);

        }

    }
}
