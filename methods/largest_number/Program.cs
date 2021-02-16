using System;

namespace largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int comparison = GetMax(num1, num2);
            int num3 = int.Parse(Console.ReadLine());
            if (comparison > num3)
            {
                Console.WriteLine(comparison);
            }
            else
            {
                Console.WriteLine(num3);
            }


        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
