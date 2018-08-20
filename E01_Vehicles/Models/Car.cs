using System;

namespace E01_Vehicles.Models
{
    public class Car : Vehicles
    {
        private const double AcConsumptionIncrease = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption + AcConsumptionIncrease)
        { }       
    }
}