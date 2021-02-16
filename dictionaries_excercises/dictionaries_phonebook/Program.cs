using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries_phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    string name = commands[1];
                    string phone = commands[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phone);
                    }
                    else
                    {
                        phonebook[name] = phone; 
                    }
                }
                else if(commands[0] == "S")
                {
                    string name = commands[1];
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                }
                else if(commands[0] == "ListAll")
                {
                    foreach (var name in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{name.Key} -> {name.Value}");
                    }
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
