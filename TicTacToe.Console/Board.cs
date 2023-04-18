namespace TicTacToe.Console;

public class Board
{
    private readonly string[,] _value;

    public Board()
    {
        _value = new[,] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
    }

    public string Print()
    {
        return _value.Cast<string?>().Aggregate(string.Empty, (current, item) => current + item);
    }

    public void AddMotion(Token token, Position position)
    {
        _value[position.X, position.Y] = $"[{token}]";
    }
}