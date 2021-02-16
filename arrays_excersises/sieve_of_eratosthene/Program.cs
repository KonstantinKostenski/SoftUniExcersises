using System;
using System.Collections.Generic;

namespace sieve_of_eratosthene
{
    class Program
    {
        static void Main(string[] args)
        {
            int primesRange = int.Parse(Console.ReadLine());
            bool[] primes = new bool[primesRange + 1];

            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(primesRange); i++)
            {
                if (primes[i] == true)
                {
                    for (int j = i * i; j <= primesRange; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
