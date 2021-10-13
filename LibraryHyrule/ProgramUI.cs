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
            new List<string> { "left", "right", "center" });
        public static Room left = new Room("All the way back here huh.\n\n" +
            "You can GO LEFT, RIGHT,and CENTER\n",
            new List<string> { "up", "down", "start" });
        public static Room right = new Room("All the way back here huh.\n\n" +
            "You can GO LEFT, RIGHT,and CENTER\n",
            new List<string> { "start" },
            new List<Item> { Item.spear});
        public static Room center = new Room("All the way back here huh.\n\n" +
            "You can GO LEFT, RIGHT,and CENTER\n",
            new List<string> { "start" });
        public static Room up = new Room("All the way back here huh.\n\n" +
            "You can GO LEFT, RIGHT,and CENTER\n",
            new List<string> { "start" },
            new List<Item> { Item.bow });
        public static Room down = new Room("All the way back here huh.\n\n" +
            "You can GO LEFT, RIGHT,and CENTER\n",
            new List<string> { "start" },
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

        public class Weapons
        {
            public List<string> Weapon { get; }
            public Weapons(List<string> weapons)
            {
                Weapon = weapons;
            }
        }
    }
}
