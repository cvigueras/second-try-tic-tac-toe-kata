using FluentAssertions;
using TicTacToe.Console;

namespace TicTacToe.Test
{
    public class BoardShould
    {
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void GetEmptyBoardWhenRoundStart()
        {
            var result = _game.Print();

            result.Should().Be("[ ][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerX()
        {
            _game.AddMotion(Token.X, new Position(0, 0));

            var result = _game.Print();

            result.Should().Be("[X][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerY()
        {
            _game.AddMotion(Token.Y, new Position(0, 1));

            var result = _game.Print();

            result.Should().Be("[ ][Y][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerX()
        {
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(0, 2));

            var result = _game.Print();

            result.Should().Be("[X][ ][X][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerY()
        {
            _game.AddMotion(Token.Y, new Position(0, 1));
            _game.AddMotion(Token.Y, new Position(1, 0));

            var result = _game.Print();

            result.Should().Be("[ ][Y][ ][Y][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertThirdMotionForPlayerX()
        {
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(0, 2));
            _game.AddMotion(Token.X, new Position(1, 1));

            var result = _game.Print();

            result.Should().Be("[X][ ][X][ ][X][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertThirdMotionForPlayerY()
        {
            _game.AddMotion(Token.Y, new Position(0, 1));
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(1, 2));

            var result = _game.Print();

            result.Should().Be("[ ][Y][ ][Y][ ][Y][ ][ ][ ]");
        }

        [Test]
        public void WinPlayerXByFirstRow()
        {
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.X, new Position(0, 1));
            _game.AddMotion(Token.Y, new Position(1, 2));
            _game.AddMotion(Token.X, new Position(0, 2));

            var result = _game.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstRow()
        {
            _game.AddMotion(Token.Y, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(0, 1));
            _game.AddMotion(Token.X, new Position(1, 2));
            _game.AddMotion(Token.Y, new Position(0, 2));

            var result = _game.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXBySecondRow()
        {
            _game.AddMotion(Token.X, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(1, 1));
            _game.AddMotion(Token.Y, new Position(2, 0));
            _game.AddMotion(Token.X, new Position(1, 2));

            var result = _game.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondRow()
        {
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.Y, new Position(1, 1));
            _game.AddMotion(Token.X, new Position(2, 0));
            _game.AddMotion(Token.Y, new Position(1, 2));

            var result = _game.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXByThirdRow()
        {
            _game.AddMotion(Token.X, new Position(2, 0));
            _game.AddMotion(Token.Y, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(2, 1));
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.X, new Position(2, 2));

            var result = _game.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByThirdRow()
        {
            _game.AddMotion(Token.Y, new Position(2, 0));
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.Y, new Position(2, 1));
            _game.AddMotion(Token.X, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(2, 2));

            var result = _game.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXByFirstColumn()
        {
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.Y, new Position(0, 1));
            _game.AddMotion(Token.X, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(1, 1));
            _game.AddMotion(Token.X, new Position(2, 0));

            var result = _game.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstColumn()
        {
            _game.AddMotion(Token.Y, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(0, 1));
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.X, new Position(1, 1));
            _game.AddMotion(Token.Y, new Position(2, 0));

            var result = _game.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXBySecondColumn()
        {
            _game.AddMotion(Token.X, new Position(0, 1));
            _game.AddMotion(Token.Y, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(1, 1));
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.X, new Position(2, 1));

            var result = _game.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondColumn()
        {
            _game.AddMotion(Token.Y, new Position(0, 1));
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.Y, new Position(1, 1));
            _game.AddMotion(Token.X, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(2, 1));

            var result = _game.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXByThirdColumn()
        {
            _game.AddMotion(Token.X, new Position(0, 2));
            _game.AddMotion(Token.Y, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(1, 2));
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.X, new Position(2, 2));

            var result = _game.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByThirdColumn()
        {
            _game.AddMotion(Token.Y, new Position(0, 2));
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.Y, new Position(1, 2));
            _game.AddMotion(Token.X, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(2, 2));

            var result = _game.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXByFirstDiagonal()
        {
            _game.AddMotion(Token.X, new Position(0, 0));
            _game.AddMotion(Token.Y, new Position(0, 1));
            _game.AddMotion(Token.X, new Position(1, 1));
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.X, new Position(2, 2));

            var result = _game.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstDiagonal()
        {
            _game.AddMotion(Token.Y, new Position(0, 0));
            _game.AddMotion(Token.X, new Position(0, 1));
            _game.AddMotion(Token.Y, new Position(1, 1));
            _game.AddMotion(Token.X, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(2, 2));

            var result = _game.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void WinPlayerXBySecondDiagonal()
        {
            _game.AddMotion(Token.X, new Position(0, 2));
            _game.AddMotion(Token.Y, new Position(0, 1));
            _game.AddMotion(Token.X, new Position(1, 1));
            _game.AddMotion(Token.Y, new Position(1, 0));
            _game.AddMotion(Token.X, new Position(2, 0));

            var result = _game.Print();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondDiagonal()
        {
            _game.AddMotion(Token.Y, new Position(0, 2));
            _game.AddMotion(Token.X, new Position(0, 1));
            _game.AddMotion(Token.Y, new Position(1, 1));
            _game.AddMotion(Token.X, new Position(1, 0));
            _game.AddMotion(Token.Y, new Position(2, 0));

            var result = _game.Print();

            result.Should().Be("Player Y WIN!");
        }

        [Test]
        public void ThrowExceptionWhenPositionIsNotValid()
        {
            Action wrongPlay = () => _game.AddMotion(Token.Y, new Position(0, 3));

            wrongPlay.Should().Throw<Exception>().WithMessage("Invalid movement!");
        }

        [Test]
        public void ThrowExceptionWhenFieldIsBusy()
        {
            _game.AddMotion(Token.Y, new Position(0, 1));

            Action wrongPlay = () => _game.AddMotion(Token.Y, new Position(0, 1));

            wrongPlay.Should().Throw<Exception>().WithMessage("Invalid movement!");
        }
    }
}