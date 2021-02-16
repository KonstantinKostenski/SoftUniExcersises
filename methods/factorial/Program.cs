using System;
using System.Numerics;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeroes(factorial(n)));
        }
        static BigInteger factorial(BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
         }
        static int TrailingZeroes(BigInteger n)
        {
            int counter = 0;
            while (n != 0)
            {
                BigInteger digit = n % 10;
                if (digit == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                n /= 10;
            }
            return counter;

        }
    }
}
