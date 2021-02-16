using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsExcercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int data = int.Parse(Console.ReadLine());
                box.Data.Add(data);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(indexes[0], indexes[1]);
            Console.WriteLine(box);

        }
    }
}
