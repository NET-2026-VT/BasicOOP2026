using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP2026
{
    internal class Vehicle : IDriveable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand; 
        }

        public string Drive(int distance)
        {
            return $"{GetType().Name} drove for {distance} km";
        }
    }

    internal class Car : Vehicle, IDriveable
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model; 
        }
    }
}
