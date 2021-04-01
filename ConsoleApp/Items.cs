using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Items
    {
        public int Books { get; set; }
        public int Candy { get; set; }
        public int Cups { get; set; }
        public Items()
        {
            var randomizer = new Random();

            Books = randomizer.Next(40);

            Candy = randomizer.Next(40);

            Cups = randomizer.Next(40);
        }

    }
}
