using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void testGutterGame()
        {
            var game = new Game();

            for (int i = 0; i < 20; i++)
            {
                game.roll(0);
            }

            Assert.AreEqual(0, game.score());
        }

        [TestMethod]
        public void testOneSpare()
        {
            var game = new Game();
            game.roll(5);
            game.roll(5); // spare
            game.roll(3);

            for (int i = 0; i < 17; i++)
            {
                game.roll(0);
            }

            Assert.AreEqual(16, game.score());
        }

    }
}
