// this is the mini project for modifiers, abstract classes, and overrides

using ConsoleUI.Enums;

namespace ConsoleUI.Models
{
    public class CardModel : ShuffleModel
    {
        public CardSuitEnum Suit { get; set; }
        public CardValueEnum Value { get; set; }
    }

}
