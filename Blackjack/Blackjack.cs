using System.Windows.Markup;

namespace Blackjack {
    internal class Blackjack {
        static void Main(string[] args) {
            Player player = new Player();

            foreach (Cards card in player.getCards()) {
                Console.WriteLine(card);
            }
        }
    }
}