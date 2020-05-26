using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1() 
        {
            Console.WriteLine("Enter degrees: ");
            decimal degrees = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter current unit (C, F, K): ");
            string currentUnit = Console.ReadLine();

            Console.WriteLine("Enter unit to convert to (C, F, K): ");
            string converToUnit = Console.ReadLine();

            if (currentUnit == "C") 
            {
                if (converToUnit == "K")
                {
                    Console.WriteLine("C to K : " + (degrees + (decimal)273.15));
                }
                else if (converToUnit == "F")
                {
                    Console.WriteLine("C to F: " + (degrees * (decimal)1.8 + 32));
                }
                else 
                {
                    Console.WriteLine("C to C : " + degrees);
                }
            }
            else if (currentUnit == "K")
            {
                if (converToUnit == "C")
                {
                    Console.WriteLine("K to C : " + (degrees - (decimal)273.15));
                }
                else if (converToUnit == "F")
                {
                    Console.WriteLine("K to F: " + ((decimal)0.56*(degrees-(decimal)32.0) + (decimal)273.15));
                }
                else
                {
                    Console.WriteLine("K to K : " + degrees);
                }
            }
            else if (currentUnit == "F")
            {
                if (converToUnit == "C")
                {
                    Console.WriteLine("F to C : " + ((degrees - (decimal)32.0)/(decimal)1.8));
                }
                else if (converToUnit == "K")
                {
                    Console.WriteLine("F to K: " + ((decimal)1.8 * (degrees - (decimal)273.15) + (decimal)32.0));
                }
                else
                {
                    Console.WriteLine("F to F : " + degrees);
                }
            }
        }
    }
}
