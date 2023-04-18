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
            return FormatMessageWin(new Position(0, 0));
        }
        if (Value[0, 2] != "[ ]" && Value[0, 2] == Value[1, 1] && Value[0, 2] == Value[2, 0])
        {
            return FormatMessageWin(new Position(0, 2));
        }

        return string.Empty;
    }

    public string CheckWinnerByColumn()
    {
        if (Value[0, 0] != "[ ]" && Value[0, 0] == Value[1, 0] && Value[0, 0] == Value[2, 0])
        {
            return FormatMessageWin(new Position(0, 0));
        }
        if (Value[0, 1] != "[ ]" && Value[0, 1] == Value[1, 1] && Value[0, 1] == Value[2, 1])
        {
            return FormatMessageWin(new Position(0, 1));
        }
        if (Value[0, 2] != "[ ]" && Value[0, 2] == Value[1, 2] && Value[0, 2] == Value[2, 2])
        {
            return FormatMessageWin(new Position(0, 2));
        }

        return string.Empty;
    }

    private string FormatMessageWin(Position position)
    {
        return $"Player {Value[position.X, position.Y].Replace("[", "").Replace("]", "")} WIN!";
    }

    public string CheckWinnerByRow()
    {
        if (Value[0, 0] != "[ ]" && Value[0, 0] == Value[0, 1] && Value[0, 0] == Value[0, 2])
        {
            return FormatMessageWin(new Position(0, 0));
        }
        if (Value[1, 0] != "[ ]" && Value[1, 0] == Value[1, 1] && Value[1, 0] == Value[1, 2])
        {
            return FormatMessageWin(new Position(1, 0));
        }
        if (Value[2, 0] != "[ ]" && Value[2, 0] == Value[2, 1] && Value[2, 0] == Value[2, 2])
        {
            return FormatMessageWin(new Position(2, 0));
        }

        return string.Empty;
    }
}