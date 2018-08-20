
namespace E11_PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main( )
        {
            
            List<Trainer> trainers = GetTrainersAndPokemons();

            PlayTheGame(trainers);

            PrintTrainers(trainers);

        }

        private static void PrintTrainers(List<Trainer> trainers)
        {
            foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void PlayTheGame(List<Trainer> trainers)
        {
            string command;

            while ((command = Console.ReadLine().Trim()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Where(p => p.Element == command).FirstOrDefault() == null)
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.ReduseHealth();
                        }                        
                    }
                    else
                    {
                        trainer.AddBadge();
                    }
                    trainer.ClearDeathPokemons();
                }
            }
        }

        private static List<Trainer> GetTrainersAndPokemons()
        {
            List<Trainer> trainers = new List<Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var inputValues = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var trainer = new Trainer(inputValues[0], new List<Pokemon>());
                var pokemon = new Pokemon(inputValues[1], inputValues[2], int.Parse(inputValues[3]));
                if (trainers.Where(t => t.Name == trainer.Name).Count() == 1)
                {
                    trainers.Where(t => t.Name == trainer.Name).FirstOrDefault().Pokemons.Add(pokemon);
                }
                else
                {
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
            }

            return trainers;
        }
    }
}
