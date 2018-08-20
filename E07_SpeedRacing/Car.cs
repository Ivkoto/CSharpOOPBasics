namespace E07_SpeedRacing
{
    public class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private int traveledDistance;

        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public decimal FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public decimal FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public int TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }

        public void CarMovement(int distanceToDrive)
        {
            if (distanceToDrive * this.FuelConsumption <= this.FuelAmount)
            {
                this.fuelAmount -= distanceToDrive * this.FuelConsumption;
                this.TraveledDistance += distanceToDrive;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public string PrintCarInfo()
        {
            return $"{this.Model} {this.fuelAmount :f2} {this.TraveledDistance}";
        }
    }
}
