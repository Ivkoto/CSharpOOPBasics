using E02_VehiclesExtension.Models;
using System;

namespace E02_VehiclesExtension
{
    public class Program
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicles car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicles truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            var busInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicles bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            var commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                try
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
                    else if (vehicleType == "Bus")
                    {
                        ExecuteActions(bus, command[0], double.Parse(command[2]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
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

                case "DriveEmpty":
                    var result2 = vehicle.TryDrive(parameter, false);
                    Console.WriteLine(result2);
                    break;

                default:
                    break;
            }
        }
    }
}