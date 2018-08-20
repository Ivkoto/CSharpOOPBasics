namespace E11_PokemonTrainer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.name = name;
            this.badges = 0;
            this.Pokemons = pokemons;
        }

        public string Name
        {
            get { return this.name; }
        }
        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public int Badges
        {
            get { return this.badges; }
        }

        public void AddBadge()
        {
            this.badges++;
        }

        public void ClearDeathPokemons()
        {
            pokemons.RemoveAll(p => p.Health <= 0);
        }
    }
}
