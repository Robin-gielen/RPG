using RPG.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Comon.Maps
{
    class Tile : IMovable
    {
        private int x;
        private int y;

        private Characters character = null;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Characters Character { get => character; set => character = value; }

        /// <summary>
        /// Default constructor, builds a [0,0] tile with nothing on it
        /// </summary>
        public Tile()
        {
            x = 0;
            y = 0;
        }

        public Tile(int x, int y)
        {
            X = x;
            Y = y; 
        }
        public Tile(int x, int y, Characters character)
        {
            X = x;
            Y = y;
            Character = character;
        }

        public void Move(int x, int y)
        {
            Console.WriteLine("A tile can't move like that !"); ;
        }

        public void MoveTo(int x, int y)
        {
            Console.WriteLine("A tile can't move like that !"); ;
        }

        public int[] Position()
        {
            return new int[2] { x, y };
        }

        /// <summary>
        /// Add a char on the tile
        /// </summary>
        /// <param name="character"></param>
        public void addCharacter(Characters character)
        {
            Character = character ?? throw new ArgumentNullException();
        }
        /// <summary>
        /// Remove the char from the tile
        /// </summary>
        public void removeCharacter()
        {
            if(Character != null)
                Character = null;
        }
    }
}
