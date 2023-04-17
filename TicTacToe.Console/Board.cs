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

    public void InsertMotion(string token, int i1, int i)
    {
        if (token == "X")
        {
            if (i1 == 0 && i == 2)
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
            _boardState = "[ ][Y][ ][ ][ ][ ][ ][ ][ ]";
        }
    }
}