using GameBoard.Interfaces;
using GameBoard.Games;

public class Board
{
    protected int size;

    public virtual IBoard CreateBoard(int size)
    {
        this.size = size; 
        return new TreblecrossBoard(size);
    }
}
