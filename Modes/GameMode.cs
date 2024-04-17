using GameBoard.Players;
using GameBoard.Factories;
using GameBoard.Interfaces;
using static System.Console;
using GameBoard.Games;
using GameBoard.Files;
using GameBoard.Games.GameBoard.Games;


namespace GameBoard.Modes
{
    public class GameMode
    {
        private IBoard board;
        private IRules logic;

        private Player human1;
        private Player human2;
        private Player currentPlayer;
        private Computer computer;
        private TreblecrossHelp help;

        private bool isHuman;
        private static string input;
        private static int column;




        public void InitialiseGame(IBoard boardSize, Player player1, Player player2 = null)
        {
            board = boardSize;
            human1 = player1;
            human2 = player2;
            if (player2 == null)
            {
                computer = new Computer();
            }
            else
            {
                computer = null;
            }
            logic = new Rules().CreateRules();
        }

        public void StartGame()
        {
            if (human2 == null)
            {
                ComputervsHuman();
            }
            else
            {
                HumanVsHuman();
            }
        }

        private void ComputervsHuman()
        {
            while (true)
            {

                board.Display();

                Player currentPlayer = Player.CreatePlayer(isHuman, human1, human2);

                WriteLine($"Enter your move (0-{board.Size - 1}), 'u' to undo, 'r' to redo, 's' to save, 'l' to load or 'h' for help:");
                input = ReadLine();

                if (input == "h")
                {
                    help = new TreblecrossHelp();
                    help.DisplayHelp();
                    continue;
                }

                else if (input == "u")
                {
                    currentPlayer.UndoMove(board);
                    continue;

                }

                else if (int.TryParse(input, out column))
                {
                    if (board.IsValidMove(column))
                    {
                        board.MakeMove(column, Piece.Player);
                        currentPlayer.RecordMove();
                        
                        if (logic.CheckWin(board))
                        {
                            board.Display();
                            WriteLine("You won!");
                            return;
                        }
                    }                                      
                    
                    else
                    {
                        WriteLine("Invalid move! Please try again.");
                    }                    

                }

                else if (input == "r")
                {
                    currentPlayer.RedoMove(board);
                    continue;
                }

                else if (input == "s")
                {
                    Save.SaveGame(board);
                    continue;
                }
                else if (input == "l")
                {
                    board = Load.LoadGame();
                    continue;
                }

                else
                {
                    WriteLine("Invalid input! Please enter a valid column number (0-9), 'u' to undo, 'r' to redo or 'h' for help.");
                    continue;

                }

                int computerMove = computer.GetMove(board);
                board.MakeMove(computerMove, Piece.Computer);

                if (logic.CheckWin(board))
                {
                    board.Display();
                    WriteLine("Computer won!");
                    return;
                }
            }
        }

        private void HumanVsHuman()
        {
            while (true)
            {
                Clear();

                board.Display();

                currentPlayer = Player.CreatePlayer(isHuman, human1, human2);

                WriteLine($"Player {Piece.Player}, enter your move (0-{board.Size - 1}), 'u' to undo, 'r' to redo or 'h' for help:");
                input = ReadLine();

                if (input == "h")
                {
                    help = new TreblecrossHelp();
                    help.DisplayHelp();
                    continue;
                }

                else if (input == "u")
                {
                    currentPlayer.UndoMove(board);
                    continue;

                }             


                if (int.TryParse(input, out column))
                {
                    if (board.IsValidMove(column))
                    {
                        board.MakeMove(column, Piece.Player);
                        currentPlayer.RecordMove();
                 
                        if (logic.CheckWin(board))
                        {
                            board.Display();
                            WriteLine("You won!");
                            return;
                        }

                    }
                    else
                    {
                        WriteLine("Invalid move! Please try again.");
                    }                   
                }

                else if (input == "r")
                {
                    currentPlayer.RedoMove(board);
                    continue;

                }

                else if (input == "s")
                {
                    Save .SaveGame(board);
                    continue;
                }
                else if (input == "l")
                {
                    board = Load.LoadGame();
                    continue;
                }

                else
                {
                    WriteLine("Invalid input! Please enter a valid column number (0-9), 'u' to undo, ''r' to redo or 'h' for help.");
                    continue;

                }
            }
        }

    }
}
