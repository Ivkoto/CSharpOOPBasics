namespace E07_SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            var carCount = int.Parse(Console.ReadLine());
            string command;
            var cars = CarAppending(carCount);
            

            while ((command = Console.ReadLine()) != "End")
            {
                var commandInfo = command.Split(' ');
                var carModel = commandInfo[1];
                var distanceToDrive = int.Parse(commandInfo[2]);

                cars.Where(c => c.Model == carModel).FirstOrDefault().CarMovement(distanceToDrive);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.PrintCarInfo()); 
            }
        }

        private static List<Car> CarAppending(int carCount)
        {
            var cars = new List<Car>();
            for (int i = 0; i < carCount; i++)
            {
                var carInfo = Console.ReadLine().Split(' ');
                var model = carInfo[0];
                var fuelAmount = decimal.Parse(carInfo[1]);
                var fuelConsumption = decimal.Parse(carInfo[2]);

                var car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }
            return cars;
        }
    }
}
