using RPG.Classes;
using RPG.Comon;
using RPG.Environment;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static ManualResetEvent _quitEvent = new ManualResetEvent(false);
        

        static void Main(string[] args)
        {
            Map map = new Map();

            Console.CancelKeyPress += (sender, eArgs) => {
                _quitEvent.Set();
                eArgs.Cancel = true;
            };
            
            string TempName;
            int TempAge;
            string TempClass;
            //string TempObj;
            //string TempObjHPs;

            bool exit = false;

            while (!exit)
            {
                Console.Write("What do you want to do ? \nEnter help for help");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "help":
                        Console.WriteLine("CreateChar to create a char \nCreateObj to create an object \nMoveChar ro move a char \nAtkChar to attack with a char");
                        break;

                    case "CreateChar":
                        Console.WriteLine("Enter your char name :");
                        TempName = Console.ReadLine();
                        Console.WriteLine("Enter your char Age :");
                        TempAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your char Class :");
                        TempClass = Console.ReadLine();
                        if (string.Equals(TempClass, "Archer"))
                        {
                            Characters tempArcher = new Archer(TempName, TempAge, TempClass);
                            map.addChar(tempArcher);
                        }
                        else
                        {
                            Characters tempMage = new Mage(TempName, TempAge, TempClass);
                            map.addChar(tempMage);
                        }

                        break;
                    case "CreateObj":
                        break;
                    case "MoveChar":
                        break;
                    case "AtkChar":
                        break;
                    case "Exit":
                        exit = true;
                        break;
                }
            }
            
            

            //Initialization of chars
            //Characters archer = new Mage("Edge", 150, "Archer", 9, 2);

            //Initialization of obstacles 
            //Obstacles rock1 = new Rock("rock1", 2);

            //Initialization of the map
            //Map map = new Map();
            //map.addChar(archer);
            //map.addObstacle(rock1);
            //map.listAll();



            _quitEvent.WaitOne();
            //System.Threading.Thread.Sleep(10000);
        }
    }
}
