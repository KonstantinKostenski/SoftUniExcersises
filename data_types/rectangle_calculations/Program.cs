using System;

namespace rectangle_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = height * width;
            double perimeter = 2 * width + 2 * height;
            double diagonal = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2));
            Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");



        }
    }
}
