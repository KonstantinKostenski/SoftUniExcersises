using System;
using System.Linq;

namespace max_sequence_increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sequence = 1;
            int maxSequence = 0;
            int position = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    sequence++;
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                        position = i + 1;
                    }
                }
                else
                {
                    sequence = 1;
                }
            }
            for (int i = position - maxSequence + 1; i <= position; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
