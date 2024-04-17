namespace GameBoard.Factories
{
    public class Piece
    {
        public static readonly Piece Empty = new Piece("Empty");
        public static readonly Piece Player = new Piece("Player");
        public static readonly Piece Computer = new Piece("Computer");
        public static readonly Piece Custom1 = new Piece("Custom1");
        public static readonly Piece Custom2 = new Piece("Custom2");

        public string Name { get; }

        private Piece(string name)
        {
            Name = name;
        }
    }
}
