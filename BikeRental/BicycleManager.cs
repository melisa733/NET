using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    class BicycleManager
    {

        List<Bicycle> bicycles;

        public BicycleManager() {
            bicycles = new List<Bicycle>();
            bicycles.Add(new Bicycle("B-Type Detroit Bike", 1, 2.00));
            bicycles.Add(new Bicycle("Strudy bike X400", 2, 5.00));
            bicycles.Add(new Bicycle("Lightspeed Drift", 3, 5.00));
            bicycles.Add(new Bicycle("Marlin Bike Ser", 4, 7.00));
            bicycles.Add(new Bicycle("Atlas rise for kids", 5, 0.00));
        }

        public void printAllBiycles() {

            foreach (var bike in bicycles) {
                Console.WriteLine("{0} - {1}, price per houre: {2}",
                    bike.number, bike.Name, bike.pricePerHoure);
            }

        }

        public bool isThereSuchBike(int selectedNr) {
            bool isThere = false;

            foreach (var bike in bicycles)
            {
                if (bike.number == selectedNr)
                {
                    isThere = true;
                    break;
                }
            }

            return isThere;
        }
        public string getSelectedBikesName(int selectedNr) {
            string name = "";
            foreach (var bike in bicycles)
            {
                if (bike.number == selectedNr) {
                    name = bike.Name;
                    break;
                }
            }
            return name;
        }

        public double getSelectedBikesPricePerH(int selectedNr)
        {
            double price = 0.00;
            foreach (var bike in bicycles)
            {
                if (bike.number == selectedNr)
                {
                    price = bike.pricePerHoure;
                    break;
                }
            }
            return price;
        }

        public double getSelectedBikesTotalPrice(int selectedNr, double hours)
        {
            double price = 0.00;
            foreach (var bike in bicycles)
            {
                if (bike.number == selectedNr)
                {
                    price = bike.pricePerHoure * hours;
                    break;
                }
            }
            return price;
        }
    }
}
