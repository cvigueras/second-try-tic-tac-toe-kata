﻿using FluentAssertions;
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

            board.InsertMotion("X");
            var result = board.Print();

            result.Should().Be("[X][ ][ ][ ][ ][ ][ ][ ][ ]");
        }
    }
}