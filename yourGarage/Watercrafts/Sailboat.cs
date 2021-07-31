using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage.Watercrafts
{
    class Sailboat : Watercraft
    {
        public bool HasSails { get; set; }

        public Sailboat(string color, int fuelCapacity, int passengerOccupancy, string type)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy =passengerOccupancy;
            Type = type;
        }
    }
}
