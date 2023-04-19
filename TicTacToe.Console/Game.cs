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
            !string.IsNullOrEmpty(_board.CheckWinnerByDiagonal()) ? _board.CheckWinnerByDiagonal() : string.Empty;
    }

    public void AddMotion(Token token, Position position)
    {
        if (token != _tokenTurn)
        {
            throw new Exception("Invalid movement!");
        }
        IsValidMovement(position);
        _board.Value[position.X, position.Y] = $"[{token}]";
        ChangeTurn();
    }

    private void IsValidMovement(Position position)
    {
        if (position.CheckValidPosition() || _board.IsPositionBusy(position))
        {
            throw new Exception("Invalid movement!");
        }
    }

    private void ChangeTurn()
    {
        if (_tokenTurn == Token.X)
        {
            _tokenTurn = Token.Y;
            return;
        }

        if (_tokenTurn == Token.Y)
        {
            _tokenTurn = Token.X;
        }
    }
}