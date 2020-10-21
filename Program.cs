using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pesho Charizard Fire 100
            Dictionary<string, Trainer> collectionOfTrainers = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] info = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName);

                if(!collectionOfTrainers.ContainsKey(trainerName))
                {
                    collectionOfTrainers.Add(trainerName, new Trainer(pokemonName));
                }

                collectionOfTrainers[trainerName].CollectionOfPokemons.Add(pokemon);

                input = Console.ReadLine();
            }


            string command = Console.ReadLine();

            while (command != "End")
            {

                foreach (var currTrainer in collectionOfTrainers)
                {
                    if(currTrainer.Value.CollectionOfPokemons
                        .Any(x => x.Element == command))
                    {
                        currTrainer.Value.NumberOfBadges++;
                    }
                    else
                    {

                        foreach (var pokemon in currTrainer.Value.CollectionOfPokemons)
                        {
                            pokemon.Health -= 10;
                        }

                       currTrainer.Value.CollectionOfPokemons
                            .RemoveAll(x => x.Health <= 0);
                    }
                    
                }


                command = Console.ReadLine();
            }

            foreach (var trainer in collectionOfTrainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} { trainer.Value.CollectionOfPokemons.Count}");
            }
        }
    }
}
