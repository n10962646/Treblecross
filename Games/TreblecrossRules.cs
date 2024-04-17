using GameBoard.Factories;
using GameBoard.Interfaces;

namespace GameBoard.Games
{
    public class TrebleCrossRules : IRules
    {
        public bool CheckWin(IBoard board)
        {

            for (int i = 0; i <= board.Size - 3; i++)
            {
                if ((board.GetCell(i) == Piece.Player || board.GetCell(i) == Piece.Computer) &&
                    (board.GetCell(i + 1) == Piece.Player || board.GetCell(i + 1) == Piece.Computer) &&
                    (board.GetCell(i + 2) == Piece.Player || board.GetCell(i + 2) == Piece.Computer))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
