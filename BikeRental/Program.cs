using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    class Program
    {
        static void Main(string[] args)
        {
            ReservationManager reservationManager = new ReservationManager();
            BicycleManager bicycleManager = new BicycleManager();

            int bikeNr;

            double hours;
            string email;

            string answer;

            while (true) {
                Console.WriteLine("Bikes:");
                bicycleManager.printAllBiycles();
                Console.WriteLine("");

                Console.Write("Enter bicycle number to rent: ");
                bikeNr = int.Parse(Console.ReadLine());

                if (!bicycleManager.isThereSuchBike(bikeNr))
                {
                    Console.WriteLine("There is no such bike.");
                    Console.WriteLine("Do u want to try again? (enter: yes/no)");
                    answer = Console.ReadLine().ToLower();

                    if (answer == "yes")
                    {
                        continue;
                    }
                    else if (answer == "no") 
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("You didn't answer yes/no. Goodbye!");
                        break;
                    }
                }

                Console.Write("Enter rental period(hours): ");
                hours = double.Parse(Console.ReadLine());

                Console.Write("Enter your email: ");
                email = Console.ReadLine();

                reservationManager.printAllReservations();

                if (!reservationManager.isThisBikeAviable(bikeNr)) {

                    Console.WriteLine("This bike has been rented.");
                    Console.WriteLine("Do u want to rent another bike? (enter: yes/no)");
                    answer = Console.ReadLine().ToLower();

                    if (answer == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine();
                        continue;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You didn't answer yes/no. Goodbye!");
                        break;
                    }

                }

                    Console.WriteLine("You have successfuly rented {0} , with total price {1}",
                    bicycleManager.getSelectedBikesName(bikeNr),
                    bicycleManager.getSelectedBikesTotalPrice(bikeNr, hours));


                    Console.WriteLine("Do u want to rent another bike? (enter: yes/no)");
                    answer = Console.ReadLine().ToLower();

                    if (answer == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine();
                        continue;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You didn't answer yes/no. Goodbye!");
                        break;
                    }

            }

            Console.Read();
        }
    }
}
