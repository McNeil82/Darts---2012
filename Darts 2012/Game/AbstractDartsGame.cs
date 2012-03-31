namespace Darts_2012.Game
{
    abstract class AbstractDartsGame : IDartsGame
    {
        public int PlayerCount { get; set; }

        public int InitialScore { get; set; }
    }
}
