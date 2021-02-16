using System;
using System.Linq;

namespace pairs_by_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int differnece = int.Parse(Console.ReadLine());
            int counter = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length - 1; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j + 1]) == differnece)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
