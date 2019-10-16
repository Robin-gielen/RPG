using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Environment
{
    class Rock : Obstacles
    {
        public Rock(string name) : base (name, 2)
        {
            Console.WriteLine("A rock has been initialized with the name {0} \n", name);
        }
    }
}
