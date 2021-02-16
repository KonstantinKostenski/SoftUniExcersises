using System;
using System.Collections.Generic;
using System.Linq;

namespace population_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split('|').ToArray();
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            string country = "";
            string city = "";
            long population = 0;

            while (commands[0] != "report")
            {
                city = commands[0];
                country = commands[1];
                population = long.Parse(commands[2]);

                if (!countries.ContainsKey(country))
                {
                    Dictionary<string, long> currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);
                    countries.Add(country, currentCity);
                }
                else
                {
                    countries[country].Add(city, population);
                }
                commands = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var countryPair in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{countryPair.Key} (total population: {countryPair.Value.Values.Sum()})");
                foreach (var cityPair in countryPair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                }
            }

        }
    }
}
