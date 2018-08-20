using System;

namespace E01_Vehicles.Models
{
    public class Truck : Vehicles
    {
        private const double AcConsumptionIncrease = 1.6;
        private const double LeakingFuel = 0.95; //95% in 5% leak

        public Truck(double fuelQuantity, double fuelConsomption)
            : base(fuelQuantity, fuelConsomption + AcConsumptionIncrease)
        { }

        public override void Refuel(double quantity)
        {
            base.Refuel(quantity * LeakingFuel);
        }
    }
}