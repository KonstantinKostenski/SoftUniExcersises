using System;
using System.Collections.Generic;

namespace resources_quantity
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "stop")
            {
                string metal = command;
                if (resources.ContainsKey(metal))
                {
                    resources[metal] += int.Parse(Console.ReadLine());
                }
                else 
                {
                    resources.Add(metal, int.Parse(Console.ReadLine()));
                }
                command = Console.ReadLine();
            }
            foreach (var metal in resources)
            {
                Console.WriteLine($"{metal.Key} -> {metal.Value}");
            }
        }
    }
}
