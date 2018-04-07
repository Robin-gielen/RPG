using RPG.Comon;
using System;

namespace RPG.Classes
{
    class Archer : Characters
    {
        public Archer(string name, int age, string profession, int hps, int dmg) : base(name, age, profession, hps, dmg)   
        {
            Console.WriteLine("An archer has been created at position [0:0] \n");
        }
    }
}
