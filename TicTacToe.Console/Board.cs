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
        var winner = CheckWinnerByRow();
        if (!string.IsNullOrEmpty(winner))
        {
            return winner;
        }
        return _value.Cast<string?>().Aggregate(string.Empty, (current, item) => current + item);
    }

    private string CheckWinnerByRow()
    {
        if (_value[0, 0].Contains("X") && _value[0, 1].Contains("X") && _value[0, 2].Contains("X"))
        {
            return "Player X WIN!";
        }

        if (_value[0, 0].Contains("Y") && _value[0, 1].Contains("Y") && _value[0, 2].Contains("Y"))
        {
            return "Player Y WIN!";
        }

        if (_value[1, 0].Contains("X") && _value[1, 1].Contains("X") && _value[1, 2].Contains("X"))
        {
            return "Player X WIN!";
        }

        return string.Empty;
    }

    public void AddMotion(Token token, Position position)
    {
        _value[position.X, position.Y] = $"[{token}]";
    }
}