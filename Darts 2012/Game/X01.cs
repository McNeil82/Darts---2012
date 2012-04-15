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

        public override Player ProcessThrow(Throw @throw, Player player)
        {
            if (player.CurrentThrow == 1)
            {
                ScoreAtBeginningOfRoundOfCurrentPlayer = player.CurrentScore;
            }
            player.CurrentThrow++;

            if (NotDoubledInIfActivated(@throw, player))
            {

            }
            else
            {
                player.CurrentScore -= @throw.Value * @throw.Multiplier;
            }

            if (player.CurrentScore < 0)
            {
                EndRound(player);
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
                        EndRound(player);
                    }
                    else if (player.CurrentScore == 0)
                    {
                        if (@throw.Multiplier == 2 || (OutMode == X01OutMode.OutMode.MasterOut && @throw.Multiplier == 3))
                        {
                            player.HasFinished = true;
                        }
                        else
                        {
                            EndRound(player);
                        }
                    }
                }
            }


            return player;
        }

        private void EndRound(Player player)
        {
            player.CurrentScore = ScoreAtBeginningOfRoundOfCurrentPlayer;
            player.CurrentThrow = 4;
        }

        private bool NotDoubledInIfActivated(Throw @throw, Player player)
        {
            return player.CurrentScore == InitialScore && DoubleIn && @throw.Multiplier != 2;
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
