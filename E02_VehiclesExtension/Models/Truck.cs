using System;

namespace E02_VehiclesExtension.Models
{
    public class Truck : Vehicles
    {
        private const double AcConsumptionIncrease = 1.6;
        private const double LeakingFuel = 0.95; //95% in 5% leak

        public Truck(double fuelQuantity, double fuelConsomption, double tankCapacity)
            : base(fuelQuantity, fuelConsomption + AcConsumptionIncrease, tankCapacity)
        { }

        public override void Refuel(double quantity)
        {
            base.Refuel(quantity * LeakingFuel);
        }
    }
}