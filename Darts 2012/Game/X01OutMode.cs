namespace Darts_2012.Game
{
    class X01OutMode
    {
        public enum OutMode
        {
            DoubleOut,
            MasterOut,
            StraightOut
        }

        public static string ToString(OutMode outMode)
        {
            switch (outMode)
            {
                case OutMode.DoubleOut:
                    return "Double Out";
                case OutMode.MasterOut:
                    return "Master Out";
                case OutMode.StraightOut:
                    return "Straight Out";
                default:
                    return "Straight Out";
            }
        }
    }
}
