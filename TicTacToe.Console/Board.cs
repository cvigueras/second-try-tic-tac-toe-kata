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
        return CheckFirstDiagonal() ? FormatMessageWin(new Position(0, 0)) :
            CheckSecondDiagonal() ? FormatMessageWin(new Position(0, 2)) : string.Empty;
    }

    public string CheckWinnerByColumn()
    {
        return CheckFirstColumn() ? FormatMessageWin(new Position(0, 0)) :
            CheckSecondColumn() ? FormatMessageWin(new Position(0, 1)) :
            CheckThirdColumn() ? FormatMessageWin(new Position(0, 2)) : string.Empty;
    }

    public string CheckWinnerByRow()
    {
        return CheckFirstRow() ? FormatMessageWin(new Position(0, 0)) :
            CheckSecondRow() ? FormatMessageWin(new Position(1, 0)) :
            CheckThirdRow() ? FormatMessageWin(new Position(2, 0)) : string.Empty;
    }

    public bool IsPositionBusy(Position position)
    {
        return Value[position.X, position.Y] != "[ ]";
    }

    private bool CheckFirstDiagonal()
    {
        return Value[0, 0] != "[ ]" && Value[0, 0] == Value[1, 1] && Value[0, 0] == Value[2, 2];
    }

    private bool CheckSecondDiagonal()
    {
        return Value[0, 2] != "[ ]" && Value[0, 2] == Value[1, 1] && Value[0, 2] == Value[2, 0];
    }

    private bool CheckFirstRow()
    {
        return Value[0, 0] != "[ ]" && Value[0, 0] == Value[0, 1] && Value[0, 0] == Value[0, 2];
    }

    private bool CheckSecondRow()
    {
        return Value[1, 0] != "[ ]" && Value[1, 0] == Value[1, 1] && Value[1, 0] == Value[1, 2];
    }

    private bool CheckThirdRow()
    {
        return Value[2, 0] != "[ ]" && Value[2, 0] == Value[2, 1] && Value[2, 0] == Value[2, 2];
    }

    private bool CheckFirstColumn()
    {
        return Value[0, 0] != "[ ]" && Value[0, 0] == Value[1, 0] && Value[0, 0] == Value[2, 0];
    }

    private bool CheckSecondColumn()
    {
        return Value[0, 1] != "[ ]" && Value[0, 1] == Value[1, 1] && Value[0, 1] == Value[2, 1];
    }

    private bool CheckThirdColumn()
    {
        return Value[0, 2] != "[ ]" && Value[0, 2] == Value[1, 2] && Value[0, 2] == Value[2, 2];
    }

    private string FormatMessageWin(Position position)
    {
        return $"Player {Value[position.X, position.Y].Replace("[", "").Replace("]", "")} WIN!";
    }
}