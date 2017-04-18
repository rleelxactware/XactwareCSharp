using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld_Day2
{
    class Program
    {
        static private string[] invalidNames = new[] { "Legolas", "Gandalf", "Frodo", "Bilbo" };
        enum Statistics
        {
            strength = 0,
            perception,
            endurance,
            charisma,
            intelligence,
            agility,
            luck
        };

        static void Main(string[] args)
        {
            string name = CheckForInvalidNames();
            int[] statistics = new int[Enum.GetNames(typeof(Statistics)).Length];

            int hitpoints = 0;
            //hitpoints = 10 + statistics[2];

            GenerateStats(statistics, hitpoints);


            hitpoints = 10 + statistics[2];

            Console.ReadKey();


            Console.WriteLine("\nYou encounter an rabid emotionally distant exploding feral deseased lonely slightly overweight kitten");

            Random random = new Random();

            int kittenHP = 10;
            while (hitpoints > 0 || kittenHP > 0)
            {
                Console.WriteLine($"Player HP: {hitpoints}\nKitten HP: {kittenHP}");
                // Roll for initiative
                var yourRoll = random.Next(1, 21);
                var kittenRoll = random.Next(1, 21);
                if (yourRoll > kittenRoll)
                {
                    //Player attacks first
                    var playerDamage = random.Next(0, 3);
                    kittenHP -= playerDamage;
                    Console.WriteLine($"You hugged the kitten for: {playerDamage}");
                    if (kittenHP <= 0)
                    {
                        break;
                    }
                    //Kitten attacks first
                    var kittenDamage = random.Next(0, 3);
                    hitpoints -= kittenDamage;
                    Console.WriteLine($"The kitten purred at you and did: {kittenDamage}");
                    if (hitpoints <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    //Kitten attacks first
                    var kittenDamage = random.Next(0, 3);
                    hitpoints -= kittenDamage;
                    Console.WriteLine($"The kitten purred at you and did: {kittenDamage}");
                    if (hitpoints <= 0)
                    {
                        break;
                    }
                    var playerDamage = random.Next(0, 3);
                    kittenHP -= playerDamage;
                    Console.WriteLine($"You hugged the kitten for: {playerDamage}");
                    if (kittenHP <= 0)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
            }
            if (hitpoints < kittenHP)
            {
                Console.WriteLine("Player Lost");
            }
            else
            {
                Console.WriteLine($"\n\n{name}: Won the fight!!!!!");
            }
            Console.ReadKey();
        }


        //-------------------------------------------------------------------
        //-------------   CheckForInvalidNames METHOD  ----------------------
        //-------------------------------------------------------------------
        static string CheckForInvalidNames()
        {
            Console.Write("Please Enter a Character's Name: ");
            string name = "";

            bool validName = false;
            while (!validName)
            {
                name = Console.ReadLine().Trim();
                foreach (string invalid in invalidNames)
                {

                    if (name.Contains(invalid) || name.Length == 0)
                    {
                        validName = false;
                        if (name.Length == 0)
                        {
                            Console.WriteLine($"You have entered a blank name, please enter a valid name");
                        }
                        else
                        {
                            Console.WriteLine($"You have entered a forbidden name: {invalid}, please enter a valid name");
                        }
                        break;
                    }
                    else
                    {
                        validName = true;
                    }
                }
            }
            return name;
        }


        //-------------------------------------------------------------------
        //----------------   GenerateStats METHOD  --------------------------
        //-------------------------------------------------------------------
        static int[] GenerateStats(int[] stats, int hitpoints)
        {
            // Derived Stats
            //int hitpoints = 0;

            int totalValueMinimum = 35;
            int playerTotalStats = 0;
            int rollCount = 1;

            Random random = new Random();
            //int randomNumber = random.Next(0, 100); // This will return integers between 0-99;
            
            Console.WriteLine("\nRolling your awesome stats...");
            // Generate Stats:
            while (playerTotalStats <= totalValueMinimum)
            {
                for (int index = 0; index < stats.Length; index++)
                {
                    stats[index] = random.Next(1, 11);
                }

                // Generate derived stats
                hitpoints = 10 + stats[(int)Statistics.endurance];

                playerTotalStats = stats[(int)Statistics.strength] + stats[(int)Statistics.perception] + stats[(int)Statistics.endurance] + stats[(int)Statistics.charisma] + stats[(int)Statistics.intelligence] + stats[(int)Statistics.agility] + stats[(int)Statistics.luck];
                Console.WriteLine($"Roll: {rollCount++} We Rolled a total of: {playerTotalStats}");
            }
            return stats;
        }


        //-------------------------------------------------------------------
        //-----------------   DisplayStats METHOD  --------------------------
        //-------------------------------------------------------------------
        static void DisplayStats(int[] stats, string name, int hitpoints )
        {
            Console.WriteLine($"\nWelcome to HerosWorld (tm): {name}");

            // Display Stats
            Console.WriteLine("Your Amazing Base Stats");
            Console.WriteLine("________________________");
            Console.WriteLine($"Strength: {stats[(int)Statistics.strength]}");
            Console.WriteLine($"Perception: {stats[(int)Statistics.perception]}");
            Console.WriteLine($"Endurance: {stats[(int)Statistics.endurance]}");
            Console.WriteLine($"Charisma: {stats[(int)Statistics.charisma]}");
            Console.WriteLine($"Intelligence: {stats[(int)Statistics.intelligence]}");
            Console.WriteLine($"Agility: {stats[(int)Statistics.agility]}");
            Console.WriteLine($"Luck: {stats[(int)Statistics.luck]}");
            Console.WriteLine("________________________");

            Console.WriteLine("Your Amazing Derived Stats");
            Console.WriteLine("________________________");
            Console.WriteLine($"Hit Points: {hitpoints}");
            
        }
    }
}