using System;
using System.Linq;

namespace index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];
            int counter = 0;

            for (char symbol = 'a'; symbol <= 'z'; symbol++)
            {
                alphabet[counter] = symbol;
                counter++;
            }


            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (currentLetter == alphabet[j])
                    {
                        Console.WriteLine($"{alphabet[j]} -> {j}");
                    }
                }
            }


        }
    }
}
