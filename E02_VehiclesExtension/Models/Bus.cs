using System;

namespace E02_VehiclesExtension.Models
{
    public class Bus : Vehicles
    {
        private const double AcConsumptionIncrease = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
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

        public override string TryDrive(double distance, bool isAcOn)
        {
            if (isAcOn)
            {
                return base.TryDrive(distance, true);
            }
            if (base.IsFuelEnough(distance))
            {
                base.FuelQuantity -= (base.FuelConsumption - AcConsumptionIncrease) * distance;
                return $"{this.GetType().Name} travelled { distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }
    }
}