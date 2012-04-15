using Darts_2012.Poco;

namespace Darts_2012.Game
{
    public interface IDartsGame
    {
        int PlayerCount { get; set; }

        int InitialScore { get; set; }

        void ProcessThrow(Throw @throw, ref Player player);

        string GameMode();

        string ScoreLabel();
    }
}
