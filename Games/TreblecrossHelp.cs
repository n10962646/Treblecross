using GameBoard.Interfaces;
using static System.Console;

namespace GameBoard.Games
{
    public class TreblecrossHelp : IHelp
    {
        public void DisplayHelp()
        {
            WriteLine("Welcome to the game!");
            WriteLine("Commands:");
            WriteLine("'u': Undo the last move.");
            WriteLine("'r': Redo the last undone move.");
            WriteLine("Enter a number to make a move.");
        }
    }
}
