namespace E12_Google
{
    using System;

    public class Children
    {
        private string name;
        private string birthday;

        public Children(string name, string birthday)
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
                    throw new ArgumentException($"{nameof(Children)}'s name can not be neither empty nor white space!!!");
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