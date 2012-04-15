using Darts_2012.Poco;

namespace Darts_2012.Game
{
    class AroundTheClock : AbstractDartsGame
    {
        private int ScoreToReach { get; set; }

        private bool SkipsActivated { get; set; }

        private bool JokersActivated { get; set; }

        public AroundTheClock(int scoreToReach, bool skipsActivated, bool jokersActivated)
        {
            ScoreToReach = scoreToReach;
            SkipsActivated = skipsActivated;
            JokersActivated = jokersActivated;
        }

        public override void ProcessThrow(Throw @throw, ref Player player)
        {
            player.CurrentThrow++;
            CalculateScore(@throw, ref player);
        }

        private void CalculateScore(Throw @throw, ref Player player)
        {
            var newScore = player.CurrentScore;

            if (@throw.Value == player.CurrentScore || (JokersActivated && ThrowIsJoker(@throw.Value)))
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
                    player.HasFinished = true;
                }
            }

            player.CurrentScore = newScore;
        }

        private static bool ThrowIsJoker(int throwValue)
        {
            return throwValue == 25;
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
