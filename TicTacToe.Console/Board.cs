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
        return _boardState.Cast<string?>().Aggregate(string.Empty, (current, item) => current + item);
    }

    public void AddMotion(Token token, Position position)
    {
        _boardState[position.X, position.Y] = $"[{token}]";
    }
}