namespace Darts_2012.Game
{
    class GameManagement
    {
        public IDartsGame Game { private get; set; }

        public int PlayerCount { get; set; }

        public int CurrentPlayer { get; set; }
    }
}
