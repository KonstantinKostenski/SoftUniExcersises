using System;
using System.Linq;

namespace fold_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] upperArray = new int[2 * k];
            int[] lowerArray = new int[2 * k];
            int[] sumArray = new int[2 * k];

            for (int i = k; i < 3 * k; i++)
            {
                lowerArray[i - k] = numbers[i];
            }

            for (int i = 0; i < k; i++)
            {
                upperArray[i] = numbers[k - 1 - i];
                upperArray[k + i] = numbers[4 * k - 1 - i];
            }
            for (int i = 0; i < 2 *k; i++)
            {
                sumArray[i] += upperArray[i];
            }
            for (int i = 0; i < 2 * k; i++)
            {
                sumArray[i] += lowerArray[i];
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
