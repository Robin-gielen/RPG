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
            string TempObj;
            //string TempObjHPs;

            bool exit = false;

            while (!exit)
            {
                Console.Write("Here's the game board state");
                Console.Write("Characters and objects in play :\n" );
                map.listAll();
                Console.Write("\nWhat do you want to do ? \nEnter help for help\n1)CreateChar\n2)CreateObj\n3)MoveChar\n4)CharAtk\n5)Help\n6)Exit\n");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "5": //Help
                        Console.Clear();
                        Console.WriteLine("CreateChar to create a char \nCreateObj to create an object \nMoveChar ro move a char \nAtkChar to attack with a char\n");
                        break;

                    case "1": //CreateChar
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
                        Console.Clear();
                        break;
                    case "2": //CreateObj
                        Console.WriteLine("What kind of object do you want to create ?\n1)Rock\n2)Other");
                        TempObj = Console.ReadLine();
                        bool rockCreated = false;
                        while (!rockCreated)
                        {
                            switch (TempObj)
                            {
                                case "1":
                                    Console.WriteLine("Name your rock :");
                                    string tempRockName = Console.ReadLine();
                                    Obstacles tempRock = new Rock(tempRockName);
                                    map.addObstacle(tempRock);
                                    rockCreated = true;
                                    break;
                                case "2":
                                    break;
                                default :
                                    break;

                            }
                        }
                        Console.Clear();
                        break;
                    case "3": //MoveChar
                        Console.Write("What Character would you like to move ?\n");
                        string[] chars = map.listCharacters();
                        for (int i = 0; i < chars.Length; i++)
                        {
                            Console.Write(i + ")" + chars[i] + "\n");
                        }
                        string userInput = Console.ReadLine();
                        foreach (string charToMove in chars)
                        {
                            if (string.Equals(userInput, charToMove)) {
                                Console.Write("Where would you like to move it ?\n");

                                Console.Write("Enter X coordinate :\n");
                                bool xNotGiven = true;
                                while (xNotGiven)
                                {
                                    int moveX = 0;
                                    string tempX = Console.ReadLine();
                                    if (Int32.TryParse(tempX, out moveX))
                                    {
                                        xNotGiven = false;
                                    }
                                }

                                Console.Write("Enter Y coordinate :\n");
                                bool yNotGiven = true;
                                while (yNotGiven)
                                {
                                    int moveY = 0;
                                    string tempY = Console.ReadLine();
                                    if (Int32.TryParse(tempY, out moveY))
                                    {
                                        yNotGiven = false;
                                    }
                                }
                                
                            }
                        }

                        break;
                    case "4": //CharAtk
                        Console.Clear();
                        break;
                    case "6": //Exit
                        Console.Clear();
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
