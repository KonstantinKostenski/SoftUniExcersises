using System;
using System.Linq;

namespace max_sequence_equals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sequence = 1;
            int maxSequence = 0;
            int maxNumber = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    sequence++;
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                        maxNumber = numbers[i];
                    }
                }
                else
                {
                    sequence = 1;
                }
            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(maxNumber + " ");
            }
        }
    }
}
