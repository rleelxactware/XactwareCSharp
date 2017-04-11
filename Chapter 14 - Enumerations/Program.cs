using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14___Enumerations
{
    class Program
    {
        enum MonthsOfYear {January=1, February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December=12};

        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Welcome to the month of the year program!!\n");
            Console.Write("Please enter a integer between 1 and 12: ");
            string numEntered = Console.ReadLine();
            while (!Int32.TryParse(numEntered, out x))
            {
                Console.WriteLine("This is not a integer, stop trying to be smart and enter a integer between 1 and 12 !!!!! ");
                numEntered = Console.ReadLine();
            }

            int num = Convert.ToInt32(numEntered);
            while(num < 1 || num > 12)
            {
                Console.Write("Trying to be smart?  Please enter a integer between 1 and 12: ");

                numEntered = Console.ReadLine();
                while (!Int32.TryParse(numEntered, out x))
                {
                    Console.WriteLine("This is not a integer, stop trying to be smart and enter a integer between 1 and 12 !!!!! ");
                    numEntered = Console.ReadLine();
                }
                num = Convert.ToInt32(numEntered);
            }

            switch (num)
            {
                case 1:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.January}");
                    break;
                case 2:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.February}");
                    break;
                case 3:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.March}");
                    break;
                case 4:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.April}");
                    break;
                case 5:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.May}");
                    break;
                case 6:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.June}");
                    break;
                case 7:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.July}");
                    break;
                case 8:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.August}");
                    break;
                case 9:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.September}");
                    break;
                case 10:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.October}");
                    break;
                case 11:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.November}");
                    break;
                case 12:
                    Console.WriteLine($"\nThe number you entered relates to the month of {MonthsOfYear.December}");
                    break;
            }

            Console.ReadKey();
        }
    }
}
