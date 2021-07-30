using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage.Aircrafts
{
    class Airplane : Aircraft
    {
        public int NumberOfEngines { get; set; }

        public Airplane(string color, int fuelCapacity, int passengerOccupancy, int numberOfEngines)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            NumberOfEngines = numberOfEngines;
        }
    }
}
