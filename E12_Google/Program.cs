using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E12_Google
{
    public class Program
    {
        public static void Main()
        {
            Queue<Person> persons = new Queue<Person>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                var commands = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var pName = commands[0];
                var pProp = commands[1];

                var curPerson = persons.FirstOrDefault(p => p.Name == pName);

                if (curPerson == null)
                {
                    curPerson = new Person(pName);
                    persons.Enqueue(curPerson);
                }

                FillData(commands, curPerson);
            }

            PrintPerson(persons);
        }

        private static void PrintPerson(Queue<Person> persons)
        {
            var personName = Console.ReadLine().Trim();
            Console.WriteLine(persons.FirstOrDefault(p => p.Name == personName).ToString()); 
        }

        private static void FillData(string[] commands, Person curPerson)
        {
            switch (commands[1])
            {
                case "company":
                    var company = new Company(commands[2], commands[3], decimal.Parse(commands[4]));
                    curPerson.Company = company;
                    break;
                case "pokemon":
                    var pokemon = new Pokemon(commands[2], commands[3]);
                    curPerson.AddInCollection(pokemon);
                    break;
                case "parents":
                    var parent = new Parent(commands[2], commands[3]);
                    curPerson.AddInCollection(parent);
                    break;
                case "children":
                    var child = new Children(commands[2], commands[3]);
                    curPerson.AddInCollection(child);
                    break;
                case "car":
                    var car = new Car(commands[2], int.Parse(commands[3]));
                    curPerson.Car = car;
                    break;
                default:
                    break;
            }
        }
    }
}