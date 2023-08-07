// this is the mini project for modifiers, abstract classes, and overrides

namespace ConsoleUI
{
    public class BlackJackPlayerActions : Deck
    {
        string userInput = "";
        bool outcome = true;
        public virtual void PlayGame(BlackJackPlayerActions dealer, Random rnd)
        {

            // if either dealer or player starts with 21
            // dealer.CreateDeck(rnd);
            dealer.AddCard(rnd);
            CreateDeck(rnd);
            while (Total <= 21 && userInput.ToLower() != "s")
            {
                Console.WriteLine("DEALER'S HAND:");
                dealer.ShowDeck();

                Console.WriteLine("-----------------------");
                Console.WriteLine($"\nPLAYER'S TURN:");
                ShowDeck();

                // check if either dealer or player are at 21
                if (dealer.Total == 21)
                {
                    CheckOutcome(dealer);
                    Console.Clear();
                    break;
                }
                else if (Total == 21)
                {
                    CheckOutcome(dealer);
                    Console.Clear();
                    outcome = false;
                    break;
                }

                Console.Write("Would you like to Hit or Stand? (h/s) ");
                userInput = Console.ReadLine();
                if (userInput.ToLower().Contains("h"))
                {
                    AddCard(rnd);
                }
                Console.Clear();
            }

            if (outcome == true)
            {
                Console.WriteLine("PLAYER'S HAND");
                ShowDeck();

                Console.WriteLine("===================================\nDEALER'S TURN");

                // Dealer's Turn
                while (dealer.Total < 17) // Dealer MUST draw a card if below 17
                {
                    dealer.AddCard(rnd);
                }
                dealer.ShowDeck();
                CheckOutcome(dealer);
            }
        }

        public virtual void CheckOutcome(BlackJackPlayerActions dealer)
        {
            // Lose: 
            if ((Total == 21 && dealer.Total == 21) || Total == dealer.Total || (Total > 21 && dealer.Total > 21))
            {
                Console.WriteLine("\n\n...DRAW...");
                Console.ReadLine();
            }
            else if (Total > 21 || (Total < dealer.Total && dealer.Total <= 21))
            {
                Console.WriteLine("\n\nYou Lose...");
                Console.ReadLine();
            }
            else if ((Total <= 21 && Total > dealer.Total) || Total == 21 || dealer.Total > 21)
            {
                Console.WriteLine("\n\nYou Win!!!");
                Console.ReadLine();
            }
        }
    }
}
