using System;
using System.Collections.Generic;

namespace HumanNinjaSamurai.Models
{
    class Human
    {
        public string Name {get;set;}
        public int Strength {get;set;}
        public int Intelligence {get;set;}
        public int Dexterity {get;set;}
        protected int health {get;set;}
        private int mainHealth {get;set;}
        public int Health
        {
            set {}
            get { return health; }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
            int fullHealth = health;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }
        
        public virtual int Attack(Human target)
        {
            int Damage = 5 * Strength;
            target.health -= Damage;
            Console.WriteLine($"{Name} has attacked {target.Name} for {Damage} damage points!");
            return target.health;
        }

    }
}