using System;

namespace reverse_order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(reverse_order(number));
        }

        private static string reverse_order(string number)
        {
            string reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }
            return reversed;
        }
    }
}
