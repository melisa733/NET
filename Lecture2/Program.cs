using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello!");
            Console.WriteLine("Hello again!");

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
            //Task6();
            //Task7();
            Console.Read();
        }

        static void Task1()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + name + "!");
        }

        static void Task2()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + name + " " + surname + "!");
        }

        static void Task3()
        {
            Console.WriteLine("Please enter number 1: ");
            int nr1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter number 2: ");
            string number2 = Console.ReadLine();
            int nr2 = Int32.Parse(number2);

            int result = nr1 + nr2;

            Console.WriteLine("Sum of the both numbers : " + result);
        }

        static void Task4()
        {
            Console.WriteLine("Please enter number 1: ");
            int nr1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter number 2: ");
            string number2 = Console.ReadLine();
            int nr2 = Int32.Parse(number2);

            int sum = nr1 + nr2;
            int difference = nr1 - nr2;
            int multiplication = nr1 * nr2;


            Console.WriteLine("Sum of the both numbers : " + sum);
            Console.WriteLine("Difference of the both numbers : " + difference);
            Console.WriteLine("Multiplication of the both numbers : " + multiplication);
            Console.WriteLine("Division of the both numbers : " + ((decimal)nr1 / nr2));//Lai būu ar komatu, vienam skaitlim ir jābūt decimalam
        }

        static void Task5() 
        {
            Console.WriteLine("Please enter  degrees in Celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());

            decimal fahrenheit = celsius * (decimal)1.8 + 32;
            decimal kelvin = celsius + (decimal)273.15;

            Console.WriteLine("Fahrenheit is = " + fahrenheit);
            Console.WriteLine("Kelvin is = " + kelvin);
        }

        static void Task6()
        {
            Console.WriteLine("Please enter yout age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Tu esi pilngadīgs!");
            }
            else
            {
                Console.WriteLine("Tu neesi pilngadīgs!");
            }
        }

        static void Task7() {
            Console.WriteLine("Please enter number 1: ");
            int nr1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter number 2: ");
            string number2 = Console.ReadLine();
            int nr2 = Int32.Parse(number2);

            if (nr1 == nr2)
            {
                Console.WriteLine("The numbers are equal");
            }
            else if (nr1 < nr2)
            {
                Console.WriteLine("The nr1 < nr2");
            }
            else 
            {
                Console.WriteLine("...");
            }
        }
    }
}
