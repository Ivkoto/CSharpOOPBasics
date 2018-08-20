namespace E10_CarSalesman
{
    using System;
    public class Car
    {
        private string model;
        private Engine engine;
        private double? weight;
        private string color;

        public Car(string model, Engine engin)
        {
            this.model = model;
            this.engine = engin;
        }

        public double Weight
        {
            set { this.weight = value; }
        }

        public string Color
        {
            set { this.color = value; }
        }

        public override string ToString()
        {
            var result = $"{this.model}:";
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, this.engine.ToString());
            result = string.Concat(result, this.weight == null ? "  Weight: n/a" : $"  Weight: {this.weight}");
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, this.color == null ? "  Color: n/a" : $"  Color: {this.color}");

            return result;
        }
    }
}
