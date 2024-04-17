using GameBoard.Interfaces;
using GameBoard.Factories;

using static System.Console;

namespace GameBoard.Games
{
    namespace GameBoard.Games
    {

        public class Save
        {
            private static string file = "save_game.txt";
            private static Piece piece;


            public static void SaveGame(IBoard board)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    // Save board size
                    writer.WriteLine(board.Size);

                    // Save board state
                    for (int i = 0; i < board.Size; i++)
                    {
                        piece = Piece.Empty; 
                        board.MakeMove(i, piece);
                    }
                }
                WriteLine("Game saved successfully!");
            }
        }
    }
}
