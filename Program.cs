using System;
using System.Collections.Generic;
using HumanNinjaSamurai.Models;

namespace HumanNinjaSamurai
{
    class Program
    {   
        static void Main(string[] args)
        {
            Human James = new Human("James");
            Wizard Merlin = new Wizard("Merlin");
            Merlin.Attack(James);
            Merlin.Heal(James);
            Ninja Michaelangelo = new Ninja("Michaelangelo");
            Michaelangelo.Attack(Merlin);
            Michaelangelo.Steal(Merlin);
            Samurai Jack = new Samurai("Jack");
            Jack.Attack(Michaelangelo);
            Jack.Meditate();
            James.Attack(Jack);
        }
    }
}
