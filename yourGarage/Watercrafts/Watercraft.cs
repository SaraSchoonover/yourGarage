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
        public string Type { get; set; }
        public void Driving()
        {
            Console.WriteLine($"the {Color} {Type} can only hold {PassengerOccupancy} people.");

        }

    }
}
