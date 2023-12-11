using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.CarRental
{
    public class Reservation
    {
        public Vehicle vehicle { get; set; }
        public Client client { get; set; }
        public Employee employee { get; set; } 
        public DateTime returnDate { get; set; }
        public DateTime pickupDate { get; set; }
        public Payment? payment { get; set; }

        public Reservation(Vehicle vehicle, Client client, Employee employee, DateTime returnDate, DateTime pickupDate)
        {
            this.vehicle = vehicle;
            this.client = client;
            this.employee = employee;
            this.returnDate = returnDate;
            this.pickupDate = pickupDate;
            payment = new Payment(calculateTotalValue(), client._paymentMethod);
        }

        public double calculateTotalValue()
        {
            TimeSpan daysRented = pickupDate - returnDate;
            int daysRentedInt = (int)daysRented.TotalDays;
            return vehicle.DailyRate * daysRentedInt;
        }

    }
}
