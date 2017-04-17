using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17___Object_Oriented_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome the this Dice Program.\nHow many dice do you want to use?");
            string numEntered = Console.ReadLine();
            int numberOfDice = Convert.ToInt32(numEntered);


            Random random = new Random();
            int dieRoll = 0;
            int total = 0;
            for (int count = 0; count < numberOfDice; count++)
            {
                dieRoll = random.Next(6) + 1;
                Console.WriteLine($"Dice {count + 1} = {dieRoll}.");
                total += dieRoll;
            }
            Console.WriteLine($"The sum of the Die that you rolled is {total}.");
            Console.ReadKey();
        }
    }
}
