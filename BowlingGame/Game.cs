using System;

namespace BowlingGame
{
    public class Game
    {
        private int _score;

        public Game()
        {
        }

        public void roll(int pins)
        {
            this._score += pins;
        }

        public int score()
        {
            return _score;
        }
    }
}