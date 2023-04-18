using FluentAssertions;
using TicTacToe.Console;

namespace TicTacToe.Test
{
    public class BoardShould
    {
        private Board _board;

        [SetUp]
        public void Setup()
        {
            _board = new Board();
        }

        [Test]
        public void GetEmptyBoardWhenRoundStart()
        {
            var result = _board.Print();

            result.Should().Be("[ ][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerX()
        {
            _board.AddMotion(Token.X, new Position(0, 0));

            var result = _board.Print();

            result.Should().Be("[X][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerY()
        {
            _board.AddMotion(Token.Y, new Position(0, 1));

            var result = _board.Print();

            result.Should().Be("[ ][Y][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerX()
        {
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(0, 2));

            var result = _board.Print();

            result.Should().Be("[X][ ][X][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerY()
        {
            _board.AddMotion(Token.Y, new Position(0, 1));
            _board.AddMotion(Token.Y, new Position(1, 0));

            var result = _board.Print();

            result.Should().Be("[ ][Y][ ][Y][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertThirdMotionForPlayerX()
        {
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(0, 2));
            _board.AddMotion(Token.X, new Position(1, 1));

            var result = _board.Print();

            result.Should().Be("[X][ ][X][ ][X][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertThirdMotionForPlayerY()
        {
            _board.AddMotion(Token.Y, new Position(0, 1));
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(1, 2));

            var result = _board.Print();

            result.Should().Be("[ ][Y][ ][Y][ ][Y][ ][ ][ ]");
        }

        [Test]
        public void WinPlayerXByFirstRow()
        {
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.X, new Position(0, 1));
            _board.AddMotion(Token.Y, new Position(1, 2));
            _board.AddMotion(Token.X, new Position(0, 2));

            var result = _board.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstRow()
        {
            _board.AddMotion(Token.Y, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(0, 1));
            _board.AddMotion(Token.X, new Position(1, 2));
            _board.AddMotion(Token.Y, new Position(0, 2));

            var result = _board.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXBySecondRow()
        {
            _board.AddMotion(Token.X, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(1, 1));
            _board.AddMotion(Token.Y, new Position(2, 0));
            _board.AddMotion(Token.X, new Position(1, 2));

            var result = _board.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondRow()
        {
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.Y, new Position(1, 1));
            _board.AddMotion(Token.X, new Position(2, 0));
            _board.AddMotion(Token.Y, new Position(1, 2));

            var result = _board.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXByThirdRow()
        {
            _board.AddMotion(Token.X, new Position(2, 0));
            _board.AddMotion(Token.Y, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(2, 1));
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.X, new Position(2, 2));

            var result = _board.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByThirdRow()
        {
            _board.AddMotion(Token.Y, new Position(2, 0));
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.Y, new Position(2, 1));
            _board.AddMotion(Token.X, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(2, 2));

            var result = _board.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXByFirstColumn()
        {
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.Y, new Position(0, 1));
            _board.AddMotion(Token.X, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(1, 1));
            _board.AddMotion(Token.X, new Position(2, 0));

            var result = _board.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstColumn()
        {
            _board.AddMotion(Token.Y, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(0, 1));
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.X, new Position(1, 1));
            _board.AddMotion(Token.Y, new Position(2, 0));

            var result = _board.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXBySecondColumn()
        {
            _board.AddMotion(Token.X, new Position(0, 1));
            _board.AddMotion(Token.Y, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(1, 1));
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.X, new Position(2, 1));

            var result = _board.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondColumn()
        {
            _board.AddMotion(Token.Y, new Position(0, 1));
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.Y, new Position(1, 1));
            _board.AddMotion(Token.X, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(2, 1));

            var result = _board.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXByThirdColumn()
        {
            _board.AddMotion(Token.X, new Position(0, 2));
            _board.AddMotion(Token.Y, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(1, 2));
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.X, new Position(2, 2));

            var result = _board.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByThirdColumn()
        {
            _board.AddMotion(Token.Y, new Position(0, 2));
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.Y, new Position(1, 2));
            _board.AddMotion(Token.X, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(2, 2));

            var result = _board.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXByFirstDiagonal()
        {
            _board.AddMotion(Token.X, new Position(0, 0));
            _board.AddMotion(Token.Y, new Position(0, 1));
            _board.AddMotion(Token.X, new Position(1, 1));
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.X, new Position(2, 2));

            var result = _board.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstDiagonal()
        {
            _board.AddMotion(Token.Y, new Position(0, 0));
            _board.AddMotion(Token.X, new Position(0, 1));
            _board.AddMotion(Token.Y, new Position(1, 1));
            _board.AddMotion(Token.X, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(2, 2));

            var result = _board.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXBySecondDiagonal()
        {
            _board.AddMotion(Token.X, new Position(0, 2));
            _board.AddMotion(Token.Y, new Position(0, 1));
            _board.AddMotion(Token.X, new Position(1, 1));
            _board.AddMotion(Token.Y, new Position(1, 0));
            _board.AddMotion(Token.X, new Position(2, 0));

            var result = _board.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondDiagonal()
        {
            _board.AddMotion(Token.Y, new Position(0, 2));
            _board.AddMotion(Token.X, new Position(0, 1));
            _board.AddMotion(Token.Y, new Position(1, 1));
            _board.AddMotion(Token.X, new Position(1, 0));
            _board.AddMotion(Token.Y, new Position(2, 0));

            var result = _board.Print();

            result.Should().Be("Player Y WIN!");
        }
    }
}