using System;

namespace hungry_ninja
{
    class Drink : IConsumable
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        public bool IsSpicy {get; set;}
        public bool IsSweet {get; set;}
        public string GetInfo()
        {
            return $"{Name} (Drink). Calories: {Calories}. Spicy? {IsSpicy}, Sweet? {IsSweet}";
        }
        public Drink (string name, int calories, bool isSpicy)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = true;
        }
    }
}