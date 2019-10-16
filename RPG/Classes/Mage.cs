using RPG.Comon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    class Mage : Characters, IMovable
    {
        public Mage(string name, int age, string profession) : base(name, age, profession, 9, 1)
        {
            Console.WriteLine("A Mage has been created at position [0:0] \n");
        }

        public override bool MoveIsValid(int x, int y)
        {
            if ((Math.Abs(X - x) < 2) && (Math.Abs(Y - y) < 2))
            {
                return true;
            }
            else
                return false;
        }
    }
}
