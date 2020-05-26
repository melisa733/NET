using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
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
            Task6();
            Console.Read();
        }

        static void Task1() 
        {
            int nr1;
            int nr2;
            int last1;
            int last2;

            Console.WriteLine("Please enter nr 1:");
            nr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter nr 2:");
            nr2 = int.Parse(Console.ReadLine());

            last1 = nr1 % 10;
            last2 = nr2 % 10;

            if (last1 == last2)
            {
                Console.WriteLine("SAME");
            }
            else 
            {
                Console.WriteLine("NOT SAME");
            }

        }

        static void Task2()
        {
            char[] word;
            int count = 0;

            Console.WriteLine("Please enter word :");
            word = Console.ReadLine().ToUpper().ToCharArray();

            for (int i = 0; i < word.Length; i++) 
            {
                if (word[i] == 'E') {
                    count++;
                }
            }

            Console.WriteLine("The 'e' count in words is: {0}", count);
        }

        static void Task3()
        {
            int N;
            int dividedBy = 5;
            int count = 0;

            Console.WriteLine("Please enter number :");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i%dividedBy == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("The nr count till {0} divided by {1} is {2}", N, dividedBy, count);
        }

        static void Task4()
        {
            List<int> numbers = new List<int>();
            string input;
            while (true) {
                Console.WriteLine("Enter nr or stop: ");
                input = Console.ReadLine();

                if (input != "stop")
                {
                    numbers.Add(int.Parse(input));
                }
                else 
                {
                    break;
                }
            }

            if (numbers.Count != 0)
            {
                if (numbers[0] == numbers[numbers.Count - 1] || numbers.Count == 1)
                {
                    Console.WriteLine("EQUAL.");
                }
                else
                {
                    Console.WriteLine("NOT EQUAL.");
                }
            }
            else 
            {
                Console.WriteLine("Not even one nr in list.");
            }
        }

        static void Task5()
        {
            int nr1;
            int nr2;
            int nrInComparison = 21;

            Console.WriteLine("Please enter nr 1:");
            nr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter nr 2:");
            nr2 = int.Parse(Console.ReadLine());

            if (nr1 > nrInComparison && nr2 > nrInComparison)
            {
                Console.WriteLine("Both nr exceeds {0}", nrInComparison);
            }
            else 
            {
                if (nr1 == nr2)
                {
                    Console.WriteLine("0");
                }
                else {
                    if (Math.Abs(nr1 - nrInComparison) > Math.Abs(nr2 - nrInComparison))
                    {
                        Console.WriteLine(nr2);
                    }
                    else 
                    {
                        Console.WriteLine(nr1);
                    }
                }
            
            }

        }

        static void Task6()
        {
            ContactManager contactManager = new ContactManager();
            string operation;

            while (!contactManager.getExit()) {
                Console.WriteLine("Operations: ");
                Console.WriteLine("1) List,");
                Console.WriteLine("2) Add,");
                Console.WriteLine("3) Delete,");
                Console.WriteLine("4) Exit,");
                Console.WriteLine("Please enter operations number(example: '1' for opeartion List): ");
                operation = Console.ReadLine();
                Console.WriteLine("");

                switch(operation){
                    case "1":
                        contactManager.List();
                        break;
                    case "2":
                        contactManager.Add();
                        break;
                    case "3":
                        contactManager.Delete();
                        break;
                    case "4":
                        contactManager.Exit();
                        break;
                    default:
                        Console.WriteLine("Unknown opeartion");
                        break;
                }

                Console.WriteLine("");
            }

            Console.WriteLine("GOODBYE!");
        }
    }
}
