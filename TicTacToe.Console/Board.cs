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

    public void InsertMotion(string token)
    {
        if (token == "X")
        {
            _boardState = "[X][ ][ ][ ][ ][ ][ ][ ][ ]";
        }
        else
        {
            _boardState = "[ ][Y][ ][ ][ ][ ][ ][ ][ ]";
        }
    }
}