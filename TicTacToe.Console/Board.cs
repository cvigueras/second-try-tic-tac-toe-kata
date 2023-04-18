namespace TicTacToe.Console;

public class Board
{
    public string[,] Value;
    public Board()
    {
        Value = new[,] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
    }

    public string CheckWinnerByDiagonal()
    {
        if (Value[0, 0] != "[ ]" && Value[0, 0] == Value[1, 1] && Value[0, 0] == Value[2, 2])
        {
            return $"Player {Value[0, 0].Replace("[", "").Replace("]", "")} WIN!";
        }
        if (Value[0, 2] != "[ ]" && Value[0, 2] == Value[1, 1] && Value[0, 2] == Value[2, 0])
        {
            return $"Player {Value[0, 2].Replace("[", "").Replace("]", "")} WIN!";
        }

        return string.Empty;
    }

    public string CheckWinnerByColumn()
    {
        if (Value[0, 0] != "[ ]" && Value[0, 0] == Value[1, 0] && Value[0, 0] == Value[2, 0])
        {
            return $"Player {Value[0, 0].Replace("[", "").Replace("]", "")} WIN!";
        }
        if (Value[0, 1] != "[ ]" && Value[0, 1] == Value[1, 1] && Value[0, 1] == Value[2, 1])
        {
            return $"Player {Value[0, 1].Replace("[", "").Replace("]", "")} WIN!";
        }
        if (Value[0, 2] != "[ ]" && Value[0, 2] == Value[1, 2] && Value[0, 2] == Value[2, 2])
        {
            return $"Player {Value[0, 2].Replace("[", "").Replace("]", "")} WIN!";
        }

        return string.Empty;
    }

    public string CheckWinnerByRow()
    {
        if (Value[0, 0] != "[ ]" && Value[0, 0] == Value[0, 1] && Value[0, 0] == Value[0, 2])
        {
            return $"Player {Value[0, 0].Replace("[","").Replace("]","")} WIN!";
        }
        if (Value[1, 0] != "[ ]" && Value[1, 0] == Value[1, 1] && Value[1, 0] == Value[1, 2])
        {
            return $"Player {Value[1, 0].Replace("[", "").Replace("]", "")} WIN!";
        }
        if (Value[2, 0] != "[ ]" && Value[2, 0] == Value[2, 1] && Value[2, 0] == Value[2, 2])
        {
            return $"Player {Value[2, 0].Replace("[", "").Replace("]", "")} WIN!";
        }

        return string.Empty;
    }
}