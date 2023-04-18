namespace TicTacToe.Console;

public class Game
{

    private readonly Board Board;

    public Game()
    {
        Board = new Board();
    }

    public string Print()
    {
        var winner = Board.CheckWinnerByRow();
        if (!string.IsNullOrEmpty(winner))
        {
            return winner;
        }
        winner = Board.CheckWinnerByColumn();
        if (!string.IsNullOrEmpty(winner))
        {
            return winner;
        }
        winner = Board.CheckWinnerByDiagonal();
        if (!string.IsNullOrEmpty(winner))
        {
            return winner;
        }
        return Board.Value.Cast<string?>().Aggregate(string.Empty, (current, item) => current + item);
    }

    public void AddMotion(Token token, Position position)
    {
        Board.Value[position.X, position.Y] = $"[{token}]";
    }
}