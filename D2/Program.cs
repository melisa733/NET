using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task8();
            //Example();
            //Task9();
            //Example2();
            //Task12();
            //Task13();
            //Task14();
            Task15();
            Console.Read();

        }

        public static void Task8()
        {

            Console.WriteLine("Please enter + - * or /:");
            string operation = Console.ReadLine();

            Console.WriteLine("Please enter nr1:");
            int nr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter nr2:");
            int nr2 = int.Parse(Console.ReadLine());

            if (operation == "+")
            {
                Console.WriteLine("nr1 + nr2 = " + (nr1 + nr2));
            }
            else if (operation == "-")
            {
                Console.WriteLine("nr1 - nr2 = " + (nr1 - nr2));
            }
            else if (operation == "*")
            {
                Console.WriteLine("nr1 * nr2 = " + (nr1 * nr2));
            }
            else
            {
                Console.WriteLine("nr1 / nr2 = " + ((decimal)nr1 / nr2));
            }
        }

        static void Example()
        {

            Console.WriteLine("Please enter + - * or /:");
            string operation = Console.ReadLine();

            Console.WriteLine("Please enter nr1:");
            int nr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter nr2:");
            int nr2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine("nr1 + nr2 = " + (nr1 + nr2));
                    break;
                case "-":
                    Console.WriteLine("nr1 - nr2 = " + (nr1 - nr2));
                    break;
                case "*":
                    Console.WriteLine("nr1 * nr2 = " + (nr1 * nr2));
                    break;
                case "/":
                    Console.WriteLine("nr1 / nr2 = " + (nr1 / nr2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

        }

        static void Task9() {
            Console.WriteLine("Please enter country:");
            string country = Console.ReadLine();

            switch (country)
            {
                case "Estonia":
                    Console.WriteLine("This countries capital city is Tallin");
                    break;
                case "Finland":
                    Console.WriteLine("This countries capital city is Helsinki");
                    break;
                case "Ukraine":
                    Console.WriteLine("This countries capital city is Kyiv");
                    break;
                case "Sweden":
                    Console.WriteLine("This countries capital city is Stockholm");
                    break;
                case "Russian":
                    Console.WriteLine("This countries capital city is Moscwo");
                    break;
                case "estonia":
                    Console.WriteLine("This countries capital city is Tallin");
                    break;
                case "finland":
                    Console.WriteLine("This countries capital city is Helsinki");
                    break;
                case "ukraine":
                    Console.WriteLine("This countries capital city is Kyiv");
                    break;
                case "sweden":
                    Console.WriteLine("This countries capital city is Stockholm");
                    break;
                case "russian":
                    Console.WriteLine("This countries capital city is Moscwo");
                    break;
                default:
                    Console.WriteLine("We don't have info about this country. :)");
                    break;
            }
        }

        static void Example2() {
            for (int i = 1; i < 11; i++) 
            {
                Console.WriteLine("Number is: " + i);
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Number is: " + i);
            }
        }

        static void Task12()
        {
            Console.WriteLine("Please enter your birth year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int yearNow = now.Year;

            Console.WriteLine("");
            Console.WriteLine("_______________________________");
            for (int i = year; i <= yearNow; i++) {
                Console.WriteLine(i);
            }
        }

        static void Task13()
        {
            Console.WriteLine("Please enter N: ");
            int N = int.Parse(Console.ReadLine());
            int result = 0;
            
            Console.WriteLine("");
            Console.WriteLine("_______________________________");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
                result += i;
            }

            Console.WriteLine("Sum of numbers is" + result);
        }

        static void Task14()
        {
            Console.WriteLine("Please enter N: ");
            int N = int.Parse(Console.ReadLine());
            int result = 0;
            int currentNr;
            int check = 0;
            int smallestNr = int.MinValue;
            int largestNr = int.MaxValue;

            Console.WriteLine("");
            Console.WriteLine("_______________________________");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Please enter nr" + i + ": ");
                currentNr = int.Parse(Console.ReadLine());
                result += currentNr;

                if (check == 0) {
                    smallestNr = currentNr;
                    largestNr = currentNr;
                    check++;
                }

                if (currentNr < smallestNr) {
                    smallestNr = currentNr;
                }

                if (currentNr > largestNr)
                {
                    largestNr = currentNr;
                }

;            }

            Console.WriteLine("Sum of numbers is " + result);
            Console.WriteLine("Average of numbers is " + ((decimal)result/N));
            Console.WriteLine("Smallest nr of numbers is " + smallestNr);
            Console.WriteLine("Largest nr of numbers is " + largestNr);
        }

        static void Task15() {
            Console.WriteLine("Please enter N: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("_______________________________");

            for (int i = 1; i <= N; i++) 
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
