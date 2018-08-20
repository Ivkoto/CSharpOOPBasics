using System;
using System.Text;
using System.Linq;

namespace E03_Manking.Models
{
    public class Student : Human
    {
        private const int minValue = 5;
        private const int maxValue = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < minValue || value.Length > maxValue || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
              .AppendLine($"Faculty number: {this.facultyNumber}");

            return sb.ToString();
        }
    }
}