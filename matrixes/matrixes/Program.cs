using System;
using System.Linq;

namespace matrixes
{
    class Program
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int rows = sizes[0];
            int cols = sizes[1];

            string[][] palindromeArray = new string[rows][];

            for (int row = 0; row < palindromeArray.Length; row++)
            {
                palindromeArray[row] = new string[cols];
                for (int col = 0; col < palindromeArray[row].Length; col++)
                {
                    char firstLetter = alphabet[row];
                    char secondLetter = alphabet[col + row];

                    palindromeArray[row][col] = $"{firstLetter}{secondLetter}{firstLetter} ";
                    Console.Write(palindromeArray[row][col]);
                }
                Console.WriteLine();
            }

        }

    }
}
