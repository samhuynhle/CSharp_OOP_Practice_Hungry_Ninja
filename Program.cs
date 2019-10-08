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
            SpiceHound robby = new SpiceHound();
            SweetTooth bobby = new SweetTooth();
            while(!robby.IsFull)
            {
                robby.Consume(worldclass.Serve());
                if(robby.IsFull)
                {
                    robby.Consume(worldclass.Serve());
                }
            }
            while(!bobby.IsFull)
            {
                bobby.Consume(worldclass.Serve());
                if(bobby.IsFull)
                {
                    bobby.Consume(worldclass.Serve());
                }
            }
            if(bobby.ConsumptionHistory.Count > robby.ConsumptionHistory.Count)
            {
                System.Console.WriteLine($"SweetTooth at more food! A total of {bobby.ConsumptionHistory.Count}");
            }
            else
            {
                System.Console.WriteLine($"SpiceHound at more food! A total of {robby.ConsumptionHistory.Count}");
            }
        }
    }
}
