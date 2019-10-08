using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class SpiceHound: Ninja
    {
        private bool isFull;

        public SpiceHound()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
            isFull = false;
        }
        public override bool IsFull
        {
            get
            {
                return isFull;
            }
        }
        public override void Consume(IConsumable item)
        {
            if(!IsFull)
            {
                calorieIntake += item.Calories;
                System.Console.WriteLine($"SpiceHound consumed {item.Name} and gained {item.Calories} calories!");
                if(item.IsSpicy)
                {
                    calorieIntake += 5;
                    System.Console.WriteLine($"{item.Name} was spicy! So SpiceHound gained addittional 5 calories!");
                }
                ConsumptionHistory.Add(item);
                item.GetInfo();
                if(calorieIntake > 1500)
                {
                    isFull = true;
                }
            }
            else
            {
                System.Console.WriteLine("SpiceHound can't eat any more!");
            }
        }
    }
}
