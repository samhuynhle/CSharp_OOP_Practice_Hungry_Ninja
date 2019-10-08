using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Sushi", 100, false, false),
                new Food("Spicy Sushi", 100, true, false),
                new Food("Sweet Sushi", 100, false, true),
                new Food("Power Sushi", 200, false, false),
                new Food("Super Sushi", 500, true, true),
                new Drink("Sweet Water", 50, false),
                new Drink("Coke", 500, false),
                new Drink("Spicy Sweet Water", 50, true)
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count)];
        }
    }
}