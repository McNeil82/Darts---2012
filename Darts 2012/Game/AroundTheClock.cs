namespace Darts_2012.Game
{
    class AroundTheClock : IDartsGame
    {
        public int From { get; private set; }

        public int To { get; private set; }

        public bool Skip { get; private set; }

        public bool Joker { get; private set; }

        public AroundTheClock(int from, int to, bool skip, bool joker)
        {
            From = from;
            To = to;
            Skip = skip;
            Joker = joker;
        }

        public override string ToString()
        {
            return base.ToString() + "\n"
                + "From: " + From + "\n"
                + "To: " + To + "\n"
                + "Skip: " + Skip + "\n"
                + "Joker: " + Joker;
        }
    }
}
