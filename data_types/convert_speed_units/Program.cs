using System;

namespace convert_speed_units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int time = hours * 3600 + minutes * 60 + seconds;
            float mPerS = (float)distanceMeters / time;
            float kPerH = ((float)distanceMeters / 1000) / ((float)time / 3600);
            float mPerH = ((float)distanceMeters / 1609) / ((float)time / 3600);
            Console.WriteLine($"{mPerS:0.######}\n{kPerH:0.######}\n{mPerH:0.######}");
        }
    }
}
