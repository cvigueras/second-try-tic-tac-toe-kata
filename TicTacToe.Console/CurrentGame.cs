namespace TicTacToe.Console
{
    public class CurrentGame
    {
        public CurrentGame(Game game)
        {
            Game = game;
        }

        public Game Game { get; }

        public void PrintHeader()
        {
            System.Console.WriteLine("   ===============================");
            System.Console.WriteLine("     Welcome to TIC TAC TOE Game");
            System.Console.WriteLine("   ===============================");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("    The big game begins:");
        }

        public void PrintBoard()
        {
            for (var i = 0; i < Game.Board.Value.GetLength(0); i++)
            {
                System.Console.WriteLine(Environment.NewLine);
                for (var j = 0; j < Game.Board.Value.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        System.Console.Write("            " + Game.Board.Value[i, j]);
                    }
                    else
                    {
                        System.Console.Write("  " + Game.Board.Value[i, j]);
                    }
                }
            }
            System.Console.WriteLine();
        }

        public void PrintHeaderTurn()
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"    Player turn {Game.Token}");
            System.Console.Write("    Write the coordinates in which you want to position your token (Example (0,0):");
        }

        public Position GetPosition(string movement)
        {
            var coordinates = movement.Split(',');
            var position = new Position(Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1]));
            return position;
        }

        public bool PrintIfHasWinner()
        {
            if (Game.GetStatus().Contains("[")) return false;
            System.Console.Clear();
            PrintBoard();
            System.Console.WriteLine();
            System.Console.WriteLine(Game.GetStatus());
            System.Console.ReadLine();
            return true;
        }
    }
}