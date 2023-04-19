namespace TicTacToe.Console;

public class Board
{
    public string[,] Value;
    public int FreeFields;

    public Board()
    {
        Value = new[,] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
        FreeFields = Value.GetLength(0) * Value.GetLength(1);
    }

    public string CheckWinnerByDiagonal()
    {
        return !string.IsNullOrEmpty(CheckFirstDiagonal()) ? CheckFirstDiagonal() :
            !string.IsNullOrEmpty(CheckSecondDiagonal()) ? CheckSecondDiagonal() : string.Empty;
    }

    public string GetWinnerByColumn()
    {
        for (var col = 0; col < Value.GetLength(1); col++)
        {
            if (Value[0, col] != "[ ]" && Value[0, col] == Value[1, col] && Value[1, col] == Value[2, col])
                return FormatMessageWin(new Position(0,col));
        }
        return string.Empty;
    }

    public string GetWinnerByRow()
    {
        for (var row = 0; row < Value.GetLength(0); row++)
        {
            if (Value[row, 0] != "[ ]" && Value[row, 0] == Value[row, 1]
                                                && Value[row, 2] == Value[row, 1])
                return FormatMessageWin(new Position(row, 0));
        }
        return string.Empty;
    }

    public bool IsPositionBusy(Position position)
    {
        return Value[position.X, position.Y] != "[ ]";
    }

    private string CheckFirstDiagonal()
    {
        if (Value[0, 0] != "[ ]" && Value[0, 0] == Value[1, 1] && Value[0, 0] == Value[2, 2])
        {
            return FormatMessageWin(new Position(0,0));
        }
        return string.Empty;
    }

    private string CheckSecondDiagonal()
    {
        if (Value[0, 2] != "[ ]" && Value[0, 2] == Value[1, 1] && Value[0, 2] == Value[2, 0])
        {
            return FormatMessageWin(new Position(0, 2));
        }
        return string.Empty;
    }

    private string FormatMessageWin(Position position)
    {
        return $"Player {Value[position.X, position.Y].Replace("[", "").Replace("]", "")} WIN!";
    }
}