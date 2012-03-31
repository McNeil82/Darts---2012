namespace Darts_2012.Game
{
    class AroundTheClock : IDartsGame
    {
        private readonly int _from;
        private readonly int _to;
        private readonly bool _skip;
        private readonly bool _joker;
        private readonly int _playerCount;

        public AroundTheClock(int from, int to, bool skip, bool joker, int playerCount)
        {
            _from = from;
            _to = to;
            _skip = skip;
            _joker = joker;
            _playerCount = playerCount;
        }

        public override string ToString()
        {
            return base.ToString() + "\n"
                + "From: " + _from + "\n"
                + "To: " + _to + "\n"
                + "Skip: " + _skip + "\n"
                + "Joker: " + _joker + "\n"
                + "Player count: " + _playerCount;
        }
    }
}
