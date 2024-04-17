using GameBoard.Factories;
using GameBoard.Games;
using GameBoard.Interfaces;

namespace GameBoard.Files
{
    public class Load
    {
        private static string file = "save_game.txt";
        private static int size;
        private static Piece piece;


        public static IBoard LoadGame()
        {
            string[] lines = File.ReadAllLines(file);
            size = int.Parse(lines[0]);

            TreblecrossBoard board = new TreblecrossBoard(size);

            for (int i = 0; i < size; i++)
            {
                piece = Piece.Empty;
                board.MakeMove(i, piece);
            }

            Console.WriteLine("Game loaded successfully!");
            return board;
        }
    }
}
