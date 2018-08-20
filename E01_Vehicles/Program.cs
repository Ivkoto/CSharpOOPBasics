using E01_Vehicles.Models;
using System;

namespace E01_Vehicles
{
    public class Program
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicles car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicles truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            var commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var vehicleType = command[1];
                if (vehicleType == "Car")
                {
                    ExecuteActions(car, command[0], double.Parse(command[2]));
                }
                else if (vehicleType == "Truck")
                {
                    ExecuteActions(truck, command[0], double.Parse(command[2]));
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ExecuteActions(Vehicles vehicle, string command, double parameter)
        {
            switch (command)
            {
                case "Drive":
                    var result = vehicle.TryDrive(parameter);
                    Console.WriteLine(result);
                    break;
                case "Refuel":
                    vehicle.Refuel(parameter);
                    break;
                default:
                    break;
            }
        }
    }
}