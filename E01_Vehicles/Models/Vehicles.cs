using System.Text;

namespace E01_Vehicles.Models
{
    public abstract class Vehicles
    {
        public Vehicles(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        protected double FuelQuantity { get; set; }

        protected double FuelConsumption { get; set; }
        
        public string TryDrive(double distance)
        {
            if (IsFuelEnough(distance))
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                return $"{this.GetType().Name} travelled { distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }        

        public bool IsFuelEnough(double distance)
        {
            if (this.FuelQuantity >= this.FuelConsumption * distance)
            {
                return true;
            }
            return false;
        }

        public virtual void Refuel(double quantity) => this.FuelQuantity += quantity;

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity :f2}";
        }
    }
}