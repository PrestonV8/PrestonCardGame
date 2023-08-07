// this is the mini project for modifiers, abstract classes, and overrides

using ConsoleUI.Enums;

namespace ConsoleUI.Models
{
    public abstract class ShuffleModel
    {
        public CardSuitEnum GetRandomSuit(Random random)
        {
            int enumCount = Enum.GetValues(typeof(CardSuitEnum)).Length;
            int randomIndex = random.Next(0, enumCount);
            CardSuitEnum suitValue = (CardSuitEnum)randomIndex;
            return suitValue;
        }

        public CardValueEnum GetRandomValue(Random random)
        {
            int enumCount = Enum.GetValues(typeof(CardValueEnum)).Length;
            int randomIndex = random.Next(1, enumCount);
            CardValueEnum cardValue = (CardValueEnum)randomIndex;
            return cardValue;
        }
    }

}
