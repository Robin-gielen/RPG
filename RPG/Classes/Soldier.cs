using RPG.Comon;
using System;

namespace RPG.Classes
{
    class Soldier : Characters, IMovable
    {
        public Soldier(string name, int age, string profession, int hps, int dmg) : base(name, age, profession, hps, dmg)
        {
            Console.WriteLine("A soldier has been created at position [0:0] \n");
        }

        public override bool MoveIsValid(int x, int y)
        {
            if ((Math.Abs(X - x) < 3) && (Math.Abs(Y - y) < 3))
            {
                return true;
            }
            else
                return false;
        }
    }
}
