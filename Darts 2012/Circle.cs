namespace Darts_2012
{
    class Circle
    {
        private readonly int _radius;
        private readonly int _offset;

        public Circle(int radius, int offset)
        {
            _radius = radius;
            _offset = offset;
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
