namespace TicTacToe.Console;

public class Position
{
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get;}
    public int Y { get;}

    public bool CheckValidPosition()
    {
        if (X is > 2 or < 0) return true;
        return Y is > 2 or < 0;
    }
}