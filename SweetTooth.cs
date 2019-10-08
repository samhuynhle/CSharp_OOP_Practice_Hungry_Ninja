using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class SweetTooth: Ninja
    {
        private bool isFull;
        public SweetTooth()
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
            if(IsFull)
            {
                System.Console.WriteLine("SweetTooth can't eat any more!");
            }
            else
            {
                calorieIntake += item.Calories;
                System.Console.WriteLine($"SweetTooth consumed {item.Name} and gained {item.Calories} calories!");
                if(item.IsSweet)
                {
                    calorieIntake += 10;
                    System.Console.WriteLine($"{item.Name} was sweet! So SweetTooth gained addittional 10 calories!");
                }
                item.GetInfo();
                ConsumptionHistory.Add(item);
                if(calorieIntake >= 1500)
                {
                    isFull = true;
                }
            }

        }
    }
}
