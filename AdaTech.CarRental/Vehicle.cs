using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.CarRental
{
    public class Vehicle
    {
        private static int lastID = 0;

        public int id {get;}
        public VehicleType VehicleType { get; private set; }
        public VehicleStatus VehicleStatus { get; set; }
        public string Plate { get; private set; }
        public string Model { get; private set; }
        public double DailyRate { get; private set; }

        // Construtor da classe
        public Vehicle(
            VehicleType vehicleType,
            VehicleStatus vehicleStatus,
            string plate,
            string model,
            double dailyRate)
        {
            VehicleType = vehicleType;
            VehicleStatus = vehicleStatus;
            Plate = plate;
            Model = model;
            DailyRate = dailyRate;
            id = ++lastID;
        }

    }

}

