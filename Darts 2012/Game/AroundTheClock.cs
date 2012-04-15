using Darts_2012.Poco;

namespace Darts_2012.Game
{
    class AroundTheClock : AbstractDartsGame
    {
        private bool PlayerHasFinished { get; set; }

        private int ScoreToReach { get; set; }

        private bool SkipsActivated { get; set; }

        private bool JokersActivated { get; set; }

        public AroundTheClock(int scoreToReach, bool skipsActivated, bool jokersActivated)
        {
            ScoreToReach = scoreToReach;
            SkipsActivated = skipsActivated;
            JokersActivated = jokersActivated;
        }

        public override Player ProcessThrow(Throw @throw, Player player)
        {
            player.CurrentThrow++;
            player.CurrentScore = CalculateScore(@throw, player.CurrentScore);
            player.HasFinished = PlayerHasFinished;

            return player;
        }

        private int CalculateScore(Throw @throw, int currentScore)
        {
            PlayerHasFinished = false;
            var newScore = currentScore;

            if (@throw.Value == currentScore || (JokersActivated && ThrowIsJoker(@throw.Value)))
            {
                if (SkipsActivated)
                {
                    newScore += @throw.Multiplier * 1;
                }
                else
                {
                    newScore++;
                }

                if (newScore > ScoreToReach)
                {
                    newScore = ScoreToReach;
                    PlayerHasFinished = true;
                }
            }

            return newScore;
        }

        private static bool ThrowIsJoker(int throwValue)
        {
            return throwValue == 50 || throwValue == 25;
        }

        public override string GameMode()
        {
            return "Around The Clock (" + InitialScore + " - " + ScoreToReach + ")"
                + (SkipsActivated ? " mit Sprüngen" : " ohne Sprünge")
                + (JokersActivated ? " mit Jokern" : " ohne Joker");
        }

        public override string ScoreLabel()
        {
            return "zu treffende Zahl";
        }
    }
}
