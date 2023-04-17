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

            board.AddMotion(Token.X, new Position(0, 0));
            var result = board.Print();

            result.Should().Be("[X][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerY()
        {
            var board = new Board();

            board.AddMotion(Token.Y, new Position(0, 1));
            var result = board.Print();

            result.Should().Be("[ ][Y][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerX()
        {
            var board = new Board();

            board.AddMotion(Token.X, new Position(0, 0));
            board.AddMotion(Token.X, new Position(0, 2));
            var result = board.Print();

            result.Should().Be("[X][ ][X][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerY()
        {
            var board = new Board();

            board.AddMotion(Token.Y, new Position(0, 1));
            board.AddMotion(Token.Y, new Position(1, 0));
            var result = board.Print();

            result.Should().Be("[ ][Y][ ][Y][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertThirdMotionForPlayerX()
        {
            var board = new Board();

            board.AddMotion(Token.X, new Position(0, 0));
            board.AddMotion(Token.X, new Position(0, 2));
            board.AddMotion(Token.X, new Position(1, 1));
            var result = board.Print();

            result.Should().Be("[X][ ][X][ ][X][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertThirdMotionForPlayerY()
        {
            var board = new Board();

            board.AddMotion(Token.Y, new Position(0, 1));
            board.AddMotion(Token.Y, new Position(1, 0));
            board.AddMotion(Token.Y, new Position(1, 2));
            var result = board.Print();

            result.Should().Be("[ ][Y][ ][Y][ ][Y][ ][ ][ ]");
        }
    }
}