namespace TicTacToe.Console;

public class Board
{
    private string _boardState;

    public Board()
    {
        _boardState = "[ ][ ][ ][ ][ ][ ][ ][ ][ ]";
    }

    public string Print()
    {
        return _boardState;
    }

    public void InsertMotion(string token, int x, int y)
    {
        if (token == "X")
        {
            if (x == 0 && y == 2)
            {
                _boardState = "[X][ ][X][ ][ ][ ][ ][ ][ ]";
            }
            else
            {
                _boardState = "[X][ ][ ][ ][ ][ ][ ][ ][ ]";
            }
        }
        else
        {
            if (x == 1 && y == 0)
            {
                _boardState = "[ ][Y][ ][Y][ ][ ][ ][ ][ ]";
            }
            else
            {
                _boardState = "[ ][Y][ ][ ][ ][ ][ ][ ][ ]";
            }
        }
    }
}