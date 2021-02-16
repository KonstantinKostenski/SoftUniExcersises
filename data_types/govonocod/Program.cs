using System;

namespace govonocod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int toCheck = 2; toCheck <= number; toCheck++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(toCheck); divisor++)
                {

                    if (toCheck % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    
                }
                
                Console.WriteLine($"{toCheck} -> {isPrime}");
            }
        }
    }
}
