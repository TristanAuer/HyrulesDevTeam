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
            {"left", left },
            {"right", right },
            {"center", center },
            {"straight", center },
            {"up", up },
            {"down", down },
        };
        public List<Item> Inventory = new List<Item>();
        public void Run()
        {

            Console.WriteLine("What is you're name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("You wake up in a cave, surprisingly bright; confused to everything you start to explore. One thing you are sure about is you're" +
                "name,\n" +
                $"{playerName}");
            Console.ReadKey();
            
            bool alive = true;
            while (alive)
            {
                Room currentRoom = start;
                string command = Console.ReadLine().ToLower();
                Console.Clear();
                if (command.StartsWith("go ") || command.StartsWith("exit"))
                {
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
                    if (!foundExit)
                    {
                        Console.WriteLine("Uh... Go where?");
                    }

                }
                else if (command.StartsWith("get ") || command.StartsWith("take") || command.StartsWith("grab"))
                {
                    bool foundItem = false;
                    foreach (Item item in currentRoom.Items)
                    {   

                        if (!foundItem && command.Contains(item.ToString()))
                            {  

                            Console.WriteLine($"you found a {item}." + "[ress any key to continue...");
                            
                            currentRoom.RemoveItem(item);
                            inventory.Add(item);
                            foundItem = true;
                            Console.ReadKey();
                            
                            }
                    }
                    Console.WriteLine("I don't know what you're talking about.");
                }
                else if (command.StartsWith("use ") || command.StartsWith("activate"))
                {
                    Console.WriteLine("I doubt you know how.");
                }
                else
                {
                    Console.WriteLine("*BUUUUUURP What?");
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
