using RPG.Comon.Maps;
using RPG.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Comon
{
    public class Map
    {
        List<Tile> map = new List<Tile>();

        List<Characters> listChars = new List<Characters>();
        List<Obstacles> listObstacles = new List<Obstacles>();

        Dictionary<Characters, int[]> dicChars = new Dictionary<Characters, int[]>();
        Dictionary<Obstacles, int[]> dicObstacles = new Dictionary<Obstacles, int[]>();

        /// <summary>
        /// Initialize a map with one tile at position [0,0]
        /// </summary>
        public Map()
        {
            map.Add(new Tile(0, 0));
        }

        /// <summary>
        /// Add a char on the map
        /// </summary>
        /// <param name="character"></param>
        public void addChar(Characters character)
        {
            if(character == null)
            {
                throw new ArgumentNullException();
            }
            listChars.Add(character);
            dicChars.Add(character, new int[2] { character.X, character.Y});
        }

        /// <summary>
        /// Remove a char of the map
        /// </summary>
        /// <param name="character"></param>
        public void removeChar(Characters character)
        {
            if(character == null)
            {
                throw new ArgumentNullException();
            }
            if(listChars.Contains(character))
            {
                listChars.Remove(character);
                dicChars.Remove(character);
                Console.WriteLine("The character : " + character.Name + " has been removed");
            }
                
            else
                Console.WriteLine("This char doesn't exist");
        }

        /// <summary>
        /// Add an obstacle on the map
        /// </summary>
        /// <param name="obstacle"></param>
        public void addObstacle(Obstacles obstacle)
        {
            if(obstacle == null)
            {
                throw new ArgumentNullException();
            }
            listObstacles.Add(obstacle);
            dicObstacles.Add(obstacle, new int[2] { obstacle.X, obstacle.Y });
        }

        /// <summary>
        /// Remove an obstacle of the map
        /// </summary>
        /// <param name="obstacle"></param>
        public void removeObstacle(Obstacles obstacle)
        {
            if (obstacle == null)
            {
                throw new ArgumentNullException();
            }
            if (listObstacles.Contains(obstacle))
            {
                listObstacles.Remove(obstacle);
                dicObstacles.Remove(obstacle);
                Console.WriteLine("The obstacle : " + obstacle.GetType() + " has been removed");
            }
                
            else
                Console.WriteLine("This obstacle doesn't exist");
        }

        /// <summary>
        /// This method will print out all things that are on the map on the format : Name->Position
        /// </summary>
        public void listAll()
        {
            foreach (Characters character in dicChars.Keys)
            {
                Console.WriteLine("Char {0} is at position [{1}, {2}]", character.Name, character.Position()[0], character.Position()[1]);
                
            }
            foreach (Obstacles obstacle in dicObstacles.Keys)
            {
                Console.WriteLine("Obstacle {0}, is at position [{1}, {2}]", obstacle.Name, obstacle.Position()[0], obstacle.Position()[1]);
            }
        }

        /// <summary>
        /// This method will return a list containing the name of every character on the map
        /// </summary>
        public string[] listCharacters()
        {
            string[] listChars = new string[dicChars.Count()];
            int i = 0;
            foreach (Characters character in dicChars.Keys)
            {
                 listChars[i] = character.Name;
                i++;
            }
            return listChars;
        }
    }
}
