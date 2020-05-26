using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    class ReservationManager
    {

        List<Reservation> reservations ;

        public ReservationManager() {
            reservations = new List<Reservation>();
        }

        public void saveReservation(int bikesNr, string usersEmail, double hours) {
            DateTime start = DateTime.Now;
            DateTime time = DateTime.Now;
            DateTime end = time.AddHours(hours);
            reservations.Add(new Reservation(usersEmail, start, end, bikesNr));
        }

        public bool isThisBikeAviable(int selectedNr) {
            bool isAviable = true;
            
            foreach (var reservation in reservations) {
                if (reservation.selectedBicyclesNr == selectedNr) {
                    if (hasThisTimePassed(reservation.endTime))
                    {
                        isAviable = true;
                    }
                    else {
                        isAviable = false;
                    }
                }
            }
            return isAviable;
        }

        private static bool hasThisTimePassed(DateTime time) {
            if (time < DateTime.Now)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void printAllReservations() {
            foreach (var reser in reservations)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}",
                    reser.usersEmail, reser.startTime, reser.endTime, reser.selectedBicyclesNr);
            }
        }
    }
}
