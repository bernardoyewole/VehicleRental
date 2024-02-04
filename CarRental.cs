using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    public class CarRental : RentalTransaction
    {
        // car rental attributes
        public string CustomerName { get; set; }
        public DateTime ActualReturnDate { get; set; }

        // calculate rental cost using rental start and end dates
        public override double CalculateRentalCost(Vehicle vehicle)
        {
            TimeSpan rentalDays = RentalEndDate - RentalStartDate;
            return rentalDays.TotalDays * vehicle.RentalRate;
        }
    }
}
