using E05_PizzaCalories.Models;
using System;

namespace E05_PizzaCalories
{
    public class Program
    {
        public static void Main()
        {
            string input;
            try
            {
                while ((input = Console.ReadLine()) != "END")
                {
                    var args = input.Split(' ');

                    switch (args[0])
                    {
                        case "Dough":
                            var dough = new Dough(args[1], args[2], double.Parse(args[3]));
                            Console.WriteLine($"{dough.CalculateCalories():f2}");
                            break;

                        case "Topping":
                            var topping = new Topping(args[1], double.Parse(args[2]));
                            Console.WriteLine($"{topping.CalculateCalories():f2}");
                            break;

                        case "Pizza":
                            MakePizza(args);
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void MakePizza(string[] args)
        {
            var toppingsCount = int.Parse(args[2]);
            var pizza = new Pizza(args[1], toppingsCount);
            var doughArgs = Console.ReadLine().Split(' ');
            var dough = new Dough(doughArgs[1], doughArgs[2], double.Parse(doughArgs[3]));
            pizza.AddDough(dough);

            for (int i = 0; i < toppingsCount; i++)
            {
                var toppingArgs = Console.ReadLine().Split(' ');
                var topping = new Topping(toppingArgs[1], double.Parse(toppingArgs[2]));
                pizza.AddToppings(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.CalculateTotalCalories():f2} Calories.");
        }
    }
}