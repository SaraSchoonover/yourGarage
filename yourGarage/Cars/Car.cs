using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage
{
    class Car : VehicleBase
    {
        public string Type { get; set; }
        public void Driving()
        {
            Console.WriteLine($"The {Color} {Type} can carry {PassengerOccupancy} people");
        }

        public void Braking()
        {
            Console.WriteLine($"The {Color}  can drive {FuelCapacity} miles to a gallon");
        }
    }
}
