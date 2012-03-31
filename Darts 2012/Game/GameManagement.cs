using System;
using Darts_2012.Poco;

namespace Darts_2012.Game
{
    class GameManagement
    {
        public IDartsGame Game { get; set; }

        public int PlayerCount { get; set; }

        public int CurrentPlayer { get; set; }

        public int CurrentThrow { get; set; }

        public void ProcessThrow(Throw @throw)
        {
            CurrentThrow += 1;
            if (CurrentThrow > 3)
            {
                CurrentPlayer += 1;
                if (CurrentPlayer > PlayerCount)
                {
                    CurrentPlayer = 1;
                }

                CurrentThrow = 1;
            }
        }
    }
}
