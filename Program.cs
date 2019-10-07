using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ninja Buffet!");
            Buffet worldclass = new Buffet();
            Ninja robby = new Ninja();
            while(!robby.IsFull)
            {
                robby.Eat(worldclass.Serve());
            }
        }
    }
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Sushi", 100, false, false),
                new Food("Spicy Sushi", 100, true, false),
                new Food("Sweet Sushi", 100, false, true),
                new Food("Power Sushi", 200, false, false),
                new Food("Super Sushi", 500, true, true)
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count)];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public bool IsFull
        {
            get
            {
                if(this.calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public void Eat(Food item)
        {
            if(!IsFull)
            {
                FoodHistory.Add(item);
                calorieIntake += item.Calories;
                
                string flavor;
                if(item.IsSpicy && item.IsSweet)
                {
                    flavor = "spicy and sweet";
                }
                else if (item.IsSpicy && !item.IsSweet)
                {
                    flavor = "spicy";
                }
                else if (!item.IsSpicy && item.IsSweet)
                {
                    flavor = "sweet";
                }
                else
                {
                    flavor = "bland";
                }
                System.Console.WriteLine($"Consumed: {item.Name}, which was {flavor}!");
                System.Console.WriteLine($"Current Calorie Intake Totals: {calorieIntake}");
            }
            else {
                System.Console.WriteLine("Ninja can't eat anymore!");
            }
        }
    }
}
