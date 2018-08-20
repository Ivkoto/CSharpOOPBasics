using System;

namespace E05_PizzaCalories.Models
{
    public class Topping
    {
        private const int baseCaloriesPerGram = 2;
        private const int minWeight = 1;
        private const int maxWeight = 50;

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        private string Type
        {
            get { return this.type; }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public double CalculateCalories()
        {
            return baseCaloriesPerGram * this.Weight * GetTypeModif();
        }

        private double GetTypeModif()
        {
            if (this.Type.ToLower() == "meat")
            {
                return 1.2;
            }
            else if (this.Type.ToLower() == "veggies")
            {
                return 0.8;
            }
            else if (this.Type.ToLower() == "cheese")
            {
                return 1.1;
            }
            return 0.9;
        }
    }
}