using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            Task13();

            Console.Read();
        }

        static void Task1()
        {
            Console.WriteLine("Enter first word: ");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter second word: ");
            string word2 = Console.ReadLine();

            Console.WriteLine("Enter third word: ");
            string word3 = Console.ReadLine();

            Console.WriteLine(word1 + " " + word2 + " " + word3 + ".");
        }

        static void Task2()
        {
            Console.WriteLine("Enter your age ");
            int age = int.Parse(Console.ReadLine());

            if (age > 50)
            {
                Console.WriteLine("You are over 50 years.");
            }
            else
            {
                Console.WriteLine("You are not over 50 years.");
            }
        }

        static void Task3()
        {
            Console.WriteLine("Enter your firstNr: ");
            int nr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your secondNr: ");
            int nr2 = int.Parse(Console.ReadLine());

            if (nr1 == nr2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }
        }
        static void Task4()
        {
            decimal nr;
            decimal sum = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter your " + i + ". number: ");
                nr = decimal.Parse(Console.ReadLine());
                sum += nr;
            }

            Console.WriteLine("The avrage of the numbers is " + (sum / 3));
        }

        static void Task5()
        {
            Console.WriteLine("Enter your nr: ");
            decimal nr = decimal.Parse(Console.ReadLine());

            if ((nr < -50) || (nr > 50))
            {
                Console.WriteLine("The number isn't between -50 and 50 inclusive.");
            }
            else
            {
                Console.WriteLine("The number is between -50 and 50 inclusive.");
            }

            //short-hand if-else
            Console.WriteLine((nr < -50) || (nr > 50) ?
                "The number isn't between -50 and 50 inclusive."
                : "The number is between -50 and 50 inclusive.");
        }

        static void Task6()
        {
            Console.WriteLine("Enter your nr: ");
            int nr = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            for (int i = nr; i <= (nr * 2); i++) 
            {
                Console.WriteLine(i);
            }
        }

        static void Task7()
        {
            Console.WriteLine("Enter your number: ");
            int nr = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            for (int i = 1; i <= nr; i++) 
            {
                if ((i != 5) && (i != 10)) 
                {
                    Console.WriteLine(i);
                }
            }

            // continue
            for (int i = 1; i <= nr; i++)
            {
                if ((i == 5) && (i == 10))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        static void Task8() 
        {
            decimal smallest = decimal.MinValue;
            decimal largest = decimal.MaxValue;
            decimal check = 0;
            decimal nr;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your" + i + ". number: ");
                nr = decimal.Parse(Console.ReadLine());

                if (check == 0) 
                {
                    smallest = nr;
                    largest = nr;
                    check++;
                }

                if (smallest > nr) {
                    smallest = nr;
                }

                if (largest < nr) 
                {
                    largest = nr;
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("The smallest nr is " + smallest);
            Console.WriteLine("The largest nr is " + largest);

        }

        static void Task9() 
        {
            Console.WriteLine("Enter your number: ");
            int nr = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            if ((nr % 2) == 0)
            {
                Console.WriteLine("The nr is even.");
            }
            else 
            {
                Console.WriteLine("The nr is odd.");
            }
        }

        static void Task10()
        {
            Console.WriteLine("Enter your number A: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your number B: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            for (int i = A; i <= B; i++) 
            {
                if ((i % 2) == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Task11()
        {
            Console.WriteLine("Enter line count: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = count; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void Task12()
        {
            Console.WriteLine("Enter int nr: ");
            string nr = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < nr.Length; i++) 
            {
                sum += int.Parse(nr[i].ToString());
            }

            Console.WriteLine("The sum of digits is" + sum);
        }

        static void Task13()
        {
            Console.WriteLine("Enter line count: ");
            int count = int.Parse(Console.ReadLine());
            int line = 1;
            int check = 0;

            for (int i = 1; line <= count; i++) 
            {
                Console.Write( i + " ");
                check++;

                if (check == line) {
                    Console.WriteLine();
                    check = 0;
                    line++;
                }
                
            }

        }
    }
}