using System.Drawing.Drawing2D;

namespace Darts_2012
{
    class DartCircle
    {
        private readonly int _radius;
        private readonly int _offset;

        public DartCircle(int radius, int offset)
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
