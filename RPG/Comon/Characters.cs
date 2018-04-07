using System;

namespace RPG.Comon
{
    public class Characters : IMovable
    {
        string name;
        private int age;
        private string profession;
        private int hps;
        private int damage;
        private int x;
        private int y;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }
        public int Hps { get => hps; set => hps = value; }
        public int Damage { get => damage; set => damage = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Characters(string name, int age, string profession, int hps, int dmg)
        {
            Name = name;
            Age = age;
            Profession = profession;
            Hps = hps;
            Damage = dmg;
        }

        public virtual void Move(int x, int y)
        {
            if(MoveIsValid(x, y))
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
            return new int[2] {X, Y};
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

        /// <summary>
        /// Deal dmg number of damage on whatever is on the tile at position x:y
        /// </summary>
        /// <param name="dmg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void BasicAtk(int dmg, int x, int y, Map map)
        {

        }
    }
}
