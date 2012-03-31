using Darts_2012.Poco;

namespace Darts_2012.Game
{
    class GameManagement
    {
        public bool GameInProgress { get; set; }

        private IDartsGame Game { get; set; }

        public Player CurrentPlayer { get; set; }

        public int CurrentThrow { get; set; }

        private Player[] Players { get; set; }

        public void PrepareGame(IDartsGame game)
        {
            Game = game;
            CreatePlayers();
            CurrentPlayer = Players[0];
            CurrentThrow = 1;
            GameInProgress = true;
        }

        private void CreatePlayers()
        {
            Players = new Player[Game.PlayerCount];
            for (var playerIndex = 0; playerIndex < Game.PlayerCount; playerIndex++)
            {
                Players[playerIndex] = new Player
                                           {
                                               CurrentScore = Game.InitialScore,
                                               Number = playerIndex + 1
                                           };
            }
        }

        public int GetPlayerCount()
        {
            return Game.PlayerCount;
        }

        public string GetPlayerScore(int playerNumber)
        {
            return Players[playerNumber - 1].CurrentScore.ToString();
        }

        public void ProcessThrow(Throw @throw)
        {
            CurrentThrow += 1;
            if (CurrentThrow > 3)
            {
                var nextPlayerIndex = CurrentPlayer.Number;
                if (nextPlayerIndex >= Players.Length)
                {
                    nextPlayerIndex = 0;
                }

                CurrentPlayer = Players[nextPlayerIndex];
                CurrentThrow = 1;
            }
        }
    }
}
