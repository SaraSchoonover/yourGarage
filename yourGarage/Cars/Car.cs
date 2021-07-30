using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage
{
    class Car : VehicleBase
    {
        
        public void Driving()
        {
            Console.WriteLine($"The {Color} car can carry {PassengerOccupancy} people");
        }

        public void Braking()
        {
            Console.WriteLine($"The {Color} car can drive {FuelCapacity} miles to a gallon");
        }
    }
}
