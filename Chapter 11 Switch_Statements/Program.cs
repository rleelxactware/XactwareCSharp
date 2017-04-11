using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            string playAgain = "Yes"
            while(playAgain != "No")

            Console.WriteLine("Welcome to the Calculator Propgram!!\nPlease enter your first number: ");
            string num1Entered = Console.ReadLine();
            int x;
            while (!Int32.TryParse(num1Entered, out x))
            {
                Console.WriteLine("Not a valid number, please try again: ");
                num1Entered = Console.ReadLine();
            }
            int num1 = Convert.ToInt32(num1Entered);


            Console.WriteLine("\nPlease inter your second number: ");
            string num2Entered = Console.ReadLine();
            
            while (!Int32.TryParse(num2Entered, out x))
            {
                Console.WriteLine("Not a valid number, please try again: ");
                num2Entered = Console.ReadLine();
            }
            int num2 = Convert.ToInt32(num2Entered);

            Console.WriteLine("\nNow enter on of the following for the operation you want to preform (+, -, *, /, % for remainder: ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    int result = num1 + num2;
                    Console.WriteLine($"Your number is {result}!" );
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your number is {result}!");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your number is {result}!");
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your number is {result}!");
                    break;
                case "%":
                    result = num1 % num2;
                    Console.WriteLine($"The remainder of dividing your first number by your second number is {result}!");
                    break;
                default :
                    Console.WriteLine("You have entered an incorrect operation!!!");
                    break;

            }

            Console.ReadKey();
        }
    }
}
