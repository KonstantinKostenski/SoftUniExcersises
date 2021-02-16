using System;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string booleanToConvert = Console.ReadLine();
            bool conversion = Convert.ToBoolean(booleanToConvert);
            if (conversion == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
