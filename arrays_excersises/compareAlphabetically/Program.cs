using System;
using System.Linq;

namespace compareAlphabetically
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayFirst = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arraySecond = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool isFirst = false;

            for (int i = 0; i < Math.Min(arrayFirst.Length, arraySecond.Length); i++)
            {
                if (arrayFirst[i] < arraySecond[i])
                {
                    isFirst = true;
                    break;
                }
                else if(arrayFirst[i] == arrayFirst[i])
                {
                    if (arrayFirst.Length < arraySecond.Length)
                    {
                        isFirst = true;
                        break;
                    }
                    else
                    {
                        isFirst = false;
                        break;
                    }
                }
            }
            if (isFirst)
            {
                Console.WriteLine(string.Join("", arrayFirst));
                Console.WriteLine(string.Join("", arraySecond));
            }
            else
            {
                Console.WriteLine(string.Join("", arraySecond));
                Console.WriteLine(string.Join("", arrayFirst));
            }

        }
    }
}
