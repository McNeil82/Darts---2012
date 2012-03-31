namespace Darts_2012.Game
{
    class AroundTheClock : AbstractDartsGame
    {
        public int To { get; private set; }

        public bool Skip { get; private set; }

        public bool Joker { get; private set; }

        public AroundTheClock(int to, bool skip, bool joker)
        {
            To = to;
            Skip = skip;
            Joker = joker;
        }

        public override string ToString()
        {
            return base.ToString() + "\n"
                + "To: " + To + "\n"
                + "Skip: " + Skip + "\n"
                + "Joker: " + Joker;
        }
    }
}
