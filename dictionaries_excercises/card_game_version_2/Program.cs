﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace card_game_version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> powers = GetPowers();
            Dictionary<char, int> suits = GetSuits();
            string line;
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            while ((line = Console.ReadLine()) != "JOKER")
            {
                string[] tokens = line.Split(new[] {": " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string playerName = tokens[0];
                string[] hand = tokens[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries ).ToArray();
                if (!players.ContainsKey(playerName))
                {
                    players.Add(playerName, new List<string>());
                }
                players[playerName].AddRange(hand);

            }
            foreach (var player in players)
            {
                string name = player.Key;
                string[] cards = player.Value.Distinct().ToArray();

                long cardSum = GetSum(cards, powers, suits);
                Console.WriteLine($"{name}: {cardSum}");
            }
        }

        private static long GetSum(string[] cards, Dictionary<string, int> powers, Dictionary<char, int> suits)
        {
            long sum = 0L;
            foreach (var card in cards)
            {
                string power = card[0].ToString();
                char suit = card[card.Length - 1];
                sum += powers[power] * suits[suit];

            }

            return sum;
        }

        private static Dictionary<char, int> GetSuits()
        {
            Dictionary<char, int> suits = new Dictionary<char, int>();
            suits.Add('S', 4);
            suits.Add('H', 3);
            suits.Add('D', 2);
            suits.Add('C', 1);
            return suits;

        }

        private static Dictionary<string, int> GetPowers()
        {
            Dictionary<string, int> powers = new Dictionary<string, int>();
            for (int i = 2; i < 11; i++)
            {
                string powerKey = i.ToString();
                int powerValue = i;
                powers.Add(powerKey, powerValue);
            }
            powers.Add("1", 10);
            powers.Add("J", 11);
            powers.Add("Q", 12);
            powers.Add("K", 13);
            powers.Add("A", 14);
            return powers;
        }
    }
}
