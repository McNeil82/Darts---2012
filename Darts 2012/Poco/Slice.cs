namespace Darts_2012.Poco
{
    class Slice
    {
        private readonly int _value;
        private readonly int _beginAngle;

        public Slice(int value, int beginAngle)
        {
            _value = value;
            _beginAngle = beginAngle;
        }

        public int BeginAngle
        {
            get { return _beginAngle; }
        }

        public int Value
        {
            get { return _value; }
        }
    }
}
