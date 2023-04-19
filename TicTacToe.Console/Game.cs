namespace TicTacToe.Console;

public class Game
{
    private readonly Board _board;
    private Token _tokenTurn;

    public Game()
    {
        _board = new Board();
        _tokenTurn = Token.X;
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
        return !string.IsNullOrEmpty(_board.GetWinnerByRow()) ? _board.GetWinnerByRow() :
            !string.IsNullOrEmpty(_board.GetWinnerByColumn()) ? _board.GetWinnerByColumn() :
            !string.IsNullOrEmpty(_board.CheckWinnerByDiagonal()) ? _board.CheckWinnerByDiagonal() :
            _board.FreeFields == 0 ? "Draw!" : string.Empty;
    }

    public void AddMotion(Position position)
    {
        if (position.CheckValidPosition() || _board.IsPositionBusy(position))
        {
            throw new Exception("Invalid movement!");
        }
        SetTurn(position);
    }

    private void SetTurn(Position position)
    {
        _board.Value[position.X, position.Y] = $"[{_tokenTurn}]";
        _board.FreeFields--;
        _tokenTurn = _tokenTurn == Token.X ? Token.Y : Token.X;
    }
}