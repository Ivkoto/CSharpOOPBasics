namespace E05_PizzaCalories.Models
{
    using System;

    public class Dough
    {
        private const int minWeight = 1;
        private const int maxWeight = 200;
        private const int baseCaloriesPerGram = 2;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{minWeight}..{maxWeight}].");
                }
                this.weight = value;
            }
        }

        private string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (value.ToLower() != "homemade" && value.ToLower() != "chewy" && value.ToLower() != "crispy")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        private string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value.ToLower() != "wholegrain" && value.ToLower() != "white")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public double CalculateCalories()
        {
            return baseCaloriesPerGram * this.Weight * this.GetTypeModif() * this.GetTechniqueMod();
        }

        private double GetTypeModif()
        {
            if (this.FlourType.ToLower() == "white")
            {
                return 1.5;
            }
            return 1.0;
        }

        private double GetTechniqueMod()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}