using GameBoard.Interfaces;
using GameBoard.Games;
using static System.Console;


namespace GameBoard.Factories
{
    public static class Help
    {
        private static string type; 
        public static IHelp GetHelp(string type)
        {
            switch (type.ToLower())
            {
                case "treblecross":
                    return new TreblecrossHelp();
                default:
                    WriteLine("Help not available for the specified game.");

                    return null;
            }
        }
    }
}
