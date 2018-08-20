using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace E12_Google
{
    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private Queue<Parent> parents;
        private Queue<Children> childrens;
        private Queue<Pokemon> pokemons;

        public Person(string name)
        {
            this.Name = name;
            this.parents = new Queue<Parent>();
            this.childrens = new Queue<Children>();
            this.pokemons = new Queue<Pokemon>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Person)}'s name can not be neither empty nor white space!!!");
                }
                this.name = value;
            }
        }

        public Company Company
        {
            set { this.company = value; }
        }

        public Car Car
        {
            set { this.car = value; }
        }

        public void AddInCollection(Parent parent)
        {
            this.parents.Enqueue(parent);
        }

        public void AddInCollection(Children child)
        {
            this.childrens.Enqueue(child);
        }

        public void AddInCollection(Pokemon pokemon)
        {
            this.pokemons.Enqueue(pokemon);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.name);
            sb.AppendLine("Company:");
            if (this.company != null)
            {
                sb.AppendLine(this.company.ToString());
            }
            sb.AppendLine("Car:");
            if (this.car != null)
            {
                sb.AppendLine(this.car.ToString());
            }
            sb.AppendLine("Pokemon:");
            if (this.pokemons.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.pokemons.Select(p => p.ToString())));
            }
            sb.AppendLine("Parents:");
            if (this.parents.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.parents.Select(p => p.ToString())));
            }
            sb.AppendLine("Children:");
            if (this.childrens.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.childrens.Select(c => c.ToString())));
            }

            return sb.ToString();
        }
    }
}