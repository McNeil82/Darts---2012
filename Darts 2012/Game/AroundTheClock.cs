namespace Darts_2012.Game
{
    class AroundTheClock : IDartsGame
    {
        private readonly int _from;
        private readonly int _to;
        private readonly bool _skip;
        private readonly bool _joker;

        public AroundTheClock(int from, int to, bool skip, bool joker)
        {
            _from = from;
            _to = to;
            _skip = skip;
            _joker = joker;
        }

        public override string ToString()
        {
            return base.ToString() + "\n"
                + "From: " + _from + "\n"
                + "To: " + _to + "\n"
                + "Skip: " + _skip + "\n"
                + "Joker: " + _joker;
        }
    }
}
