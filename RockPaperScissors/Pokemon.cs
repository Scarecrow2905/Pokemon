using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public int Health { get; set; }
        public int AttackPoints { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        //public List<Inventory> InventoryList { get; set; }

        public Pokemon(string name, string type, string gender, int health, int attackPoints, int level, int experience)
        {
            Name = name;
            Type = type;
            Gender = gender;
            Health = health;
            AttackPoints = attackPoints;
            Level = level;
            Experience = experience;
            //InventoryList = inventoryList;
        }

        public void Fight(Pokemon Pokemon)
        {
            Console.WriteLine($"{Pokemon.name}"
        }
    }
}
