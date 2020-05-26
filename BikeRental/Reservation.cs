using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    class Reservation
    {
        public string usersEmail { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int selectedBicyclesNr { get; set; }

        public Reservation(string userEmail, DateTime startTime, DateTime endTime, int selectedNR) {

            this.usersEmail = userEmail;
            this.startTime = startTime;
            this.endTime = endTime;
            this.selectedBicyclesNr = selectedNR;

        }
    }
}
