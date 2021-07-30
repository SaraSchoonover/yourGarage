using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage
{
    class Watercraft : VehicleBase
    {
        //public Watercraft(string color, int fuelCapacity, int passengerOccupancy)
        //{
        //    Color = color;
        //    FuelCapacity = fuelCapacity;
        //    PassengerOccupancy = passengerOccupancy;
        //}

        public void Driving()
        {
            Console.WriteLine($"the {Color} submarine can only hold {PassengerOccupancy} people.");

        }

    }
}
