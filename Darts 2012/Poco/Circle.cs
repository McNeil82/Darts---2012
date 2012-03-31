namespace Darts_2012.Poco
{
    class Circle
    {
        private readonly int _radius;
        private readonly int _offset;
        private readonly int _value;

        public Circle(int radius, int offset, int value)
        {
            _radius = radius;
            _offset = offset;
            _value = value;
        }

        public int Value
        {
            get { return _value; }
        }

        public int Radius
        {
            get { return _radius; }
        }

        public int Offset
        {
            get { return _offset; }
        }
    }
}
