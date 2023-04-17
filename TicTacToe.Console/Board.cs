namespace TicTacToe.Console;

public class Board
{
    private string[,] _boardState;

    public Board()
    {
        _boardState = new[,] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
    }

    public string Print()
    {
        string result = string.Empty;
        foreach (var item in _boardState)
        {
            result += item;
        }
        return result;
    }

    public void InsertMotion(string token, int x, int y)
    {
        _boardState[x, y] = $"[{token}]";
    }
}