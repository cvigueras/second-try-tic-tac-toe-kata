using TicTacToe.Console;

var currentGame = new CurrentGame(new Game());
currentGame.PrintHeader();

while (currentGame.Game.Board.FreeFields > 0)
{
    currentGame.PrintHeaderTurn();
    var movement = Console.ReadLine();
    try
    {
        if (movement!.Contains(","))
        {
            currentGame.Game.AddMotion(currentGame.GetPosition(movement));
            if (currentGame.PrintIfHasWinner()) break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Press a key to continue.");
        Console.ReadLine();
    }

    Console.Clear();
    currentGame.PrintBoard();
}