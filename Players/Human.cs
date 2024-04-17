using GameBoard.Factories;
using GameBoard.Interfaces;

namespace GameBoard.Players
{
    public class Human : Player
    {
        private static int move;
        private int undoMove;
        private int redoMove;

        public override void RecordMove()
        {
            movesHistory.Add(move);
        }

        public override void UndoMove(IBoard board)
        {
            if (movesHistory.Count > 0)
            {
                undoMove = movesHistory[movesHistory.Count - 1];

                undoMoves.Add(undoMove);

                board.MakeMove(undoMove, Piece.Empty);

                movesHistory.RemoveAt(movesHistory.Count - 1);
            }
        }

        public override void RedoMove(IBoard board)
        {
            if (undoMoves.Count > 0)
            {
                redoMove = undoMoves[undoMoves.Count - 1];

                movesHistory.Add(redoMove);

                board.MakeMove(redoMove, Piece.Player);

                undoMoves.RemoveAt(undoMoves.Count - 1);
            }
        }

    }
}
