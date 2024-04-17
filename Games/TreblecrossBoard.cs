using GameBoard.Factories;
using GameBoard.Interfaces;
using static System.Console;

namespace GameBoard.Games
{
    public class TreblecrossBoard : IBoard
    {

        private Piece[] board;
        private static string symbol;
        private const char player= 'X';
        private const char computer = 'X';
        private const char empty = ' ';

        public int Size { get { return board.Length; } }

        public TreblecrossBoard(int size)
        {
            board = new Piece[size];
            Initialise();
        }

        public void Initialise()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Piece.Empty;
            }
        }

        public void Display()
        {
            Write("┌");
            for (int i = 0; i < Size - 1; i++)
            {
                Write("───┬");
            }
            WriteLine("───┐");

            for (int i = 0; i < Size; i++)
            {
                Write("│ ");
                SetSymbol(i);
                Write(symbol + " ");
            }
            WriteLine("│");

            Write("└");
            for (int i = 0; i < Size - 1; i++)
            {
                Write("───┴");
            }
            WriteLine("───┘");
        }

        private void SetSymbol(int column)
        {
            if (board[column] == Piece.Player)
            {
                symbol = player.ToString();
            }
            else if (board[column] == Piece.Computer)
            {
                symbol = computer.ToString();
            }
            else
            {
                symbol = empty.ToString();
            }
        }


        public bool IsValidMove(int column)
        {
            return column >= 0 && column < board.Length && board[column] == Piece.Empty;
        }

        public void MakeMove(int column, Piece piece)
        {
            board[column] = piece;
        }

        public Piece GetCell(int column)
        {
            return board[column];
        }
    }
}

