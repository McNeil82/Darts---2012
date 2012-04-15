using Darts_2012.Poco;

namespace Darts_2012.Game
{
    abstract class AbstractDartsGame : IDartsGame
    {
        public int PlayerCount { get; set; }

        public int InitialScore { get; set; }

        public abstract Player ProcessThrow(Throw @throw, Player player);

        public abstract string GameMode();

        public abstract string ScoreLabel();
    }
}
