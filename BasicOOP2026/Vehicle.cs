using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP2026
{
    internal abstract class AbstractVehicle : IDriveable
    {
        private int fuel = 50;
        public abstract string Turn();
        public virtual string Drive(int distance)
        {
            fuel -= 5;
            return $"{GetType().Name} drove for {distance} km {fuel} units of fuel remaining";
        }

    }
    internal class Vehicle : AbstractVehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand; 
        }

        public override string Turn()
        {
            return "Turning"; 
        }
    }

    internal class Car : Vehicle, IDriveable, IStoppable
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model; 
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }

        public override string Drive(int distance)
        {
            return $"{base.Drive(distance)} from car";
        }
    }

    internal class Saab : Car
    {
        public Saab(string model = "900") : base("SAAB", model)
        {

        }

        public string SpecialMethod()
        {
            return "From Saab";
        }
    }
}
