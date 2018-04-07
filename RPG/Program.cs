using RPG.Classes;
using RPG.Comon;
using RPG.Environment;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Initialization of chars
            Characters archer = new Mage("Edge", 150, "Archer", 9, 2);

            //Initialization of obstacles 
            Obstacles rock1 = new Rock("rock1", 2);

            //Initialization of the map
            Map map = new Map();
            map.addChar(archer);
            map.addObstacle(rock1);
            map.listAll();

        }
    }
}
