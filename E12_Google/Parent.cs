using System;

namespace E12_Google
{
    public class Parent
    {
        private string name;
        private string birthday;

        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.birthday = birthday;
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("the name cannot be empty or white space");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return $"{this.name} {this.birthday}";
        }
    }
}