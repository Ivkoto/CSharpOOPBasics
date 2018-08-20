using System;
using System.Text;

namespace E03_Manking.Models
{
    public class Worker : Human
    {
        private const decimal minWeekSalary = 10;
        private const int minWorkHours = 1;
        private const int maxWorkHours = 12;

        private const int workingDaysPerWeek = 5;
        private decimal weekSalary;
        private decimal dailyWorkHours;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.DailyWorkHours = workHours;
        }

        private decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < minWeekSalary)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        private decimal DailyWorkHours
        {
            get { return this.dailyWorkHours; }
            set
            {
                if (value < minWorkHours || value > maxWorkHours)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.dailyWorkHours = value;
            }
        }

        private decimal GetPaymentPerHour()
        {
            return weekSalary / (workingDaysPerWeek * this.dailyWorkHours);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
              .AppendLine($"Week Salary: {this.weekSalary:f2}")
              .AppendLine($"Hours per day: {this.dailyWorkHours:f2}")
              .AppendLine($"Salary per hour: {this.GetPaymentPerHour():f2}");

            return sb.ToString();
        }
    }
}