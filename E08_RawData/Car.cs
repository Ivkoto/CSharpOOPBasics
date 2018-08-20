namespace E08_RawData
{
    using System;
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;


        public Car
            (string model, Engine engin, Cargo cargo, Tire[] tires)
        {
            this.model = model;
            this.engine = engin;
            this.cargo = cargo;
            this.Tires = tires;
        }

        public string Model
        {
            get { return this.model; }
        }
        public Engine Engine
        {
            get { return engine; }
        }
        public Cargo Cargo
        {
            get { return this.cargo; }
        }
        public Tire[] Tires
        {
            get { return this.tires; }
            set
            {
                if (value.Length != 4)
                {
                    throw new InvalidOperationException("Tires can not be no more neither less than 4!!!");
                }
                else
                {
                    this.tires = value;
                }
            }
        }
    }
}
