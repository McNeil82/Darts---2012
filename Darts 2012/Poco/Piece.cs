using System.Drawing.Drawing2D;

namespace Darts_2012.Poco
{
    class Piece
    {
        private readonly int _value;
        private readonly GraphicsPath _graphicsPath;

        public Piece(int value, GraphicsPath graphicsPath)
        {
            _value = value;
            _graphicsPath = graphicsPath;
        }

        public GraphicsPath GraphicsPath
        {
            get { return _graphicsPath; }
        }

        public int Value
        {
            get { return _value; }
        }
    }
}
