using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
    internal class Dealer {
        private List<KeyValuePair<int, string>> _hand = new List<KeyValuePair<int, string>>();
        private Card _card = new Card();

        public Dealer() {
            _hand.Add(_card.getRandomCard());
            _hand.Add(_card.getRandomCard());
        }

        public List<KeyValuePair<int, string>> getCards() {
            return _hand;
        }

        public int getCardTotal() {
            return _hand.Select(x => x.Key).Sum();
        }

        public string showCards() {
            return string.Join(", ", _hand.Select(x => string.Join("", x.Value)));
        }

        public void addCard() {
            _hand.Add(_card.getRandomCard());
        }
    }
}
