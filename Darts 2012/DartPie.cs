namespace Darts_2012
{
    class DartPie
    {
        private readonly int _value;
        private readonly int _beginAngle;

        public DartPie(int value, int beginAngle)
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
