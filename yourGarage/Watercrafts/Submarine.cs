using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage.Watercrafts
{
    class Submarine : Watercraft
    {
        public bool CanSubmerge { get; set; }

        public Submarine(string color, int passengerOccupancy, int fuelCapacity)
        {
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            FuelCapacity = fuelCapacity;
        }

    }
}