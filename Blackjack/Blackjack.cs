namespace Blackjack {
    internal class Blackjack {
        static void Main(string[] args) {
            Player player = new Player();
            Dealer dealer = new Dealer();
            var bust = false;
            var dealerBust = false;


            Console.WriteLine($"Dealer draw: HIDDEN and {dealer.showCards().Split(", ")[1]}");
            Console.WriteLine();
            Console.WriteLine($"Your draw: {player.showCards()} for a total of {player.getCardTotal()}");

            while (player.getCardTotal() < 21) {
                Console.WriteLine();
                Console.WriteLine("Would you like to hit or stay (h/s)?");
                var userinput = Console.ReadLine();

                if (userinput == "h") {                   
                    player.addCard();
                    Console.WriteLine($"You got {player.lastCardPulled().Value} for a total of {player.getCardTotal()}");
                    //TODO make a method to get the last card pulled to print what was chosen
                } else if (userinput == "s") {
                    Console.WriteLine("You chose to stand");
                    break;
                } else {
                    Console.WriteLine("Invalid input, try again");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Dealers hole card was {dealer.showCards().Split(", ")[0]}, and his total is {dealer.getCardTotal()}");

            //Simple check to see if player busts and break out of game
            if (player.getCardTotal() > 21) {
                Console.WriteLine("You bust, gg");
                bust = true;
            }

            if (player.getCardTotal() == 21) {
                Console.WriteLine("Congratz, you have blackjack!!!!!!!!!!");
            }

            //Write to console just to give space
            Console.WriteLine();

            if (!bust) {
                //First build dealers hand until 17 and then do gamechecks
                while (dealer.getCardTotal() < 17) {
                    dealer.addCard();
                    Console.WriteLine($"Dealer draws {dealer.lastCardPulled().Value} for a total of {dealer.getCardTotal()}");
                }

                Console.WriteLine();
                //Check to see if dealer busts

                if (dealer.getCardTotal() > 21) {
                    dealerBust = true;
                    Console.WriteLine("Dealer busts! You win!");
                }
                

                //If dealer busts player wins

                if (dealer.getCardTotal() == player.getCardTotal() && !dealerBust) {
                    Console.WriteLine("Game is even, money back");
                }
                if (dealer.getCardTotal() < player.getCardTotal() && !dealerBust) {
                    Console.WriteLine("You win gg's");
                }
                if (dealer.getCardTotal() > player.getCardTotal() && !dealerBust) {
                    Console.WriteLine("Dealer wins, unlucky dog");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Game done");


        }
    }
}