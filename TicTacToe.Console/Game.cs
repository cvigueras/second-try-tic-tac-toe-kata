namespace TicTacToe.Console;

public class Game
{
    private readonly Board _board;

    public Game()
    {
        _board = new Board();
    }

    public string Print()
    {
        return !string.IsNullOrEmpty(CheckWinner())
            ? CheckWinner()
            : _board.Value.Cast<string?>()
                .Aggregate(string.Empty,
                    (current,
                        item) => current + item);
    }

    private string CheckWinner()
    {
        return !string.IsNullOrEmpty(_board.CheckWinnerByRow()) ? _board.CheckWinnerByRow() :
            !string.IsNullOrEmpty(_board.CheckWinnerByColumn()) ? _board.CheckWinnerByColumn() :
            !string.IsNullOrEmpty(_board.CheckWinnerByDiagonal()) ? _board.CheckWinnerByDiagonal() : string.Empty;
    }

    public void AddMotion(Token token, Position position)
    {
        if (position.X > 2 || position.X < 0 || position.Y > 2 || position.Y < 0)
        {
            throw new Exception("Invalid movement!");
        }
        _board.Value[position.X, position.Y] = $"[{token}]";
    }
}