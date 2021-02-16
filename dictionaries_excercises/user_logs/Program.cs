using System;
using System.Collections.Generic;
using System.Linq;

namespace user_logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(new string[] { " ", "="}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            string user = "";
            string ip = "";
            int ipCount = 1;

            while (commands[0] != "end")
            {
                user = commands[5];
                ip = commands[1];
                
                if (users.ContainsKey(user))
                {
                    Dictionary<string, int> ipAdress = new Dictionary<string, int>();
                    ipAdress.Add(ip, ipCount);
                    if (!users[user].ContainsKey(ip))
                    {
                        users[user].Add(ip, ipCount);
                    }
                    else
                    {
                        users[user][ip]++;
                    }
                }
                else
                {
                    Dictionary<string, int> ipAdress = new Dictionary<string, int>();
                    ipAdress.Add(ip, ipCount);
                    users.Add(user, ipAdress);
                }
                commands = Console.ReadLine().Split(new string[] { " ", "=" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var playa in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{playa.Key}:");
                List<string> helper = new List<string>();
                foreach (var item in playa.Value)
                {
                    helper.Add($"{item.Key} => {item.Value}");
                }
                Console.WriteLine(string.Join(", ", helper) + ".");
            }
        }
    }
}
