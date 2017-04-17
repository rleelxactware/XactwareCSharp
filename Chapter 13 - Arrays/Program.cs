using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {




            //CREATING TWO ARRAYS, FILLING ONE ARRAY THEN COPYING IT TO SECOND ARRAY
            //--------------------------------------------------------------------------
            /*
            int[] firstArray = new[] { 1, 50, -2, 59, 38, -58, -32, 38, 88, 0 };
            int[] sencondArray = new int[firstArray.Length];

            for(int index = 0; index < firstArray.Length; index++)
            {
                sencondArray[index] = firstArray[index];
            }

            for(int index = 0; index < firstArray.Length; index++)
                Console.WriteLine(firstArray[index]);

            Console.WriteLine("\n");

            for (int index = 0; index < sencondArray.Length; index++)
                Console.WriteLine(sencondArray[index]);

            Console.ReadKey();
            */






            //Examples out of the book
            //----------------------------------------------
            /*
            int[][] matrix = new int[4][];
            matrix[0] = new int[2];
            matrix[1] = new int[6];
            matrix[2] = new int[3];
            matrix[3] = new int[5];
            // Continue filling in values for the jagged array...
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                    Console.Write(matrix[row][column] + " "); // Each item in the row separated by spaces
                Console.WriteLine(); // Rows separated by lines
            }
            Console.ReadKey();
            */







            //More examples out of the book
            //------------------------------------------
            /*
            int[,] matrix = new int[4, 4];
            // Fill in contents for multi-dimensional array
            // Note: GetLength gives back the size of the multi-dimensional array for a specific index.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                    Console.Write(matrix[row, column] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
            */





            // This program will initialize an array and then find the minimun value in the array as well as give the average value of the array

            //Setting the currentMinimum to highest possible value.
            double currentMinimum = double.MaxValue;

            int[] array = new int[] { 5, 10, 15, -20, 25, -30, 35, 40, 45, -50 };
            double total = 0;

            foreach (int value in array)
            {
                total += value;
                if (value < currentMinimum)
                    currentMinimum = value;
            }

            double average = total / array.Length;
            Console.WriteLine($"The average of the array is {average}!");
            Console.WriteLine($"The lowest number in the array is {currentMinimum}");
            Console.ReadKey();

        }
    }
}
