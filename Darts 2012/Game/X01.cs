using System;
using Darts_2012.Poco;

namespace Darts_2012.Game
{
    class X01 : AbstractDartsGame
    {
        private bool DoubleIn { get; set; }
        private X01OutMode.OutMode OutMode { get; set; }

        public X01(bool doubleIn, X01OutMode.OutMode outMode)
        {
            DoubleIn = doubleIn;
            OutMode = outMode;
        }

        public override Player ProcessThrow(Throw @throw, Player player)
        {
            player.CurrentThrow++;

            return player;
        }

        public override string GameMode()
        {
            string outModeString;
            switch (OutMode)
            {
                case X01OutMode.OutMode.DoubleOut:
                    outModeString = "Double Out";
                    break;
                case X01OutMode.OutMode.MasterOut:
                    outModeString = "Master Out";
                    break;
                case X01OutMode.OutMode.StraightOut:
                    outModeString = "Straight Out";
                    break;
                default:
                    outModeString = "Straight Out";
                    break;
            }
            return InitialScore + " mit " +
                (DoubleIn ? "Double In und " : "") +
                outModeString;
        }
    }
}
