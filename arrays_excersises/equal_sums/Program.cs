using System;
using System.Linq;

namespace equal_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isEqual = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int left = 0; left < i; left++)
                {
                    leftSum += numbers[left];
                }
                for (int right = i + 1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }
                if (leftSum == rightSum)
                {
                    isEqual = true;
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    isEqual = false;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
