using RPG.Comon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Environment
{
    public class Obstacles : IMovable
    {
        int x;
        int y;
        string name;
        int hps;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string Name { get => name; set => name = value; }
        public int Hps { get => hps; set => hps = value; }

        /// <summary>
        /// Initialize an object at position 0 with the given name
        /// </summary>
        /// <param name="name"></param>
        public Obstacles(string name, int hps)
        {
            x = 1;
            y = 1;
            Name = name;
            Hps = hps;
        }

        public virtual void Move(int x, int y)
        {
            if (MoveIsValid(x, y))
            {
                X += x;
                Y += y;
            }
            else
                Console.WriteLine("Le char n'a pas pu se deplacer");
        }

        public virtual void MoveTo(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual int[] Position()
        {
            return new int[2] { X, Y };
        }


        /// <summary>
        /// Change the hps of an obstacle, return true if the object is still alive or false if it is destroyed
        /// </summary>
        /// <param name="dmg"></param>
        /// <returns></returns>
        public bool TakeDmg(int dmg)
        {
            int temp = hps - dmg;
            if (temp > 0)
            {
                Hps = temp;
                Console.WriteLine("{0} took {1} damage!", Name, dmg);
                return true;
            }
            else
            {
                Console.WriteLine("{0} has been destroyed !", Name);
                return false;
            }
                
        }

        public virtual bool MoveIsValid(int x, int y)
        {
            if (Math.Abs(x) < 2 && Math.Abs(y) < 2)
            {
                return true;
            }
            else
                return false;
        }

        public virtual bool IsOnMap(int x, int y)
        {
            if (x < Const.MAX_X && y < Const.MAX_Y)
            {
                return true;
            }
            else return false;
        }
    }
}
