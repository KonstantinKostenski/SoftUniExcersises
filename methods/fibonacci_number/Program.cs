using System;

namespace fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(fib(n)); 
        }

        static long fib(long n)
        {
            long first = 0;
            long second = 1;
            long temp = 0;
            for (long i = 0; i < n; i++)
            {
                temp = first;
                first = second;
                second = temp + second;
            }
            return second;
        }
    }
}
