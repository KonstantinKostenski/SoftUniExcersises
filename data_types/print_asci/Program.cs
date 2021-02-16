using System;

namespace print_asci
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());
            for (int i = firstChar; i <= secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}

