using GameBoard.Factories;
using static System.Console;

namespace GameBoard
{
    class Program
    {
        private static string input;
        private static bool exit;


        static void Main()
        {
           
            exit = false;

            while (!exit)
            {
                WriteLine("Welcome to the Game Board options:");
                WriteLine("1. Treblecross");
                WriteLine("2. Chess");
                WriteLine("3. Damas");
                WriteLine("4. Exit");

                Write("Please choose an option: ");
                input = ReadLine();

                switch (input)
                {
                    case "1":
                        Game.Treblecross();
                        break;
                    case "2":
                        Game.Chess();
                        break;
                    case "3":
                        Game.Damas();
                        break;
                    case "4":
                        exit = true;
                        WriteLine("Exiting the program.");
                        break;
                    default:
                        WriteLine("Invalid option. Please try again.");
                        break;
                }

                WriteLine();
            }          
        }

    }
}


