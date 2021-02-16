using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace convert_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            int @base = int.Parse(commands[0]);
            BigInteger number = BigInteger.Parse(commands[1]);
            StringBuilder remainders = new StringBuilder();

            while (number != 0)
            {
                remainders.Append(number % @base);
                number /= @base;
            }

            Console.WriteLine(string.Join("", remainders.ToString().Reverse()));
        }
    }
}
