using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage
{
    class Aircraft : VehicleBase
    {
        //public Aircraft(string color, int fuelCapacity, int passengerOccupancy)
        //{
        //    Color = color;
        //    FuelCapacity = fuelCapacity;
        //    PassengerOccupancy = passengerOccupancy;
        //}

        public void Flying()
        {
            Console.WriteLine($"the {Color} of the aircraft can carry {PassengerOccupancy} people.");
        }

        public void Landing()
        {

        }
    }
}
