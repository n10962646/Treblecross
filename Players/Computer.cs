using GameBoard.Interfaces;

namespace GameBoard.Players
{
    public class Computer : Player
    {
        private Random random = new Random();
        private int column;

        public override void RecordMove()
        {
        }

        public override void UndoMove(IBoard board)
        {
        }

        public override void RedoMove(IBoard board)
        {
        }

        public int GetMove(IBoard board)
        {
            do
            {
                column = random.Next(0, board.Size);
            } while (!board.IsValidMove(column));

            return column;
        }
    }
}
