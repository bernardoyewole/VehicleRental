using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    internal class Program
    {
        /// <summary>
        /// This is a vehicle rental management system using Polymorphism and Abstract Classes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // creating and initializing new instances of Car and Truck classes
            Car car = new Car(23323, "Honda", "Civic", 2023, 40, 4, true);
            Truck truck = new Truck(94002, "Toyota", "Tundra", 2013, 100, 2, true);

            // creating and initializing new instance of CarRental class
            CarRental carRental = new CarRental();
            carRental.CustomerName = "Bernard";
            carRental.RentalStartDate = new DateTime(2020, 3, 15);
            carRental.RentalEndDate = new DateTime(2020, 3, 25);

            // creating new instance of TruckRental class
            TruckRental truckRental = new TruckRental();
            truckRental.RentalStartDate = new DateTime(2023, 4, 12);
            truckRental.RentalEndDate = new DateTime(2023, 4, 20);
            truckRental.CustomerName = "Harshil";

            RentalAgency.AddVehicle(car);
            RentalAgency.AddVehicle(truck);

            Console.WriteLine();
            RentalAgency.ProcessRental(car, carRental);
            RentalAgency.ProcessRental(truck, truckRental);

            Console.WriteLine();
            RentalAgency.DisplayRentalHistory(car, carRental);
            Console.WriteLine();
            RentalAgency.DisplayRentalHistory(truck, truckRental);

            Console.ReadKey();
        }
    }
}
