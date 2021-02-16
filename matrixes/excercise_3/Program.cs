using System;
using System.Linq;

namespace excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[][] charMatrix = new char[rows][];

            for (int row = 0; row < charMatrix.Length; row++)
            {
                charMatrix[row] = new char[cols];
                char[] chars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < charMatrix[row].Length; col++)
                {
                    charMatrix[row][col] = chars[col];
                }
            }
            int counter = 0;

            for (int row = 0; row < charMatrix.Length - 1; row++)
            {
                for (int col = 0; col < charMatrix[row].Length - 1; col++)
                {
                    bool isEqual = charMatrix[row][col] == charMatrix[row + 1][col] 
                                   && charMatrix[row][col] == charMatrix[row + 1][col + 1] 
                                   && charMatrix[row][col] == charMatrix[row][col + 1];
                    if (isEqual)
                    {
                        ++counter;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
