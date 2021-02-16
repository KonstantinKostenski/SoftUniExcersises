using System;

namespace prime_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number)); 
        }

        static Boolean IsPrime(long number)
        {
            bool isPrime = true;
            if (number == 1 || number % 2 == 0) isPrime = false;
            for (long i = 3; i <= (long)Math.Floor(Math.Sqrt(number)); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            if(number == 2)
            {
                isPrime = true;
            }
            return isPrime;
        }
    }
}
