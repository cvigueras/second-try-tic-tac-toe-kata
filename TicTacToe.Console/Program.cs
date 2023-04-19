using TicTacToe.Console;

var game = new Game();
Console.WriteLine("   ===============================");
Console.WriteLine("     Welcome to TIC TAC TOE Game");
Console.WriteLine("   ===============================");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("    The big game begins:");
while (game.Board.FreeFields > 0)
{
    Console.WriteLine();
    Console.WriteLine($"    Player turn {game.Token}");
    Console.Write("    Write the coordinates in which you want to position your token (Example (0,0):");
    var movement = Console.ReadLine();
    try
    {
        if (movement != null && movement.Contains(","))
        {
            var coordinates = movement.Split(',');
            var position = new Position(Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1]));
            game.AddMotion(position);
            var status = game.GetStatus();
            if (!status.Contains("["))
            {
                Console.Clear();
                PrintBoard(game);
                Console.WriteLine();
                Console.WriteLine(status);
                Console.ReadLine();
                break;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Press a key to continue.");
        Console.ReadLine();
    }

    Console.Clear();
    PrintBoard(game);
}


void PrintBoard(Game newGame)
{
    for (var i = 0; i < newGame.Board.Value.GetLength(0); i++)
    {
        Console.WriteLine(Environment.NewLine);
        for (var j = 0; j < newGame.Board.Value.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write("            " + newGame.Board.Value[i, j]);
            }
            else
            {
                Console.Write("  " + newGame.Board.Value[i, j]);
            }
        }
    }
    Console.WriteLine();
}