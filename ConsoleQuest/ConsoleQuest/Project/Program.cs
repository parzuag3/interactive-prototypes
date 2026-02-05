using System;
using System.Collections.Generic;

namespace ConsoleQuest
{
    class Program
    {
        private List<AdventureEvent> events = new List<AdventureEvent>();


        static void Main(string[] args)
        {
            Tavern tavern = new Tavern();
            Hero player = tavern.GetHero();
            while (player != null)
            {
                Adventure adv = new Adventure(player);
                adv.LoadEvents("events.txt");

                adv.Begin();
                while (!adv.done)
                {
                    adv.TryEvent();
                }

                player = tavern.GetHero();
            }

        }
    }
}
