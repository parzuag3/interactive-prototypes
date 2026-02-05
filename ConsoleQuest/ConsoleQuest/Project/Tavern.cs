using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleQuest
{
    class Tavern
    {
        int gold = 0;
        public Hero[] heroes = new Hero[5];

        public Tavern()
        {
            heroes[0] = new Hero();

            Load();
        }

        public void HealHeroes()
        {
            for (int i = 0; i < heroes.Length; ++i)
            {
                if (heroes[i] != null)
                    heroes[i].hitpoints = heroes[i].maxHitpoints;
            }
        }

        public Hero GetHero()
        {
            // Get heroes ready for the next adventure
            HealHeroes();
            Save();

            // Display screen to choose a hero
            int choice;
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Tavern.  Choose a Hero.");
                for (int i = 0; i < heroes.Length; ++i)
                {
                    if(heroes[i] != null)
                        Console.WriteLine((i + 1) + ") " + heroes[i].ToString());

                }
                Console.WriteLine("6) Quit the game");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out choice) || choice <= 0 || choice >= 7 || (choice != 6 && heroes[choice-1] == null));
            
            if(choice == 6)
                return null;
            return heroes[choice-1];
        }

        public void Load()
        {
            if (!File.Exists("save.txt"))
                return;

            FileStream file = File.OpenRead("save.txt");
            StreamReader reader = new StreamReader(file);

            string line;
            line = reader.ReadLine();  // Version
            line = reader.ReadLine();  // gold
            gold = int.Parse(line);


            int i = 0;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();  // Next Hero
                if (line == "null")
                {
                    continue;
                }
                else if (line == "Hero")
                {
                    heroes[i] = new Hero();
                }


                heroes[i].Load(reader);
            }


            reader.Close();
            file.Close();
        }

        public void Save()
        {
            FileStream file = File.Create("save.txt");
            StreamWriter writer = new StreamWriter(file);

            writer.WriteLine("Save file format version 1.1.0");
            writer.WriteLine(gold);

            for (int i = 0; i < heroes.Length; ++i)
            {
                if (heroes[i] == null)
                    writer.WriteLine("null");
                else
                    heroes[i].Save(writer);
            }

            writer.Close();
            file.Close();
        }
    }
}
