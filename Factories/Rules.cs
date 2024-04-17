using GameBoard.Games;
using GameBoard.Interfaces;

namespace GameBoard.Factories
{
    public class Rules
    {
        public IRules CreateRules()
        {
            return new TrebleCrossRules();
        }
    }
}
