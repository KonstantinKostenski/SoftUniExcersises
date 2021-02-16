using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace convert_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            int  @base = int.Parse(commands[0]);
            BigInteger number = BigInteger.Parse(commands[1]);
            List<BigInteger> multiplications = new List<BigInteger>();

            for (int i = 0; i < commands[1].Length; i++)
            {
                BigInteger numberDivided = number % 10; 
                multiplications.Add(numberDivided * (BigInteger)Math.Pow(@base, i));
            }
            Console.WriteLine(multiplications.Sum());

        }
    }
}
