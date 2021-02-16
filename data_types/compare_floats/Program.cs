using System;

namespace compare_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            bool areEqual = false;
            if (Math.Abs(number1 - number2) > eps)
            {
                areEqual = false;
                Console.WriteLine(areEqual);

            }
            else if (Math.Abs(number1 - number2) < eps)
            {
                areEqual = true;
                Console.WriteLine(areEqual);
            }
            else
            {
                areEqual = false;
                Console.WriteLine(areEqual);
            }

        }
    }
}
