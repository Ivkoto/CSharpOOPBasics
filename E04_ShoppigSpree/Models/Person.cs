namespace E04_ShoppigSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException($"{nameof(Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        private decimal Money
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }
                this.money = value;
            }
        }

        public IList<Product> GetProducts()
        {
            return this.bag.AsReadOnly();
        }

        public bool BuyingProduct(Product curProduct)
        {
            if (this.money >= curProduct.Cost)
            {
                bag.Add(curProduct);
                this.money -= curProduct.Cost;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            var result = $"{this.Name} - ";
            result = string.Concat(result, string.Join(", ", this.bag.Select(p => p.Name)));
            return result;
        }
    }
}