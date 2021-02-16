using System;

namespace thea_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            double goodPictures = 0;
            double totalTime = 0;
            goodPictures = Math.Ceiling(pictures - (double)((pictures * filterFactor) / 100));
            totalTime = (pictures * filterTime) + (goodPictures * uploadTime);
            TimeSpan result = TimeSpan.FromSeconds(totalTime);
            string formatResult = @"d\:hh\:mm\:ss";
            Console.WriteLine(result.ToString(formatResult));
        }
    }
}
