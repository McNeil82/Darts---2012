using Darts_2012.Poco;

namespace Darts_2012.Game
{
    abstract class AbstractDartsGame : IDartsGame
    {
        public int PlayerCount { get; set; }

        public int InitialScore { get; set; }

        public abstract int CalculateScore(Throw @throw, Player player);
    }
}
