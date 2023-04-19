namespace TicTacToe.Console;

public class Game
{
    private readonly Board _board;
    private Token _tokenTurn;
    private int _numberOfPlays;
    private readonly int _maxNumberOfPlays;

    public Game()
    {
        _board = new Board();
        _tokenTurn = Token.X;
        _maxNumberOfPlays = 9;
        _numberOfPlays = 0;
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
            _numberOfPlays == _maxNumberOfPlays ? "Draw!" : string.Empty;
    }

    public void AddMotion(Position position)
    {
        IsValidMovement(position);
        _board.Value[position.X, position.Y] = $"[{_tokenTurn}]";
        SetTurn();
    }

    private void IsValidMovement(Position position)
    {
        if (position.CheckValidPosition() || _board.IsPositionBusy(position))
        {
            throw new Exception("Invalid movement!");
        }
    }

    private void SetTurn()
    {
        _numberOfPlays++;
        switch (_tokenTurn)
        {
            case Token.X:
                _tokenTurn = Token.Y;
                return;
            case Token.Y:
                _tokenTurn = Token.X;
                break;
        }
    }
}