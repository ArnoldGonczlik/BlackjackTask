using System;
using System.Collections.Generic;
namespace Blackjack {
    internal class Card {
        List<KeyValuePair<int, string>> cards = new List<KeyValuePair<int, string>>();
        public Card() {
            cards.Add(new KeyValuePair<int, string>(1, "One"));
            cards.Add(new KeyValuePair<int, string>(2, "Two"));
            cards.Add(new KeyValuePair<int, string>(3, "Three"));
            cards.Add(new KeyValuePair<int, string>(4, "Four"));
            cards.Add(new KeyValuePair<int, string>(5, "Five"));
            cards.Add(new KeyValuePair<int, string>(6, "Six"));
            cards.Add(new KeyValuePair<int, string>(7, "Seven"));
            cards.Add(new KeyValuePair<int, string>(8, "Eight"));
            cards.Add(new KeyValuePair<int, string>(9, "Nine"));
            cards.Add(new KeyValuePair<int, string>(10, "Ten"));
            cards.Add(new KeyValuePair<int, string>(10, "Jack"));
            cards.Add(new KeyValuePair<int, string>(10, "Queen"));
            cards.Add(new KeyValuePair<int, string>(10, "King"));
            cards.Add(new KeyValuePair<int, string>(11, "Ace"));
        }

        public KeyValuePair<int, string> getRandomCard() {
            Random rnd = new Random();

            return cards[rnd.Next(cards.Count)];
        }
    }
}
