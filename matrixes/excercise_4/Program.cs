using System;
using System.Linq;

namespace excercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[][] numbersArray = new int[dimensions[0]][];

            for (int row = 0; row < numbersArray.Length; row++)
            {
                numbersArray[row] = new int[dimensions[1]];
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < numbersArray[row].Length; col++)
                {
                    numbersArray[row][col] = numbers[col];
                }
            }

            int maximalSum = 0;
            int targerRow = 0;
            int targetCol = 0;

            for (int row = 0; row < numbersArray.Length - 2; row++)
            {
                for (int col = 0; col < numbersArray[row].Length - 2; col++)
                {
                    int currentSum = numbersArray[row][col] + numbersArray[row][col + 1] + numbersArray[row][col + 2] +
                                 numbersArray[row + 1][col] + numbersArray[row + 1][col + 1] + numbersArray[row + 1][col + 2] +
                                 numbersArray[row + 2][col] + numbersArray[row + 2][col + 1] + numbersArray[row + 2][col + 2];

                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        targerRow = row;
                        targetCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maximalSum}");
            for (int row = targerRow; row < targerRow + 3; row++)
            {
                for (int col = targetCol; col < targetCol + 3; col++)
                {
                    Console.Write(numbersArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
