using System.Numerics;

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
        winner = CheckWinnerByColumn();
        if (!string.IsNullOrEmpty(winner))
        {
            return winner;
        }
        winner = CheckWinnerByDiagonal();
        if (!string.IsNullOrEmpty(winner))
        {
            return winner;
        }
        return _value.Cast<string?>().Aggregate(string.Empty, (current, item) => current + item);
    }

    private string CheckWinnerByDiagonal()
    {
        if (_value[0, 0].Contains("X") && _value[1, 1].Contains("X") && _value[2, 2].Contains("X"))
        {
            return "Player X WIN!";
        }

        if (_value[0, 0].Contains("Y") && _value[1, 1].Contains("Y") && _value[2, 2].Contains("Y"))
        {
            return "Player Y WIN!";
        }

        if (_value[0, 2].Contains("X") && _value[1, 1].Contains("X") && _value[2, 0].Contains("X"))
        {
            return "Player X WIN!";
        }

        if (_value[0, 2].Contains("Y") && _value[1, 1].Contains("Y") && _value[2, 0].Contains("Y"))
        {
            return "Player Y WIN!";
        }

        return string.Empty;
    }

    private string CheckWinnerByColumn()
    {
        if (_value[0, 0] != "[ ]" && _value[0, 0] == _value[1, 0] && _value[0, 0] == _value[2, 0])
        {
            return $"Player {_value[0, 0].Replace("[", "").Replace("]", "")} WIN!";
        }
        if (_value[0, 1] != "[ ]" && _value[0, 1] == _value[1, 1] && _value[0, 1] == _value[2, 1])
        {
            return $"Player {_value[0, 1].Replace("[", "").Replace("]", "")} WIN!";
        }
        if (_value[0, 2] != "[ ]" && _value[0, 2] == _value[1, 2] && _value[0, 2] == _value[2, 2])
        {
            return $"Player {_value[0, 2].Replace("[", "").Replace("]", "")} WIN!";
        }

        return string.Empty;
    }

    private string CheckWinnerByRow()
    {
        if (_value[0, 0] != "[ ]" && _value[0, 0] == _value[0, 1] && _value[0, 0] == _value[0, 2])
        {
            return $"Player {_value[0, 0].Replace("[","").Replace("]","")} WIN!";
        }
        if (_value[1, 0] != "[ ]" && _value[1, 0] == _value[1, 1] && _value[1, 0] == _value[1, 2])
        {
            return $"Player {_value[1, 0].Replace("[", "").Replace("]", "")} WIN!";
        }
        if (_value[2, 0] != "[ ]" && _value[2, 0] == _value[2, 1] && _value[2, 0] == _value[2, 2])
        {
            return $"Player {_value[2, 0].Replace("[", "").Replace("]", "")} WIN!";
        }

        return string.Empty;
    }

    public void AddMotion(Token token, Position position)
    {
        _value[position.X, position.Y] = $"[{token}]";
    }
}