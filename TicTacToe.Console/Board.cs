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
        _boardState = "[X][ ][ ][ ][ ][ ][ ][ ][ ]";
    }
}