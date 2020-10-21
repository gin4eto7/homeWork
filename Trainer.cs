using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            CollectionOfPokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> CollectionOfPokemons { get; set; }
    }
}
