using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleQuest
{
    class Hero
    {
        public string name;
        public int hitpoints;
        public int maxHitpoints;

        public int level = 1;
        public int experience = 0;
        public int gold = 0;
        
        public List<string> inventory = new List<string>();


        public Hero()
        {
            name = "Jon";
            maxHitpoints = 5;
            hitpoints = maxHitpoints;

            name = "Kevin";
            maxHitpoints = 4;
            hitpoints = maxHitpoints;
        }

        public void TakeDamage(int amount)
        {
            hitpoints -= amount;
            if (hitpoints <= 0)
                hitpoints = 0;
        }

        public void GiveItem(string item)
        {
            inventory.Add(item);
        }

        public bool HasItem(string item)
        {
            for (int i = 0; i < inventory.Count; ++i)
            {
                if (inventory[i] == item)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return name + ": Level " + level + ", HP=" + maxHitpoints + ", Items:" + inventory.Count;
        }

        public void PrintInventory()
        {
            for (int i = 0; i < inventory.Count; ++i)
            {
                Console.WriteLine(inventory[i]);
            }
        }

        public void Load(StreamReader reader)
        {
            string line;
            line = reader.ReadLine();  // name
            name = line;

            line = reader.ReadLine();  // hitpoints
            hitpoints = int.Parse(line);
            line = reader.ReadLine();  // maxHitpoints
            maxHitpoints = int.Parse(line);
            line = reader.ReadLine();  // level
            level = int.Parse(line);
            line = reader.ReadLine();  // experience
            experience = int.Parse(line);
            line = reader.ReadLine();  // gold
            gold = int.Parse(line);

            int numItems = 0;
            line = reader.ReadLine();  // numItems
            numItems = int.Parse(line);
            for (int i = 0; i < numItems; ++i)
            {
                inventory.Add(reader.ReadLine());
            }

        }

        public void Save(StreamWriter writer)
        {
            writer.WriteLine("Hero");
            writer.WriteLine(name);
            writer.WriteLine(hitpoints);
            writer.WriteLine(maxHitpoints);
            writer.WriteLine(level);
            writer.WriteLine(experience);
            writer.WriteLine(gold);
            writer.WriteLine(inventory.Count);
            for (int i = 0; i < inventory.Count; ++i)
            {
                writer.WriteLine(inventory[i]);
            }
        }
    }
}
