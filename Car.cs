using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public bool Convertible { get; set; }

        public Car(int vehicleId, string make, string model, int year, double rentalRate, int numberOfDoors, bool convertible) : base(vehicleId, make, model, year, rentalRate)
        {
            NumberOfDoors = numberOfDoors;
            Convertible = convertible;
        }

        // display convertible information about the car
        public void IsConvertible(Car car)
        {
            if (car.Convertible)
            {
                Console.WriteLine($"{car} is convertible");
            } else
            {
                Console.WriteLine($"{car} is not convertible");
            }
        }
    }
}
