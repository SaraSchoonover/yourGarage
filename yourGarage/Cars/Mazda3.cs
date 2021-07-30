using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage.Cars
{
    class Mazda3 : Car
    {
        public bool HasHeatedSeats { get; set; }

        public Mazda3(string color, int fuelCapacity, int passengerOccupancy)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
        }

    }
}
