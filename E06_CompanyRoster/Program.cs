namespace E06_CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                var employeeInfo = Console.ReadLine().Split();
                AddEmployee(employeeInfo, employees);
            }

            var departments = employees
                .GroupBy(em => em.Department)
                .Select(gr => new   //gr => IGroupping<string, Employee> gr
                {
                    Name = gr.Key,   //department name for every group
                    AverageSalary = gr.Average(em => em.Salary), //averahe salary for every group
                    Employees = gr  //list of em (Employee in group) for every group
                })
                .OrderByDescending(gr => gr.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {departments.Name}");
            foreach (var emp in departments.Employees.OrderByDescending(em => em.Salary))
            {
                Console.WriteLine(emp.PrintEmployee());
            }
        }

        public static void AddEmployee(string[] employeeInfo, List<Employee> employees)
        {
            var name = employeeInfo[0];
            var salary = decimal.Parse(employeeInfo[1]);
            var position = employeeInfo[2];
            var department = employeeInfo[3];

            var employee = new Employee(name, salary, position, department);

            
            if (employeeInfo.Length == 5)
            {
                bool isAge = int.TryParse(employeeInfo[4], out int age);
                if (isAge)
                {
                    employee.Age = age;
                }
                else
                {
                    employee.Email = employeeInfo[4];
                }
            }
            else if (employeeInfo.Length == 6)
            {
                bool isAge = int.TryParse(employeeInfo[4], out int age);
                if (isAge)
                {
                    employee.Age = age;
                    employee.Email = employeeInfo[5];
                }
                else
                {
                    employee.Email = employeeInfo[4];
                    employee.Age = int.Parse(employeeInfo[5]);
                }
            }

            employees.Add(employee);
        }
    }
}
