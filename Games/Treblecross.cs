using GameBoard.Players;
using GameBoard.Interfaces;
using GameBoard.Modes;
using static System.Console;

namespace GameBoard.Games
{
    class Treblecross : IGame
    {
        private GameMode game;
        private Player player1;
        private Player player2;
        private int choice;
        private int board;

        public void Start()
        {
            Play();
        }

        public void Play()
        {
            WelcomeMessage();
            DisplayRules();

            choice = ModeChoice();
            if (choice == 3)
            {
                WriteLine("Exiting Treblecross Game...");
                return;
            }

            board = GetBoard();

            StartGame(choice, board);
        }

        private void WelcomeMessage()
        {
            WriteLine("Welcome to Treblecross Game!");
        }

        private void DisplayRules()
        {
            WriteLine("                                            Treblecross Rules                                                       ");
            WriteLine("_________________________________________________________________________________________________________________");
            WriteLine();
            WriteLine("Two players take turns placing the same X piece on a one-dimensional board with 1 x n squares in size, where n is");
            WriteLine("provided by the user at the start of the game. The first player that forms a line of three X pieces in a row wins!");
            WriteLine("");
        }

        private int ModeChoice()
        {
            int choice;
            do
            {
                WriteLine("Select game mode:");
                WriteLine("1. Computer vs. Human");
                WriteLine("2. Human vs. Human");
                WriteLine("3. Exit");
                WriteLine("Enter your choice (1 or 2):");
            } while (!int.TryParse(ReadLine(), out choice) || choice != 1 && choice != 2 && choice != 3);

            return choice;
        }

        private int GetBoard()
        {
            int board;
            do
            {
                WriteLine("Enter the number of columns for the board:");
            } while (!int.TryParse(ReadLine(), out board) || board <= 0);

            return board;
        }

        private void StartGame(int choice, int board)
        {
            Clear();
            game = new GameMode();

            if (choice == 1)
            {
                player1 = new Human();
                game.InitialiseGame(new TreblecrossBoard(board), player1);
                game.StartGame();
            }
            else if (choice == 2)
            {
                player1 = new Human();
                player2 = new Human();
                game.InitialiseGame(new TreblecrossBoard(board), player1, player2);
                game.StartGame();
            }
        }
    }
}
