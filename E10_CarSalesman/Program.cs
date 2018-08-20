namespace E10_CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var engines = GetEngines();

            var cars = GetCars(engines);

            while (cars.Count != 0)
            {
                Console.WriteLine(cars.Dequeue());
            }
        }

        private static Queue<Car> GetCars(HashSet<Engine> engines)
        {
            var carCount = int.Parse(Console.ReadLine());

            Queue<Car> cars = new Queue<Car>(carCount);

            for (int j = 0; j < carCount; j++)
            {
                var carValues = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentCar = new Car(carValues[0], engines.Where(e => e.Model == carValues[1]).FirstOrDefault());

                if (carValues.Length > 2)
                {
                    bool isWeight = int.TryParse(carValues[2], out int weight);

                    if (isWeight)
                    {
                        currentCar.Weight = weight;
                    }
                    else
                    {
                        currentCar.Color = carValues[2];
                    }
                    if (carValues.Length > 3)
                    {
                        if (isWeight)
                        {
                            currentCar.Color = carValues[3];
                        }
                        else
                        {
                            currentCar.Weight = int.Parse(carValues[3]);
                        }
                    }
                }

                cars.Enqueue(currentCar);
            }

            return cars;
        }

        private static HashSet<Engine> GetEngines()
        {
            var engineCount = int.Parse(Console.ReadLine());
            var engines = new HashSet<Engine>();

            for (int i = 0; i < engineCount; i++)
            {
                var enginevalues = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentEngin = new Engine(enginevalues[0], int.Parse(enginevalues[1]));

                if (enginevalues.Length > 2)
                {
                    bool isDisplacement = int.TryParse(enginevalues[2], out int displacement);
                    if (isDisplacement)
                    {
                        currentEngin.Displacement = displacement;
                    }
                    else
                    {
                        currentEngin.Efficiency = enginevalues[2];
                    }
                    if (enginevalues.Length > 3)
                    {
                        if (isDisplacement)
                        {
                            currentEngin.Efficiency = enginevalues[3];
                        }
                        else
                        {
                            currentEngin.Displacement = int.Parse(enginevalues[3]);
                        }
                    }
                }

                engines.Add(currentEngin);

            }

            return engines;
        }
    }
}
