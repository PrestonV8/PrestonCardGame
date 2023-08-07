// this is the mini project for modifiers, abstract classes, and overrides
using ConsoleUI.Enums;
using ConsoleUI.Models;

namespace ConsoleUI
{
    public abstract class Deck : CardModel
    {
        List<string> cards = new List<string>();
        public int Total { get; set; } = 0;
        public string Name { get; set; }
        public void CreateDeck(Random rnd)
        {
            for (int i = 0; i < 2; i++)
            {
                Suit = GetRandomSuit(rnd);
                Value = GetRandomValue(rnd);
                cards.Add($"{Value} of {Suit}");
                Total = Total + (int)Value;
            }
        }

        public virtual void ShowDeck()
        {
            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine($"\n[{Name}'s Hand Total: {Total}]");
        }

        public virtual void AddCard(Random rnd)
        {
            Suit = GetRandomSuit(rnd);
            Value = GetRandomValue(rnd);
            cards.Add($"***{Value} of {Suit} was added***");
            Total = Total + (int)Value;
        }
    }
}
