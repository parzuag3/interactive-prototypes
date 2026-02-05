using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleQuest
{
    class AdventureEvent
    {
        private bool doneAdventure = false;

        string description = "An Event";
        List<string> choices = new List<string>();
        Dictionary<int, string> responses = new Dictionary<int, string>();
        Dictionary<int, List<string>> rewards = new Dictionary<int, List<string>>();


        private string ReadNextLine(StreamReader reader)
        {
            while (reader.Peek() > -1)
            {
                string line = reader.ReadLine();
                if (line.Length > 0 && line[0] == '#')  // A comment line
                    continue;
                return line;
            }
            return string.Empty;
        }

        public void Load(StreamReader reader)
        {
            string line;
            line = ReadNextLine(reader);  // name

            int number;

            // There might be a number of lines for the description
            line = ReadNextLine(reader);  // description
            if (!int.TryParse(line, out number))
                description = line;
            else
            {
                description = string.Empty;
                for (int i = 0; i < number; ++i)
                {
                    line = ReadNextLine(reader);  // description
                    description += line + "\n";
                }
            }

            // There must always be a number of choices before the list of choices
            line = ReadNextLine(reader);  // choices
            number = int.Parse(line);
            for (int i = 0; i < number; ++i)
            {
                string choice = ReadNextLine(reader);  // choice
                string response = string.Empty;
                List<string> rewards = new List<string>();

                int count;
                // There might be several lines of response
                line = ReadNextLine(reader);  // responses
                if (!int.TryParse(line, out count))
                    response = line;
                else
                {
                    for (int j = 0; j < count; ++j)
                    {
                        line = ReadNextLine(reader);  // response
                        response += line + "\n";
                    }
                }

                // There might be several rewards
                line = ReadNextLine(reader);  // rewards
                if (!int.TryParse(line, out count))
                    rewards.Add(line);
                else
                {
                    for (int j = 0; j < count; ++j)
                    {
                        line = ReadNextLine(reader);  // reward
                        rewards.Add(line);
                    }
                }

                AddChoice(choice, response, rewards);
            }
        }

        public void Start()
        {}

        public void SetDescription(string desc)
        {
            description = desc;
        }

        public string GetDescription(Hero hero)
        {
            return description;
        }

        public void AddChoice(string choice, string response)
        {
            choices.Add(choice);
            responses.Add(choices.Count, response);
        }
        public void AddChoice(string choice, string response, List<string> rewards)
        {
            choices.Add(choice);
            responses.Add(choices.Count, response);
            this.rewards.Add(choices.Count, rewards);
        }

        public string GetChoices(Hero hero)
        {
            string choiceString = "0) Check Inventory\n";
            for (int i = 0; i < choices.Count; ++i)
            {
                choiceString += (i+1) + ") " + choices[i] + '\n';
                i++;
            }
            return choiceString;
        }

        public int GetNumChoices()
        {
            return choices.Count;
        }

        public void Choose(Adventure adv, Hero hero, int choice)
        {
            if (choice <= 0 || choice > choices.Count)
            {
                Console.WriteLine("That is not a valid choice.");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                return;
            }

            if (responses.ContainsKey(choice))
                Console.WriteLine(responses[choice]);

            Console.WriteLine();

            if (rewards.ContainsKey(choice))
                GiveRewards(adv, hero, rewards[choice]);
        }
        
        public void GiveRewards(Adventure adv, Hero hero, List<string> rewardList)
        {
            for (int i = 0; i < rewardList.Count; ++i)
            {
                string reward = rewardList[i];
                switch (reward)
                {
                    case "":
                        break;
                    case "doneAdventure":
                        doneAdventure = true;
                        break;
                    case "damage":
                        hero.TakeDamage(1);
                        Console.WriteLine(hero.name + " took " + 1 + " damage!");
                        break;
                    case "kill":
                        hero.TakeDamage(10000);
                        Console.WriteLine(hero.name + " has been knocked out!");
                        break;
                    case "gold":
                        adv.gold += 1;
                        Console.WriteLine(hero.name + " found " + 1 + " gold!");
                        break;
                    case "xp":
                        hero.experience += 1;
                        Console.WriteLine(hero.name + " gained " + 1 + " experience!");
                        break;
                    default:
                        hero.GiveItem(reward);
                        Console.WriteLine(hero.name + " got a " + reward + ".");
                        break;
                }
            }
        }

        public bool ShouldEndAdventure()
        {
            return doneAdventure;
        }
    }
}
