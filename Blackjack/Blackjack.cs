using System.Windows.Markup;

namespace Blackjack {
    internal class Blackjack {
        static void Main(string[] args) {
            Player player = new Player();
            Dealer dealer = new Dealer();

            Console.WriteLine($"Player: {player.showCards()} | {player.getCardTotal()}");
            Console.WriteLine($"Dealer: {dealer.showCards()} | {dealer.getCardTotal()}");
        }
    }
}