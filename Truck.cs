using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    public class Truck : Vehicle
    {
        public int CargoCapacity { get; set; }
        public bool FourWheelDrive { get; set; }

        public Truck(int vehicleId, string make, string model, int year, 
            double rentalRate, int cargoCapacity, bool fourWheelDrive) : base(vehicleId, make, model, year, rentalRate)
        {
            CargoCapacity = cargoCapacity;
            FourWheelDrive = fourWheelDrive;
        }

        // display fourwheel information about the truck
        public void IsFourWheelDrive(Truck truck)
        {
            if (truck.FourWheelDrive)
            {
                Console.WriteLine($"{truck} is a four wheel drive truck");
            } else
            {
                Console.WriteLine($"{truck} is not a four wheel drive truck");
            }
        }
    }
}
