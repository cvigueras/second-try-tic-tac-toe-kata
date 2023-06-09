﻿using FluentAssertions;
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
            var result = _game.GetStatus();

            result.Should().Be("[ ][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerX()
        {
            _game.AddMotion(new Position(0, 0));

            var result = _game.GetStatus();

            result.Should().Be("[X][ ][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertFirstMotionForPlayerY()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));

            var result = _game.GetStatus();

            result.Should().Be("[X][O][ ][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerX()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(0, 2));

            var result = _game.GetStatus();

            result.Should().Be("[X][O][X][ ][ ][ ][ ][ ][ ]");
        }

        [Test]
        public void InsertSecondMotionForPlayerY()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(2, 2));
            _game.AddMotion(new Position(1, 0));

            var result = _game.GetStatus();

            result.Should().Be("[X][O][ ][O][ ][ ][ ][ ][X]");
        }

        [Test]
        public void InsertThirdMotionForPlayerX()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(0, 2));
            _game.AddMotion(new Position(2, 2));
            _game.AddMotion(new Position(1, 1));

            var result = _game.GetStatus();

            result.Should().Be("[X][O][X][ ][X][ ][ ][ ][O]");
        }

        [Test]
        public void InsertThirdMotionForPlayerY()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 1));
            _game.AddMotion(new Position(1, 2));

            var result = _game.GetStatus();

            result.Should().Be("[X][O][ ][O][X][O][ ][X][ ]");
        }

        [Test]
        public void WinPlayerXByFirstRow()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(1, 2));
            _game.AddMotion(new Position(0, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstRow()
        {
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 2));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(2, 2));
            _game.AddMotion(new Position(0, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player O WIN!");
        }

        [Test]
        public void WinPlayerXBySecondRow()
        {
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(2, 0));
            _game.AddMotion(new Position(1, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondRow()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(2, 2));
            _game.AddMotion(new Position(1, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player O WIN!");
        }

        [Test]
        public void WinPlayerXByThirdRow()
        {
            _game.AddMotion(new Position(2, 0));
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(2, 1));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByThirdRow()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(2, 0));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 1));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(2, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player O WIN!");
        }

        [Test]
        public void WinPlayerXByFirstColumn()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(2, 0));

            var result = _game.GetStatus();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstColumn()
        {
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 2));
            _game.AddMotion(new Position(2, 0));

            var result = _game.GetStatus();

            result.Should().Be("Player O WIN!");
        }

        [Test]
        public void WinPlayerXBySecondColumn()
        {
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 1));

            var result = _game.GetStatus();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondColumn()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(2, 2));
            _game.AddMotion(new Position(2, 1));

            var result = _game.GetStatus();

            result.Should().Be("Player O WIN!");
        }

        [Test]
        public void WinPlayerXByThirdColumn()
        {
            _game.AddMotion(new Position(0, 2));
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 2));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByThirdColumn()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 2));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(1, 2));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(2, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player O WIN!");
        }

        [Test]
        public void WinPlayerXByFirstDiagonal()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYByFirstDiagonal()
        {
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(1, 2));
            _game.AddMotion(new Position(2, 2));

            var result = _game.GetStatus();

            result.Should().Be("Player O WIN!");
        }

        [Test]
        public void WinPlayerXBySecondDiagonal()
        {
            _game.AddMotion(new Position(0, 2));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(2, 0));

            var result = _game.GetStatus();

            result.Should().Be("Player X WIN!");
        }

        [Test]
        public void WinPlayerYBySecondDiagonal()
        {
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(0, 2));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(2, 2));
            _game.AddMotion(new Position(2, 0));

            var result = _game.GetStatus();

            result.Should().Be("Player O WIN!");
        }

        [Test]
        public void ThrowExceptionWhenPositionIsNotValid()
        {
            Action wrongPlay = () => _game.AddMotion(new Position(0, 3));

            wrongPlay.Should().Throw<Exception>().WithMessage("Invalid movement!");
        }

        [Test]
        public void ThrowExceptionWhenFieldIsBusy()
        {
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(0, 1));

            Action wrongPlay = () => _game.AddMotion(new Position(0, 0));

            wrongPlay.Should().Throw<Exception>().WithMessage("Invalid movement!");
        }

        [Test]
        public void DrawMatchWhenNobodyWin()
        {
            _game.AddMotion(new Position(2, 0));
            _game.AddMotion(new Position(1, 0));
            _game.AddMotion(new Position(0, 1));
            _game.AddMotion(new Position(0, 0));
            _game.AddMotion(new Position(1, 1));
            _game.AddMotion(new Position(2, 1));            
            _game.AddMotion(new Position(1, 2));
            _game.AddMotion(new Position(0, 2));
            _game.AddMotion(new Position(2, 2));

            var result = _game.GetStatus();

            result.Should().Be("Draw!");
        }
    }
}