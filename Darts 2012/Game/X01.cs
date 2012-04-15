using Darts_2012.Poco;

namespace Darts_2012.Game
{
    class X01 : AbstractDartsGame
    {
        private bool DoubleIn { get; set; }
        private X01OutMode.OutMode OutMode { get; set; }
        private int ScoreAtBeginningOfRoundOfCurrentPlayer { get; set; }

        public X01(bool doubleIn, X01OutMode.OutMode outMode)
        {
            DoubleIn = doubleIn;
            OutMode = outMode;
        }

        public override void ProcessThrow(Throw @throw, ref Player player)
        {
            if (player.CurrentThrow == 1)
            {
                ScoreAtBeginningOfRoundOfCurrentPlayer = player.CurrentScore;
            }
            player.CurrentThrow++;
            CalculateScore(@throw, ref player);
            SetAdditionalInfo(ref player);
        }

        private void CalculateScore(Throw @throw, ref Player player)
        {
            if (NotDoubledInIfActivated(player.CurrentScore, @throw.Multiplier))
            {
            }
            else
            {
                player.CurrentScore -= @throw.Value * @throw.Multiplier;
            }

            if (player.CurrentScore < 0)
            {
                EndRound(ref player);
            }
            else
            {
                if (OutMode == X01OutMode.OutMode.StraightOut && player.CurrentScore == 0)
                {
                    player.HasFinished = true;
                }
                else if (OutMode == X01OutMode.OutMode.DoubleOut || OutMode == X01OutMode.OutMode.MasterOut)
                {
                    if (player.CurrentScore == 1)
                    {
                        EndRound(ref player);
                    }
                    else if (player.CurrentScore == 0)
                    {
                        if (@throw.Multiplier == 2 || (OutMode == X01OutMode.OutMode.MasterOut && @throw.Multiplier == 3))
                        {
                            player.HasFinished = true;
                        }
                        else
                        {
                            EndRound(ref player);
                        }
                    }
                }
            }
        }

        private bool NotDoubledInIfActivated(int currentPlayerScore, int throwMultiplier)
        {
            return currentPlayerScore == InitialScore && DoubleIn && throwMultiplier != 2;
        }

        private void EndRound(ref Player player)
        {
            player.CurrentScore = ScoreAtBeginningOfRoundOfCurrentPlayer;
            player.CurrentThrow = 4;
        }

        private void SetAdditionalInfo(ref Player player)
        {
            player.AdditionalInfo = "";
        }

        public override string GameMode()
        {
            return InitialScore + " mit " +
                   (DoubleIn ? "Double In und " : "") +
                   X01OutMode.ToString(OutMode);
        }

        public override string ScoreLabel()
        {
            return "verbleibende Punkte";
        }
    }
}
