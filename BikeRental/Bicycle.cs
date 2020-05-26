using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    class Bicycle
    {
        public string Name { get; set; }
        public int number { get; set; }
        public double pricePerHoure { get; set; }

        public Bicycle(string name, int bicyclesNR, double pricePerH){
            this.Name = name;
            this.number = bicyclesNR;
            this.pricePerHoure = pricePerH;
        }
    }
}
