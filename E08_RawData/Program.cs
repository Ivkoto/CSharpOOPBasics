namespace E08_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var carCount = int.Parse(Console.ReadLine());

            var cars = CarAppending(carCount);

            var command = Console.ReadLine();

            switch (command)
            {
                case "fragile":

                    var fragileCars = cars
                            .Where(c => c.Cargo.Type == "fragile" && 
                            c.Tires.Where(t => t.Pressure < 1).FirstOrDefault() != null)
                            .ToList();
                    foreach (var car in fragileCars)
                    {
                        Console.WriteLine(car.Model);
                    }
                    
                    break;
                case "flamable":
                    var flamableCars = cars
                        .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                        .ToList();
                    foreach (var car in flamableCars)
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
                default:
                    break;
            }
        }

        private static List<Car> CarAppending(int carCount)
        {
            var cars = new List<Car>();

            for (int i = 0; i < carCount; i++)
            {
                var carInfo = Console.ReadLine().Split(' ');

                var engin = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                var cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
                var tires = new Tire[]
                {
                    new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                    new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                    new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                    new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]))
                };
                                
                cars.Add(new Car(carInfo[0], engin, cargo, tires));
            }

            return cars;
        }
    }
}
