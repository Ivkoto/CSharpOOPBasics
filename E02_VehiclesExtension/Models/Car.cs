using System;

namespace E02_VehiclesExtension.Models
{
    public class Car : Vehicles
    {
        private const double AcConsumptionIncrease = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + AcConsumptionIncrease, tankCapacity)
        { }

        protected override double FuelQuantity
        {
            set
            {
                if (value > this.TankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }
                base.FuelQuantity = value;
            }
        }

        public override void Refuel(double quantity)
        {
            if (base.IsTankOverflow(quantity))
            {
                throw new ArgumentException("Cannot fit fuel in tank");                
            }
            base.Refuel(quantity);
        }
    }
}