using System;
using System.Collections.Generic;
using System.Linq;

namespace fix_emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string command = Console.ReadLine();

            while (command != "stop")
            {
                if (emails.ContainsKey(command))
                {
                    emails[command] = Console.ReadLine();
                }
                else
                {
                    emails.Add(command, Console.ReadLine());
                }
                command = Console.ReadLine();
            }
            foreach (var item in emails.Where(x => !x.Value.EndsWith("uk") && !x.Value.EndsWith("us")))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
