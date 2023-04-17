using FluentAssertions;

namespace TicTacToe.Test
{
    public class BoardShould
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetEmptyBoardWhenRoundStart()
        {
            var result = Board.Print();

            result.Should().Be("[ ][ ][ ][ ][ ][ ][ ][ ][ ]");
        }
    }

    public class Board
    {
        public static object Print()
        {
            throw new NotImplementedException();
        }
    }
}