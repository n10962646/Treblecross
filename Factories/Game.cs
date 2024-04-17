using GameBoard.Games;
using static System.Console;


namespace GameBoard.Factories
{
    public static class Game
    {
        private static Treblecross treblecross;

        public static void Treblecross()
        {
            treblecross = new Treblecross();
            treblecross.Play();
        }

        public static void Chess()
        {
            WriteLine("Game is not implemented yet.");
        }

        public static void Damas()
        {
            WriteLine("Game is not implemented yet.");
        }
    }
}
