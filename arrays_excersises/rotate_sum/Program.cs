﻿using System;
using System.Linq;

namespace rotate_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationsNumber = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];
            

            for (int i = 0; i < rotationsNumber; i++)
            {
                numbers = rotated(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        static int[] rotated(int[] numbers) 
        {
            int[] rotated = new int[numbers.Length];
            int lastDigit = numbers[numbers.Length - 1];
            for (int i = 1; i < numbers.Length; i++)
            {
                rotated[i] = numbers[i - 1];
            }
            rotated[0] = lastDigit;
            return rotated;
        }
    }
}
