using System;
using System.Collections.Generic;

namespace HumanNinjaSamurai.Models
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.Health < 50)
            {
                target.Health = 0;
                Console.WriteLine($"Samurai {Name} has dealt a deadly blow to {target.Name}! Fatality.");
            }
            return target.Health;
        }

        public int Meditate()
        {
            Health = 200;
            Console.WriteLine($"Samurai {Name} has gone into deep meditation and has literally healed himself back to full health! No senzu beans needed!");
            return Health;
        }
    }
}