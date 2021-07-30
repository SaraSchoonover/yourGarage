using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourGarage.Cars
{
    class SubaruForrester : Car
    {
        public bool HasBackupCamera { get; set; }

        public SubaruForrester(string color, int fuelCapacity, int passengerOccupancy, bool hasBackupCamera)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            HasBackupCamera = hasBackupCamera;
        }
        

    }
}
