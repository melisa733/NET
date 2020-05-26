using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10.0, 12.0);
            Square s1 = new Square(20.0);
            Triangle t1 = new Triangle(12.0, 15.0, 16.0);

            printOutAreaAndPerimeter(r1);
            printOutAreaAndPerimeter(s1);
            printOutAreaAndPerimeter(t1);

            Console.Read();
        }

        public static void printOutAreaAndPerimeter(Figure f) 
        {
            Console.WriteLine("The area of this shape is {0}", f.Area());
            Console.WriteLine("The perimeter of this shape is {0}", f.Perimeter());
        }
    }
}
