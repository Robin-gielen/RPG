using RPG.Comon;
using System;

namespace RPG.Classes
{
    class Archer : Characters
    {
        public Archer(string name, int age, string profession) : base(name, age, profession, 8, 2)   
        {
            Console.WriteLine("An archer has been created at position [0:0] \n");
        }
    }
}
