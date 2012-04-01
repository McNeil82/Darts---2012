using Darts_2012.Poco;

namespace Darts_2012.Game
{
    public interface IDartsGame
    {
        int PlayerCount { get; set; }

        int InitialScore { get; set; }

        int CalculateScore(Throw @throw, Player player);
    }
}
