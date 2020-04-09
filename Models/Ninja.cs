using System;
using System.Collections.Generic;

namespace HumanNinjaSamurai.Models
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int damage = 5 * Dexterity;
            target.Health -= damage;
            Console.WriteLine($"Ninja {Name} has dealt {damage} damage points to {target.Name}!");
            Random extraDamage = new Random();

            if(extraDamage.Next(1,101) <= 20)
            {
                target.Health -= 10;
                Console.WriteLine($"Ninja {Name}'s technique has dealt an extra 10 damage points to {target.Name}!");
            }

            return target.Health;
        }

        public int Steal(Human target)
        {
            int steal = 5;
            target.Health -= steal;
            Health += steal;
            Console.WriteLine($"Ninja {Name} has stolen {steal} points from {target.Name}'s health..Sneaky!");
            return target.Health;
        }

    }
}