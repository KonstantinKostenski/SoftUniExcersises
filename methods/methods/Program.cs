using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            hello(name);
        }

        private static void hello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
