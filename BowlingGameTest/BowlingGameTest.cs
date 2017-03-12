using System;
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
            rollStrike();
            game.roll(3);
            game.roll(4);
            rollMany(16, 0);

            Assert.AreEqual(24, game.score());
        }

        private void rollStrike()
        {
            game.roll(10);
        }

        [TestMethod]
        public void testAnyGame()
        {
            game.roll(6);
            game.roll(2);
            game.roll(8);
            game.roll(0);
            game.roll(5);
            game.roll(1);
            rollStrike();
            game.roll(7);
            game.roll(2);
            rollStrike();
            rollSpare();
            game.roll(3);
            game.roll(2);
            game.roll(4);
            game.roll(5);
            rollSpare();
            game.roll(8);

            Assert.AreEqual(115, game.score());
        }
    }
}
