using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage
{
    class VehicleBase
    {
        public int FuelCapacity { get; set; }

       
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public void Refueling()
        {
            Console.WriteLine($"The {Color} Forrester gets {FuelCapacity} miles to a gallon");
        }

        
    }
}
