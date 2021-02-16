using System;
using System.Linq;

namespace excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] numbersMatrix = new int[size][];
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;


            for (int row = 0; row < numbersMatrix.Length; row++)
            {
                numbersMatrix[row] = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
            }
            for (int row = 0; row < numbersMatrix.Length; row++)
            {
                int firstDiagonalNumber = numbersMatrix[row][row];
                int secondDiagonalNumber = numbersMatrix[row][numbersMatrix[row].Length - 1 - row];
                firstDiagonalSum += firstDiagonalNumber;
                secondDiagonalSum += secondDiagonalNumber;
            }
            int difference = Math.Abs(firstDiagonalSum - secondDiagonalSum);
            Console.WriteLine(difference);
        }
    }
}
