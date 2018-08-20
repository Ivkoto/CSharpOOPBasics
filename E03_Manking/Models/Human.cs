using System;
using System.Text;

namespace E03_Manking.Models
{
    public class Human
    {
        private const int minFisrtNameLength = 4;
        private const int minLastNameLength = 3;

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        protected string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                if (value.Length < minFisrtNameLength)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                this.firstName = value;
            }
        }

        protected string LastName
        {
            get { return this.lastName; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else if (value.Length < minLastNameLength)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}")
              .AppendLine($"Last Name: {this.LastName}");

            return sb.ToString();
        }
    }
}