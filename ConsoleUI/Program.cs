// this is the mini project for modifiers, abstract classes, and overrides

using ConsoleUI.Enums;
using ConsoleUI.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string toQuit = "";
            var rnd = new Random();

            while (true)
            {
                BlackJackPlayerActions player = new BlackJackPlayerActions
                {
                    Name = "Player"
                };
                BlackJackPlayerActions dealer = new BlackJackPlayerActions
                {
                    Name = "Dealer"
                };

                // Let user play game
                player.PlayGame(dealer, rnd);
                Console.Clear();
            }

            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }
    }
}
