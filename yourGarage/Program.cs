using System;
using yourGarage.Cars;
using yourGarage.Aircrafts;
using yourGarage.Watercrafts;
using System.Collections.Generic;
// using yourGarage.Cars;

namespace yourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            
            var cars = new List<Car> { new Mazda3("black", 33, 4, "Mazda3"), new SubaruForrester("gray", 29, 7, "Subaru") };
            foreach (var car in cars)
            {
                car.Driving();
            }

            var watercrafts = new List<Watercraft> { new Sailboat("black", 33, 4, "sailboat"), new Submarine("gray", 29, 7, "submarine") };
            foreach (var watercraft in watercrafts)
            {
                watercraft.Driving();
            }

            var aircrafts = new List<Aircraft> { new Airplane("black", 33, 4, 3, "airplane"), new Helicopter("gray", 29, 7, "helipcopter") };
            foreach (var aircraft in aircrafts)
            {
                aircraft.Flying();
            }
        }
    }
}
