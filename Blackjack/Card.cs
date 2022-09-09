using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
    internal class Card {
        public Cards RandomCard() {
            Random rnd = new Random();
            Array CardArray = Enum.GetValues(typeof(Cards));
            Cards GetCardTest = (Cards)CardArray.GetValue(rnd.Next(CardArray.Length));

            return GetCardTest;
        }
    }

    public enum Cards {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack = 10,
        Queen = 10,
        King = 10,
        Ace
    }


}
