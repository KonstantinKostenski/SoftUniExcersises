using System;

namespace closest_point
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxDistance = double.MinValue;
            double maxX1 = 0;
            double maxX2 = 0;
            double maxY1 = 0;
            double maxY2 = 0;
            for (int i = 0; i < 2; i++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());
                double currentDistance = CheckShorter(x1, y1, x2, y2);
                if (currentDistance > maxDistance)
                {
                    maxDistance = currentDistance;
                    maxX1 = x1;
                    maxX2 = x2;
                    maxY1 = y1;
                    maxY2 = y2;
                }
            }
            CheckShortest(maxX1, maxY1, maxX2, maxY2);
            
        }

        static double CheckShorter(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
            return distance;
        }
        static void CheckShortest(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
