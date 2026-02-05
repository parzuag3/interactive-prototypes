using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleQuest
{
    class Adventure
    {
        List<AdventureEvent> events = new List<AdventureEvent>();

        Hero hero;

        public int gold = 0;
        public bool done = false;

        public Adventure(Hero newHero)
        {
            hero = newHero;
        }

        private bool IsEndOfFile(StreamReader reader)
        {
            while(true)
            {
                int peek = reader.Peek();
                if (peek <= -1)
                    return true;
                if ((char)peek != '#')
                    return false;

                reader.ReadLine();
            }
        }

        public void LoadEvents(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            if (reader == null)
                return;

            reader.ReadLine();  // version info

            while (!IsEndOfFile(reader))
            {
                AdventureEvent evt = new AdventureEvent();
                evt.Load(reader);
                AddEvent(evt);
            }
        }

        public void AddEvent(AdventureEvent newEvent)
        {
            events.Add(newEvent);
        }

        public AdventureEvent GetRandomEvent()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, events.Count);
            return events[index];
        }

        public void Begin()
        {
            done = false;
            Console.WriteLine(hero.name + " sets out on a new adventure!");
        }

        public void TryEvent()
        {
            Console.Clear();

            AdventureEvent evt = GetRandomEvent();

            evt.Start();

            bool eventDone = false;
            while (!eventDone)
            {

                string input;
                int choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine(hero.ToString());
                    Console.WriteLine();
                    Console.WriteLine(evt.GetDescription(hero));
                    Console.WriteLine(evt.GetChoices(hero));

                    input = Console.ReadLine();
                }
                while (!int.TryParse(input, out choice) || choice < 0 || choice > evt.GetNumChoices());

                if (choice == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(hero.name + "'s Inventory:");
                    hero.PrintInventory();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    eventDone = true;

                    evt.Choose(this, hero, choice);

                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();

                    if (hero.hitpoints <= 0 || evt.ShouldEndAdventure())
                    {
                        End();
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("Should " + hero.name + " continue forth?");
                            Console.WriteLine("1) Onward!");
                            Console.WriteLine("2) Back to the Tavern");

                            input = Console.ReadLine();
                        }
                        while (!int.TryParse(input, out choice) || choice < 1 || choice > 2);

                        if (choice == 2)
                            End();
                    }
                }
            }
        }

        private void End()
        {
            done = true;
            Console.WriteLine(hero.name + " collected " + gold + " gold on the adventure!");

            Console.WriteLine(hero.name + " wakes up refreshed in bed at the Tavern.");

            hero.gold += gold;
            gold = 0;

            Console.ReadLine();
        }
    }
}
