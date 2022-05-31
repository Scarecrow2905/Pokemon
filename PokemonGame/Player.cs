using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Player
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<Pokemon> PokemonList { get; set; }
        //public List<Inventory> InventoryList { get; set; }


        public Player(string name, string gender)
        {
            Name = name;
            Gender = gender;
            PokemonList = new List<Pokemon>(2);
            PokemonList.Add(new Pokemon("Charmander", "Fire", "Male", 100, 30, 1, 0));
            PokemonList.Add(new Pokemon("Ghastly", "Ghost", "Male", 100, 30, 1, 0));
            PokemonList.Add(new Pokemon("Onyx", "Rock", "Male", 100, 30, 1, 0));
            //PokemonList = pokemonList;
            //InventoryList = inventoryList;
        }
    }
}
