using System;
using System.Collections.Generic;
using System.Linq;

namespace E04_ShoppigSpree
{
    public class Program
    {
        public static void Main()
        {
            var people = new HashSet<Person>();
            var products = new HashSet<Product>();

            var allPeople = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var allProducts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (var pers in allPeople)
                {
                    var persArgs = pers.Split('=');
                    var person = new Person(persArgs[0], decimal.Parse(persArgs[1]));
                    people.Add(person);
                }

                foreach (var prod in allProducts)
                {
                    var prodArgs = prod.Split('=');
                    var product = new Product(prodArgs[0], decimal.Parse(prodArgs[1]));
                    products.Add(product);
                }

                string purchases;
                while ((purchases = Console.ReadLine()) != "END")
                {
                    var purchaseArgs = purchases.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var buyer = people.FirstOrDefault(b => b.Name == purchaseArgs[0]);
                    var curProduct = products.FirstOrDefault(p => p.Name == purchaseArgs[1]);
                    if (buyer.BuyingProduct(curProduct))
                    {
                        Console.WriteLine($"{buyer.Name} bought {curProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{buyer.Name} can't afford {curProduct.Name}");
                    }
                }

                foreach (var person in people)
                {
                    if (person.GetProducts().Any())
                    {
                        Console.WriteLine(person.ToString());                        
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}