using System;

namespace hex_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int conversion = Convert.ToInt32(hex, 16);
            Console.WriteLine(conversion);
        }
    }
}
