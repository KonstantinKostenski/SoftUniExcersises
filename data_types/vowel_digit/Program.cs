using System;

namespace vowel_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine().ToLower()) ;
            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'u' || symbol == 'o' || symbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if(symbol >= 48 && symbol <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
