using System;

namespace E02_VehiclesExtension.Models
{
    public abstract class Vehicles
    {
        public Vehicles(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        protected virtual double FuelQuantity { get; set; }

        protected double FuelConsumption { get; set; }

        protected double TankCapacity { get; set; }

        public virtual string TryDrive(double distance, bool isAcOn)
        {
            if (IsFuelEnough(distance))
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                return $"{this.GetType().Name} travelled { distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public string TryDrive(double distance)
        {
            return this.TryDrive(distance, true);
        }

        public bool IsFuelEnough(double distance)
        {
            if (this.FuelQuantity >= this.FuelConsumption * distance)
            {
                return true;
            }
            return false;
        }

        protected bool IsTankOverflow(double quantity)
        {
            if (this.TankCapacity <= this.FuelQuantity + quantity)
            {
                return true;
            }
            return false;
        }

        public virtual void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}