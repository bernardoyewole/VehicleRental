using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental
{
    public abstract class RentalTransaction
    {
        // RentalTransaction attributes
        public int TransactionId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }

        public abstract double CalculateRentalCost(Vehicle vehicle);
    }
}
