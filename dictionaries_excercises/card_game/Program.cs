using System;
using System.Collections.Generic;
using System.Linq;

namespace card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            var commands = Console.ReadLine().Split(new char[] {' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> cards = new List<string>();
            string player = "";
            int sum = 0;
            int multiplier = 0;
            int mainValue = 0;

            while (commands[0] != "JOKER")
            {
                cards = commands.Skip(1).ToList();
                cards = cards.Distinct().ToList();
                player = commands[0];
                if (players.ContainsKey(player))
                {
                    players[player].AddRange(cards);
                    players[player] = players[player].Distinct().ToList();
                }
                else
                {
                    players.Add(player, cards);
                }
                commands = Console.ReadLine().Split(new char[] {' ', ':', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var playa in players)
            {
                foreach (var card in playa.Value)
                {
                    char cardType = card[card.Length - 1];
                    switch (cardType)
                    {
                        case 'S':
                            multiplier = 4;
                            break;
                        case 'H':
                            multiplier = 3;
                            break;
                        case 'D':
                            multiplier = 2;
                            break;
                        case 'C':
                            multiplier = 1;
                            break;
                    }
                    string kindCard = card.Remove(card.Length - 1, 1);
                    switch (kindCard)
                    {
                        case "J":
                            mainValue = 11;
                            break;
                        case "Q":
                            mainValue = 12;
                            break;
                        case "K":
                            mainValue = 13;
                            break;
                        case "A":
                            mainValue = 14;
                            break;
                        default:
                            mainValue = int.Parse(kindCard);
                            break;
                    }
                    sum += multiplier * mainValue;
                }
                Console.WriteLine($"{playa.Key}: {sum}");
                sum = 0;
            }
        }
    }
}
