using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHyrule
{
    public class Class1
    {
        //Zelda inspired text based adventure game
        //Introduction
        
        public void Run()
        {
            Console.WriteLine("What is you're name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("You wake up in a cave, surprisingly bright; confused to everything you start to explore. One thing you are sure about is you're" +
                "name,\n" +
                $"{playerName}");
            
            bool alive = true;
            while (alive)
            {
                string command = Console.ReadLine().ToLower();
                Console.Clear();
                
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
