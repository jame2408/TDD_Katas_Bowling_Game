﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        Game game = new Game();

        [TestMethod]
        public void testGutterGame()
        {
            rollMany(20, 0);

            Assert.AreEqual(0, game.score());
        }

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.roll(pins);
            }
        }

        [TestMethod]
        public void testOneSpare()
        {
            rollSpare();
            game.roll(3);
            rollMany(17, 0);

            Assert.AreEqual(16, game.score());
        }

        private void rollSpare()
        {
            game.roll(5);
            game.roll(5);
        }

        [TestMethod]
        public void testOneStrike()
        {
            game.roll(10); //strike
            game.roll(3);
            game.roll(4);
            rollMany(16, 0);

            Assert.AreEqual(24, game.score());
        }
    }
}
