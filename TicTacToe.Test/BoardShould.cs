using FluentAssertions;
using TicTacToe.Console;

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
            var board = new Board();

            var result = board.Print();

            result.Should().Be("[ ][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerX()
        {
            var board = new Board();

            board.InsertMotion("X", 0, 0);
            var result = board.Print();

            result.Should().Be("[X][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerY()
        {
            var board = new Board();

            board.InsertMotion("Y", 0, 1);
            var result = board.Print();

            result.Should().Be("[ ][Y][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerX()
        {
            var board = new Board();

            board.InsertMotion("X", 0, 0);
            board.InsertMotion("X", 0, 2);
            var result = board.Print();

            result.Should().Be("[X][ ][X][ ][ ][ ][ ][ ][ ]");
        }
    }
}