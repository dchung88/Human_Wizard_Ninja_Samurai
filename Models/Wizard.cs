using System;
using System.Collections.Generic;

namespace HumanNinjaSamurai.Models
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            health = 50;
            Intelligence = 25;
        }

        public override int Attack(Human target)
        {
            int damage = 5 * Intelligence;
            target.Health -= damage;
            Health += damage;
            Console.WriteLine($"{Name} has attacked {target.Name} for {damage} damage points to health!");
            Console.WriteLine($"{damage} health points have been added to {Name}'s health!");
            return target.Health;
        }

        public int Heal(Human target)
        {
            int healTarget  = 10 * Intelligence;
            target.Health += healTarget;
            Console.WriteLine($"{Name} has healed {target.Name} for {healTarget} health points to health!");
            return target.Health;
        }

    }

}