using GameBoard.Factories;

namespace GameBoard.Interfaces
{
    public interface IBoard
    {
        int Size { get; }
        void Initialise();
        void Display();
        bool IsValidMove(int column);
        void MakeMove(int column, Piece piece);
        Piece GetCell(int column);
    }
}
