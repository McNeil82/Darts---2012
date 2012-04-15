using Darts_2012.Poco;

namespace Darts_2012.Game
{
    class GameManagement
    {
        public bool GameInProgress { get; private set; }

        private IDartsGame Game { get; set; }

        private Player CurrentPlayer { get; set; }

        private Player[] Players { get; set; }

        private bool LastRound { get; set; }

        public void PrepareGame(IDartsGame game)
        {
            Game = game;
            CreatePlayers();
            CurrentPlayer = Players[0];
            GameInProgress = true;
            LastRound = false;
        }

        private void CreatePlayers()
        {
            Players = new Player[Game.PlayerCount];
            for (var playerIndex = 0; playerIndex < Game.PlayerCount; playerIndex++)
            {
                Players[playerIndex] = new Player
                                           {
                                               CurrentThrow = playerIndex == 0 ? 1 : 0,
                                               CurrentScore = Game.InitialScore,
                                               Number = playerIndex + 1
                                           };
            }
        }

        public void ProcessThrow(Throw @throw)
        {

            if (!CurrentPlayer.HasFinished)
            {
                var currentPlayer = CurrentPlayer;
                Game.ProcessThrow(@throw, ref currentPlayer);
                if (CurrentPlayer.HasFinished)
                {
                    LastRound = true;
                }
            }

            if (CurrentPlayer.CurrentThrow > 3 || CurrentPlayer.HasFinished)
            {
                var nextPlayerIndex = CurrentPlayer.Number;
                if (nextPlayerIndex >= Players.Length)
                {
                    if (LastRound)
                    {
                        GameInProgress = false;
                        return;
                    }

                    nextPlayerIndex = 0;
                }

                CurrentPlayer = Players[nextPlayerIndex];
                CurrentPlayer.CurrentThrow = 1;
            }
        }

        public int GetPlayerCount()
        {
            return Game.PlayerCount;
        }

        public int GetCurrentPlayerNumber()
        {
            return CurrentPlayer.Number;
        }

        public string GetCurrentScoreFromPlayer(int playerNumber)
        {
            if (playerNumber - 1 < Players.Length)
            {
                return Players[playerNumber - 1].CurrentScore.ToString();

            }

            return "-";
        }

        public int GetCurrentThrowFromPlayer(int playerNumber)
        {
            if (playerNumber - 1 < Players.Length)
            {
                return Players[playerNumber - 1].CurrentThrow;

            }

            return 0;
        }

        public bool PlayerHasfinished(int playerNumber)
        {
            if (playerNumber - 1 < Players.Length)
            {
                return Players[playerNumber - 1].HasFinished;

            }

            return false;
        }

        public string GetGameMode()
        {
            return Game.GameMode();
        }

        public string GetScoreLabel()
        {
            return Game.ScoreLabel();
        }

        public string GetAdditionalInfoForPlayer(int playerNumber)
        {
            if (playerNumber - 1 < Players.Length)
            {
                return Players[playerNumber - 1].AdditionalInfo;

            }

            return "";
        }
    }
}
