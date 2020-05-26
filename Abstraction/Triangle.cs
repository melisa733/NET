using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Triangle : Figure
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double side1, double side2, double side3) 
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Area()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p*(p-side1) * (p - side2) * (p - side3));
            
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
