using GameBoard.Interfaces;

namespace GameBoard.Players
{
    public abstract class Player
    {
        protected List<int> movesHistory = new List<int>();
        protected List<int> undoMoves = new List<int>();

        public abstract void RecordMove();
        public abstract void UndoMove(IBoard board);
        public abstract void RedoMove(IBoard board);

        public static Player CreatePlayer(bool isHuman, Player human1, Player human2)
        {
            if (isHuman || human2 == null)
            {
                return human1;
            }
            else
            {
                return human2;
            }
        }
    }
}

