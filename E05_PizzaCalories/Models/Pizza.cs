using System;
using System.Collections.Generic;
using System.Linq;

namespace E05_PizzaCalories.Models
{
    public class Pizza
    {
        private const int minNameLength = 1;
        private const int maxNameLength = 15;
        private const int minToppingCount = 0;
        private const int maxToppingCount = 10;

        private string name;
        private int toppingsCount;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, int toppingCount)
        {
            this.Name = name;
            this.ToppingCount = toppingCount;
            this.toppings = new List<Topping>();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < minNameLength || value.Length > maxNameLength)
                {
                    throw new ArgumentOutOfRangeException($"Pizza name should be between {minNameLength} and {maxNameLength} symbols.");
                }
                this.name = value;
            }
        }        

        public int ToppingCount
        {
            get { return this.toppingsCount; }
            private set
            {
                if (value < minToppingCount || value > maxToppingCount)
                {
                    throw new ArgumentException($"Number of toppings should be in range [{minToppingCount}..{maxToppingCount}].");
                }
                this.toppingsCount = value;
            }
        }

        public void AddDough(Dough dough)
        {
            this.dough = dough;
        }

        public void AddToppings(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double CalculateTotalCalories()
        {
            return this.dough.CalculateCalories() + toppings.Sum(t => t.CalculateCalories());
        }
    }
}