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
        }
    }
}
