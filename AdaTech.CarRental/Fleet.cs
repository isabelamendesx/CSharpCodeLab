using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.CarRental
{
    internal static class Fleet
    {
        private static List<Vehicle> _fleetVehicle = new List<Vehicle>()
        {

            new Vehicle(VehicleType.Car, VehicleStatus.Available, "ABC123", "Toyota Camry", 50.0),
            new Vehicle(VehicleType.Truck, VehicleStatus.Available, "XYZ789", "Ford F-150", 75.0),
            new Vehicle(VehicleType.MotorCycle, VehicleStatus.Available, "DEF456", "Harley Davidson", 30.0),
            new Vehicle(VehicleType.Bus, VehicleStatus.Available, "GHI789", "Mercedes-Benz Sprinter", 100.0),
            new Vehicle(VehicleType.Car, VehicleStatus.Available, "JKL321", "Honda Accord", 55.0),
            new Vehicle(VehicleType.Truck, VehicleStatus.Available, "MNO987", "Chevrolet Silverado", 80.0),
            new Vehicle(VehicleType.MotorCycle, VehicleStatus.Available, "PQR654", "Kawasaki Ninja", 35.0),
            new Vehicle(VehicleType.Bus, VehicleStatus.Available, "STU012", "Volvo B7R", 110.0),
            new Vehicle(VehicleType.Car, VehicleStatus.Available, "VWX345", "Ford Mustang", 60.0),
            new Vehicle(VehicleType.MotorCycle, VehicleStatus.Available, "YZA678", "Ducati Panigale", 40.0)
        };

        public static void showVehicleInfo()
        {
            foreach (var vehicle in _fleetVehicle)
            {
                Console.WriteLine($"(ID: {vehicle.id}) - MODEL: {vehicle.Model} - TYPE: {vehicle.VehicleType} - PRICE PER DAY: {vehicle.DailyRate}");
            }
        }

        public static Vehicle findVehicleByID(int id)
        {
            return _fleetVehicle.Find(vehicle => vehicle.id == id);
        }

        public static void showVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"(ID: {vehicle.id}) - MODEL: {vehicle.Model} - TYPE: {vehicle.VehicleType} - PRICE PER DAY: {vehicle.DailyRate}");
        }

        public static void addVehicle(Vehicle vehicle)
        {
            _fleetVehicle.Add(vehicle);
        }

        public static void removeVehicle(Vehicle vehicle)
        {
            _fleetVehicle.Remove(vehicle);
        }


    };

    }

