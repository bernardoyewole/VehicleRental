using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    public static class RentalAgency
    {
        // creating static lists to store instances of Vehicle, CarRental
        // and TruckRental classes
        private static List<Vehicle> vehicles = new List<Vehicle>();
        private static List<CarRental> carRentals = new List<CarRental>();
        private static List<TruckRental> truckRentals = new List<TruckRental>();

        public static List<Vehicle> Vehicles
        {
            get { return vehicles; }
            set { vehicles = value; }
        }
        public static List<CarRental> CarRentals
        {
            get { return carRentals; }
            set { carRentals = value; }
        }
        public static List<TruckRental> TruckRentals
        {
            get { return truckRentals; }
            set { truckRentals = value; }
        }

        // add vehicle to vehicle list
        public static void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} added to inventory");
        }

        // process car rental by calculating rental cost
        public static double ProcessRental(Vehicle vehicle, CarRental carRental)
        {
            double rentalCost = carRental.CalculateRentalCost(vehicle);
            Console.WriteLine($"Cost of rental for {vehicle.Make} {vehicle.Model} is ${rentalCost}");
            return rentalCost;
        }

        // process truck rental by calculating rental cost
        public static double ProcessRental(Vehicle vehicle, TruckRental truckRental)
        {
            double rentalCost = truckRental.CalculateRentalCost(vehicle);
            Console.WriteLine($"Cost of rental for {vehicle.Make} {vehicle.Model} is ${rentalCost}");
            return rentalCost;
        }

        // display car rental history
        public static void DisplayRentalHistory(Vehicle vehicle, CarRental carRental)
        {
            Console.WriteLine($"Customer Name => {carRental.CustomerName}");
            Console.WriteLine($"Rented Vehicle => {vehicle.Make} {vehicle.Model} {vehicle.Year}");
            Console.WriteLine($"Rental Start Date => {carRental.RentalStartDate}");
            Console.WriteLine($"Rental End Date => {carRental.RentalEndDate}");
            Console.WriteLine($"Rental cost => ${carRental.CalculateRentalCost(vehicle)}");
        }

        // display truck rental history
        public static void DisplayRentalHistory(Vehicle vehicle, TruckRental truckRental)
        {
            Console.WriteLine($"Customer Name => {truckRental.CustomerName}");
            Console.WriteLine($"Rented Vehicle => {vehicle.Make} {vehicle.Model} {vehicle.Year}");
            Console.WriteLine($"Rental Start Date => {truckRental.RentalStartDate}");
            Console.WriteLine($"Rental End Date => {truckRental.RentalEndDate}");
            Console.WriteLine($"Rental cost => ${truckRental.CalculateRentalCost(vehicle)}");
        }
    }
}
