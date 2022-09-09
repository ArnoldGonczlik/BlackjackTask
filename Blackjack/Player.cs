using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
    public class Player {
        private Cards _card1;
        private Cards _card2;
        private Cards[] CardsList = new Cards[2];

        public Player() {
            Card card = new Card();
            _card1 = card.RandomCard();
            _card2 = card.RandomCard();

            CardsList[0] = _card1;
            CardsList[1] = _card2;

        }

        public Cards[] getCards () {
            return CardsList;
        }
    }
}
