using System;

namespace BowlingGame
{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int _currentRoll = 0;


        public Game()
        {
        }

        public void roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int score()
        {
            int score = 0;
            var i = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (_rolls[frame] + _rolls[frame + 1] == 10)
                {
                    score += 10 + _rolls[i + 2];
                    i += 2;
                }
                else
                {
                    score += _rolls[i] + _rolls[i + 1];
                    i += 2;
                }
            }
            return score;
        }
    }
}