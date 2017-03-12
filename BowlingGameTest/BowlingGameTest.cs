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
    }
}
