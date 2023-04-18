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
        if (_value[0, 0].Contains("X") && _value[0, 1].Contains("X") && _value[0, 2].Contains("X"))
        {
            return "Player X WIN!";
        }
        if (_value[0, 0].Contains("Y") && _value[0, 1].Contains("Y") && _value[0, 2].Contains("Y"))
        {
            return "Player Y WIN!";
        }
        return _value.Cast<string?>().Aggregate(string.Empty, (current, item) => current + item);
    }

    public void AddMotion(Token token, Position position)
    {
        _value[position.X, position.Y] = $"[{token}]";
    }
}