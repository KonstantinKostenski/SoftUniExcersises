using System;

namespace strings_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object concatenation = word1 + " " + word2;
            string result = (string)concatenation;
            Console.WriteLine(result);
        }
    }
}
