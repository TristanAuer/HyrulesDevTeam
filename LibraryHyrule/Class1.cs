using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryHyrule.ProgramUI;

namespace LibraryHyrule
{
    public class Class1
    {
        //Zelda inspired text based adventure game
        //Introduction
        Dictionary<string, Room> Rooms = new Dictionary<string, Room>
        {
            {"start", start },
            {"back", start },
            {"left", left },
            {"right", right },
            {"center", center },
            {"straight", center },
            {"up", up },
            {"down", down },
        };
        List<Item> inventory = new List<Item>();

      
        

        public void Run()
        {
            
            Console.WriteLine("What is you're name?");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You wake up in a cave, surprisingly bright; confused to everything you start to explore. One thing you are sure about is you're" + " " +
               $"name, {playerName}");
            
            Room currentRoom = start;
            Console.WriteLine("You stand up to a fork and you three options are LEFT, CENTER, or RIGHT");
            
        bool alive = true;
            while (alive)
            {

                Console.Clear();
                Console.WriteLine(currentRoom.Splash);
                string command = Console.ReadLine().ToLower();
                
                if (command.StartsWith("go ") || command.StartsWith("exit"))
                {
                    bool foundExit = false;
                    foreach (string exit in currentRoom.Exits)
                    {
                        if (command.Contains(exit) &&
                           Rooms.ContainsKey(exit))
                        {
                            currentRoom = Rooms[exit];
                            foundExit = true;
                            break;

                        }

                    }
                    if(foundExit)
                    {
                        
                        Console.WriteLine("Going...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Uh... Go where?");
                        Console.ReadKey();
                    }

                }
                else if (command.StartsWith("get ") || command.StartsWith("take") || command.StartsWith("grab"))
                {
                    bool foundItem = false;
                    foreach (Item item in currentRoom.Items)
                    {   

                        if (command.Contains(item.ToString()))
                            {
                            Console.Clear();
                            Console.WriteLine($"You pick up the {item}." +" "+ "press any key to continue...");
                            
                            currentRoom.RemoveItem(item);
                            inventory.Add(item);
                            foundItem = true;
                            Console.ReadKey();
                            break;
                            }
                    }
                    if (foundItem)
                    {
                       
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("What was I grabbing?");
                        Console.ReadKey();
                    }
                }
                else if (command.StartsWith("use ") || command.StartsWith("attack"))
                {
                    
                }
                else
                {
                    Console.WriteLine("Huh?");
                }

            }

        }
        
        //Player name method
        //takes player input and saves name
        //pick your weapon
        //list player weapon options and saves input
        //Room method
        //items
        //Exit and enter method
        //skeleton in path must fight
        //ask for name of skeleton
        //Introduction
        //bool statement to see if you can beat the skeleton
        //true/false if the skeleton beat do not respawn.
        //inventory
        //save function
        //finish
        //if you have key you can leave
    }
}
