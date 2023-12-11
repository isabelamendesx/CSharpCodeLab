using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.CarRental
{
    internal class Employee : User
    {
        public JobTitle jobTitle {  get; set; }
        List<Reservation> reservationList;

        public Employee(string username, string password, string name, JobTitle jobTitle)
    : base(username, password, name)
        {
           reservationList = new List<Reservation>();
            this.jobTitle = jobTitle;
        }

        public bool DeliverCar(Client client)
        {
           
            var reservation = reservationList.Find(reservation => reservation.client == client);

            Console.WriteLine("Checking your reservation....");
            Thread.Sleep(1000);
            if(reservation != null)
            {
                reservation.vehicle.VehicleStatus = VehicleStatus.Rented;
                Console.WriteLine("Sucess! Enjoy your car");
                return true;
            }

            Console.WriteLine("Sorry. We can't find your reservation");
            return false;
        }

        public bool RecieveCar(Client client)
        {

            var reservation = reservationList.Find(reservation => reservation.client == client);

            Console.WriteLine("Checking your reservation....");
            Thread.Sleep(1000);
            if (reservation != null)
            {
                reservation.vehicle.VehicleStatus = VehicleStatus.Rented;
                Console.WriteLine("Sucess! Vehicle recieved");
                return true;
            }

            Console.WriteLine("Sorry. We can't find your reservation");
            return false;
        }


        public void addReservation(Reservation reservation)
        {
            reservationList.Add(reservation);
        }

        public bool aproveReservation(Client client)
        {
            if (CheckDriversLicense(client))
            {
                return true;
            }
            return false;
        }

        public bool CheckDriversLicense(Client client)
        {
            if(client._driversLicense != null)
            {
                return true;
            }
            return false;
        }
    }
}
