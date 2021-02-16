using System;

namespace geometry_calaculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double parameter1 = 0;
            double parameter2 = 0;
            if(figureType == "triangle")
            {
                parameter1 = double.Parse(Console.ReadLine());
                parameter2 = double.Parse(Console.ReadLine());
            }
            else if(figureType == "square")
            {
                parameter1 = double.Parse(Console.ReadLine());
            }
            else if(figureType == "rectangle")
            {
                parameter1 = double.Parse(Console.ReadLine());
                parameter2 = double.Parse(Console.ReadLine());
            }
            else if(figureType == "circle")
            {
                parameter1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{calculateProperty(figureType, parameter1, parameter2):f2}");
        }

        static double calculateProperty(string figureType, double parameter1, double parameter2 = 0)
        {
            double result = 0;
            switch (figureType)
            {
                case "triangle":
                    result = (parameter1 * parameter2) / 2;
                    break;
                case "square":
                    result = parameter1 * parameter1;
                    break;
                case "rectangle":
                    result = parameter1 * parameter2;
                    break;
                case "circle":
                    result = Math.PI * parameter1 * parameter1;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
