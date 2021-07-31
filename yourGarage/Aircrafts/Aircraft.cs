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
        public string Type { get; set; }
        public void Flying()
        {
            Console.WriteLine($"the {Color} {Type} can carry {PassengerOccupancy} people.");
        }

        public void Landing()
        {

        }
    }
}
