using System;
using System.Linq;

namespace most_frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 1;
            int maxCount = 0;
            int number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            number = numbers[i];
                            maxCount = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            Console.WriteLine(number);

        }
    }
}
