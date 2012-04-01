using Darts_2012.Poco;

namespace Darts_2012.Game
{
    class AroundTheClock : AbstractDartsGame
    {
        private bool PlayerHasFinished { get; set; }

        public int To { get; private set; }

        public bool Skip { get; private set; }

        public bool Joker { get; private set; }

        public AroundTheClock(int to, bool skip, bool joker)
        {
            To = to;
            Skip = skip;
            Joker = joker;
        }

        public override Player ProcessThrow(Throw @throw, Player player)
        {
            player.CurrentThrow++;
            player.CurrentScore = CalculateScore(@throw, player.CurrentScore);
            player.HasFinished = PlayerHasFinished;

            return player;
        }

        public int CalculateScore(Throw @throw, int currentScore)
        {
            PlayerHasFinished = false;
            var newScore = currentScore;

            if (@throw.Value == currentScore || (Joker && ThrowWasJoker(@throw.Value)))
            {
                if (Skip)
                {
                    newScore += @throw.Multiplier * 1;
                }
                else
                {
                    newScore++;
                }

                if (newScore > To)
                {
                    newScore = To;
                    PlayerHasFinished = true;
                }
            }

            return newScore;
        }

        private static bool ThrowWasJoker(int throwValue)
        {
            return throwValue == 50 || throwValue == 25;
        }

        public override string GameMode()
        {
            return "Around The Clock (" + InitialScore + " - " + To + ")"
                + (Skip ? " mit Sprüngen" : " ohne Sprünge")
                + (Joker ? " mit Jokern" : " ohne Joker");
        }
    }
}
