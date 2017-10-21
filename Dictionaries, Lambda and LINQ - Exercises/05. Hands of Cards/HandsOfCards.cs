using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; ; i++)
            {
                var start = Console.ReadLine();
                if (start == "JOKER")
                {
                    break;
                }
                var input = start.Split(':').ToArray();
                var name = input[0];
                var cards = input[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Dictionary<string, int>());
                    AddCards(people[name],cards);
                }
                else
                {
                    AddCards(people[name], cards);
                }
            }
            foreach (var person in people)
            {
                Console.WriteLine("{0}: {1}", person.Key, person.Value.Values.Sum());
            }
        }
        private static void AddCards(Dictionary<string, int> cardsDict, string[] cards)
        {
            foreach (var card in cards)
            {
                if (!cardsDict.Keys.Contains(card))
                {
                    cardsDict.Add(card, CardValue(card));
                }
            }
        }
        private static int CardValue(string card)
        {
            int power = 0;
            List<char> chars = new List<char>() { ' ', 'C', 'D', 'H', 'S' };
            char cardPower = card[card.Length-1];
            if (card[0] >= '2' && card[0] <= '9')
            {
                power += ((int)card[0]-48) * chars.FindIndex(s => s == cardPower);
            }
            else if (card[0] == '1')
            {
                power += 10 * chars.FindIndex(s => s == cardPower);
            }
            else if (card[0] == 'J')
            {
                power += 11 * chars.FindIndex(s => s == cardPower);
            }
            else if (card[0] == 'Q')
            {
                power += 12 * chars.FindIndex(s => s == cardPower);
            }
            else if (card[0] == 'K')
            {
                power += 13 * chars.FindIndex(s => s == cardPower);
            }
            else if (card[0] == 'A')
            {
                power += 14 * chars.FindIndex(s => s == cardPower);
            }
            return power;
        }
    }
}
