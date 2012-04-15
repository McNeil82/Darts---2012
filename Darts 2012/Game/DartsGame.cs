using Darts_2012.Poco;

namespace Darts_2012.Game
{
    public interface IDartsGame
    {
        int PlayerCount { get; set; }

        int InitialScore { get; set; }

        Player ProcessThrow(Throw @throw, Player player);

        string GameMode();

        string ScoreLabel();
    }
}
