using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    public class Vehicle
    {
        // Vehicle attributes
        private int vehicleId;
        private string make;
        private string model;
        private int year;
        private double rentalRate;

        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value;  }
        }

        // Vehicle constructor
        public Vehicle(int vehicleId, string make, string model, int year, double rentalRate)
        {
            VehicleId = vehicleId;
            Make = make;
            Model = model;
            Year = year;
            RentalRate = rentalRate;
        }
    }
}
