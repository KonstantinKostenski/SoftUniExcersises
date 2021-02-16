using System;

namespace master_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (ContainsEvenDigit(i) && SumOfDigits(i) && IsPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool ContainsEvenDigit(int i)
        {
            bool containsEvenDigit = false;
            int digit = 0;
            int number = i;
            while(number != 0)
            {
                digit = number % 10;
                if (digit % 2 == 0)
                {
                    containsEvenDigit = true;
                    return containsEvenDigit;
                }
                number /= 10;
            }
            return containsEvenDigit;
        }

        private static bool SumOfDigits(int i)
        {
            bool sumOfDigits = false;
            int digitsSum = 0;
            while(i != 0)
            {
                digitsSum += i % 10;
                i /= 10;
            }
            if (digitsSum % 7 == 0)
            {
                sumOfDigits = true;
            }
            else
            {
                sumOfDigits = false;
            }
            return sumOfDigits;
        }

        private static bool IsPalindrome(int i)
        {
            bool isPalindrome = false;
            int power = i.ToString().Length - 1;
            int oldNumber = i;
            int newNumber = 0;
            int loops = i.ToString().Length;
            for (int j = 0; j < loops; j++)
            {
                newNumber += i % 10 * (int)Math.Pow(10, power);
                power--;
                i /= 10;
            }
            if (newNumber == oldNumber)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
