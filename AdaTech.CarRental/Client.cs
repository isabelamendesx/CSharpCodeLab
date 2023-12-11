using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.CarRental
{
    internal class Client : User
    {
        public string _driversLicense {  get; set; }
        public PaymentMethod _paymentMethod { get; set; }
        public Vehicle? _rentedVehicle { get; set; }
        public Vehicle? _choseVehicle { get; set; }

        public Reservation? _reservation { get; set; }

        public Client(PaymentMethod pm, string username, string password, string name, string driversLicense) 
            : base(username, password, name)
        {
            _driversLicense = driversLicense;
            _paymentMethod = pm;
            _rentedVehicle = null;
            _choseVehicle = null;
            _reservation = null;
        }

        public bool FindVehicle()
        {
            int id;

            do
            {
                Console.Clear();
                Fleet.showVehicleInfo();

                id = Utilities.LerNumeroInt("Type vehicle ID to ask for a reservation or 0 to go back to menu", 0, 11);

                if (id == 0)
                {
                    return false;
                }


                Fleet.showVehicle(Fleet.findVehicleByID(id));

                Console.WriteLine("\n Press 'y' to confirm  or any other key to choose again:");
            } while (Console.ReadLine().ToLower() != "y");


            _choseVehicle = Fleet.findVehicleByID(id);
            return true;
            
        }

        public bool askForReservation(Employee employee)
        {
            DateTime pickupDate = Utilities.LerData("Enter the vehicle pickup date (dd/mm/yyyy)", DateTime.Now);
            DateTime returnDate = Utilities.LerData("Enter the vehicle return date (dd/mm/yyyy)", pickupDate);

            Console.WriteLine($"Your current Payment Method is {this._paymentMethod}. Type 0 to change or any other key to continue");
           
            if(Console.ReadLine() == "0")
            {
                changePaymentMethod();
                Console.WriteLine("Payment Method changed!\n");
            }

            if (Pay())
            {
                Console.WriteLine("The Employee is checking your Driver's License. Wait....");
                Thread.Sleep(1000);
                if (employee.aproveReservation(this))
                {
                    _reservation = new Reservation(_choseVehicle, this, employee, returnDate, pickupDate);
                    employee.addReservation(_reservation);
                    _rentedVehicle = _choseVehicle;
                    _choseVehicle = null;
                    Console.WriteLine("Sucess, your vehicle is reserved!");
                    return true;
                }
                else {
                    Console.WriteLine("Sorry, we can't check your Driver's License");
                    return false;
                }
            }
            return false;      
        }

        public void pickUpCar(Employee employee)
        {
            DateTime pickupDate = Utilities.LerDataExata("Enter today's date (dd/mm/yyyy)", _reservation.pickupDate);

            if (!employee.DeliverCar(this))
                return;
        }

        public void returnCar(Employee employee)
        {
            DateTime pickupDate = Utilities.LerDataExata("Enter today's date (dd/mm/yyyy)", _reservation.returnDate);

            if (!employee.DeliverCar(this))
                return;
        }
        public void changePaymentMethod()
        {
            Console.WriteLine("+===============================+");
            Console.WriteLine("|        * CHOOSE ONE *         |");
            Console.WriteLine("|      1. Debit Card            |");
            Console.WriteLine("|      2. Credit Card           |");
            Console.WriteLine("|      3. Cash                  |");
            Console.WriteLine("|      4. Pix                   |");
            Console.WriteLine("+===============================|");
            int chose = Utilities.LerNumeroInt("Type the option", 0, 5);
            _paymentMethod = (PaymentMethod)chose;
        }


        public bool Pay()
        {
            Console.WriteLine("Press any key to pay or 0 to cancel");
            if(_paymentMethod != null && Console.ReadLine() != "0")
            {
                Console.WriteLine("Checking your payment...");
                Thread.Sleep(1000);
                Console.WriteLine("Sucess! You pay your reservation");
                return true;
            }
            return false;
        }




        
    }
}
