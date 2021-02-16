using System;

namespace closest_point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            string checkShorter = CheckShorter(x1, y1, x2, y2);
            if (checkShorter == "first")
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static string CheckShorter(double x1, double y1, double x2, double y2)
        {
            string result = "";
            double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (distance1 > distance2 )
            {
                result += "second";
            }
            else
            {
                result += "first";
            }
            return result;


        }
    }
}
