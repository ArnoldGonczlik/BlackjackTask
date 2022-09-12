using System;
namespace Blackjack {
    public class Player {
        private List<KeyValuePair<int, string>> _hand = new List<KeyValuePair<int, string>>();
        private Card _card = new Card();

        public Player() {
            _hand.Add(_card.getRandomCard());
            _hand.Add(_card.getRandomCard());
        }

        public List<KeyValuePair<int, string>> getCards () {
            return _hand;
        }

        public int getCardTotal() {
            return _hand.Select(x => x.Key).Sum();
        }

        public string showCards() {
             return string.Join(", ", _hand.Select(x => string.Join("",x.Value)));
        }

        public void addCard() {
            _hand.Add(_card.getRandomCard());
        }

        public KeyValuePair<int, string> lastCardPulled() {
            return _hand.Last();
        }
    }
}
