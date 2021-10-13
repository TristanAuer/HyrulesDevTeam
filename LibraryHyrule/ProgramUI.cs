using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHyrule
{
    class ProgramUI
    {
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
        public enum Item { sword, bow, spear };
        public List<Item> inventory = new List<Item>();

        public static Room start = new Room("All the way back here huh.\n\n" +
            "Once again you can GO LEFT, RIGHT,and CENTER\n",
            new List<string> { "left", "right", "center" },
            new List<Item> { }
            );
        public static Room left = new Room("Nothing around but dust and walls. Theres only two paths.\n\n" +
            "You can GO UP, DOWN,or BACK\n",
            new List<string> { "up", "down", "start", "back" },
            new List<Item> { }
            );
        public static Room right = new Room("Blood and bodies everywhere. You look around and see broken weapons expect for one. A bright and dirty spear.\n\n" +
            "You can GO BACK or GRAB SPEAR\n",
            new List<string> { "start", "back" },
            new List<Item> { Item.spear});
        public static Room center = new Room("Once again like the rooms before, just absolutely cover with bodies. *Rattle nosies- Darker than normal, especially in the center, \n\n" +
            "a HUGE DARK FIGURE APPEARS\n\n" + 
            "You can GO START or ATTACK\n",
            new List<string> { "start", "back" },
            new List<Item> { }
            );
        public static Room up = new Room("Surprisingly organized, the area seems to be someones room. In the corner of your eye you see a bow.\n\n" +
            "You can GO BACK or GRAB BOW\n",
            new List<string> { "start", "back" },
            new List<Item> { Item.bow });
        public static Room down = new Room("Once again, like the rooms before; covered in bodies. Oddly enough a glimmer of light appears out of nowhere.\n\n" +
            $"Shinning brightly is a sword calling upon you, grab me, GRAB ME\n" +
            "You can GO BACK or GRAB SWORD\n",
            new List<string> { "start", "back" },
            new List<Item> {Item.sword });


        public class Room
        {
            public List<Item> Items { get; }
            public void RemoveItem(Item item)
            {
                if (Items.Contains(item))
                {
                    Items.Remove(item);
                }
            }
            public string Splash { get; }
            public List<string> Exits { get; }
            public Room(string splash, List<string> exits, List<Item> items)
            {
                Splash = splash;
                Exits = exits;
                Items = items;
            }
        }


    }
}
