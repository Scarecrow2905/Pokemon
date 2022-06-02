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
        public bool Gender { get; set; }
        public List<Pokemon> PokemonList { get; set; }
        //public List<Inventory> InventoryList { get; set; }


        public Player(string name, bool gender)
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

        // Methods relatert til Player


        //dialog color
        public static void x()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Player dialog color
        public static void z()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public static bool createPlayerGender()
        {

            var gender = Console.ReadLine();
            if (gender == "boy")
            {
                x();
                Console.WriteLine("So you're a boy? ");
                Console.ReadKey();
                return true;
            }
            if (gender == "girl")
            {
                x();
                Console.WriteLine("So you're a girl? ");
                Console.ReadKey();
                return true;
            }
            else if (gender == "non-binary")
            {
                x();
                Console.WriteLine("So you're are genderless?");
                return true;
            }
            else
            {
                startGame();
                return false;
            }
        }

        public static string createPlayerName(Player name)
        {
            name = Console.ReadLine();
            return name;
        }


        public static void startGame()
        {
            x();
            Console.WriteLine("Hello there! Welcome to the world of Pokémon! My name is Oak! People call me the Pokémon Prof!");
            Console.ReadKey();
            Console.WriteLine("I study pokemon. \n but first one thing. \n Are you a boy or a girl?");

            z();
            createPlayerGender();

            x();
            Console.WriteLine("");
            Console.WriteLine("First, what is your name?");
            z();
            createPlayerName(name);
            Console.ReadLine();
            x();
            Console.WriteLine($"Right! So your name is {Player.name}! ");
            //var player = new Player(name);
            
        }


    }

        
}
