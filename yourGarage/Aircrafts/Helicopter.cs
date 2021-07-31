using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage.Aircrafts
{
    class Helicopter : Aircraft
    {
        public string HelicopterType { get; set; }

        public Helicopter(string color, int fuelCapacity, int passengerOccupancy, string type)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            Type = type;
        }
    }
}
