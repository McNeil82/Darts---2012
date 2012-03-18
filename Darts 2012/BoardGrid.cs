using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Darts_2012
{
    class BoardGrid
    {
        enum Circle
        {
            Bullseye,
            Bull,
            InnerSingle,
            Triple,
            OuterSingle,
            Double
        }

        private static readonly Brush YellowBrush = new SolidBrush(Color.Yellow);

        private readonly Graphics _graphics;
        private Point _center;
        private readonly int _width;
        private readonly int _height;
        private readonly List<SolidBrush> _brushes = new List<SolidBrush>(4)
                           {
                               new SolidBrush(Color.Red),
                               new SolidBrush(Color.Green),
                               new SolidBrush(Color.Black),
                               new SolidBrush(Color.White)
                               
                           };

        private readonly List<DartPie> _dartPies = new List<DartPie>
                            {
                                new DartPie(20, 261),
                                new DartPie(1, 279),
                                new DartPie(18, 297),
                                new DartPie(4, 315),
                                new DartPie(13, 333),
                                new DartPie(6, 351),
                                new DartPie(10, 9),
                                new DartPie(15, 27),
                                new DartPie(2, 45),
                                new DartPie(17, 63),
                                new DartPie(3, 81),
                                new DartPie(19, 99),
                                new DartPie(7, 117),
                                new DartPie(16, 135),
                                new DartPie(8, 153),
                                new DartPie(11, 171),
                                new DartPie(14, 189),
                                new DartPie(9, 207),
                                new DartPie(12, 225),
                                new DartPie(5, 243)
                            };

        private readonly OrderedDictionary _dartCircles = new OrderedDictionary
                                   {
                                       {Circle.Bullseye, new DartCircle(15, 0)},
                                       {Circle.Bull, new DartCircle(35, 0)},
                                       {Circle.InnerSingle, new DartCircle(188, 0)},
                                       {Circle.Triple, new DartCircle(209, -1)},
                                       {Circle.OuterSingle, new DartCircle(313, -1)},
                                       {Circle.Double, new DartCircle(335, -1)}
                                   };

        private readonly List<GraphicsPath> _graphicsPaths = new List<GraphicsPath>();

        public BoardGrid(Graphics graphics, Point center, int width, int height)
        {
            _graphics = graphics;
            _center = center;
            _width = width;
            _height = height;
        }

        public void DrawGrid()
        {
            DrawCircle(_brushes[1], Circle.Bull);
            DrawCircle(_brushes[0], Circle.Bullseye);

            _graphics.TranslateTransform(_center.X, _center.Y);

            for (var dartCircleIndex = 1; dartCircleIndex < _dartCircles.Count - 1; ++dartCircleIndex)
            {
                for (var angleIndex = 0; angleIndex < _dartPies.Count; ++angleIndex)
                {
                    DrawPolygon(_brushes[(dartCircleIndex % 2 * 2 + angleIndex % 2)],
                         (DartCircle)_dartCircles[dartCircleIndex], (DartCircle)_dartCircles[dartCircleIndex + 1],
                       _dartPies[angleIndex].BeginAngle, _dartPies[angleIndex + 1 == _dartPies.Count ? 0 : angleIndex + 1].BeginAngle);
                }
            }

            _graphics.ResetTransform();
            _graphics.FillRectangle(YellowBrush, _center.X, 0, 1, _height);
            _graphics.FillRectangle(YellowBrush, 0, _center.Y, _width, 1);
        }

        private void DrawCircle(Brush brush, Circle circle)
        {
            var dartField = (DartCircle)_dartCircles[circle];
            var radius = dartField.Radius;
            var offset = dartField.Offset;
            int x = _center.X - radius + offset;
            int y = _center.Y - radius + offset;
            _graphics.FillEllipse(brush, x, y, radius * 2, radius * 2);

            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(x, y, radius * 2, radius * 2);
            graphicsPath.CloseFigure();
            _graphicsPaths.Add(graphicsPath);
        }

        private void DrawPolygon(Brush brush, DartCircle innerDartCircle, DartCircle outerDartCircle, int beginAngle, int endAngle)
        {
            var polygonPoints = new PointF[38];

            polygonPoints[0] = new PointF(XOnCircle(beginAngle, innerDartCircle.Radius) + innerDartCircle.Offset, YOnCircle(beginAngle, innerDartCircle.Radius) + innerDartCircle.Offset);
            polygonPoints[1] = new PointF(XOnCircle(beginAngle, outerDartCircle.Radius) + outerDartCircle.Offset, YOnCircle(beginAngle, outerDartCircle.Radius) + outerDartCircle.Offset);
            for (var outerCircleIndex = 2; outerCircleIndex < 19; ++outerCircleIndex)
            {
                polygonPoints[outerCircleIndex] = new PointF(XOnCircle(beginAngle + (outerCircleIndex - 1), outerDartCircle.Radius) + outerDartCircle.Offset,
                    YOnCircle(beginAngle + (outerCircleIndex - 1), outerDartCircle.Radius) + outerDartCircle.Offset);
            }
            polygonPoints[19] = new PointF(XOnCircle(endAngle, outerDartCircle.Radius) + outerDartCircle.Offset, YOnCircle(endAngle, outerDartCircle.Radius) + outerDartCircle.Offset);
            polygonPoints[20] = new PointF(XOnCircle(endAngle, innerDartCircle.Radius) + innerDartCircle.Offset, YOnCircle(endAngle, innerDartCircle.Radius) + innerDartCircle.Offset);
            for (var innerCircleIndex = 21; innerCircleIndex < 38; ++innerCircleIndex)
            {
                polygonPoints[innerCircleIndex] = new PointF(XOnCircle(endAngle - (innerCircleIndex - 20), innerDartCircle.Radius) + innerDartCircle.Offset,
                    YOnCircle(endAngle - (innerCircleIndex - 20), innerDartCircle.Radius) + innerDartCircle.Offset);
            }
            _graphics.FillPolygon(brush, polygonPoints);

            var graphicsPath = new GraphicsPath();
            graphicsPath.AddPolygon(polygonPoints);
            graphicsPath.CloseFigure();
            _graphicsPaths.Add(graphicsPath);
        }

        private static float XOnCircle(int angle, int radius)
        {
            return radius * (float)Math.Cos(angle * Math.PI / 180);
        }

        private static float YOnCircle(int angle, int radius)
        {
            return radius * (float)Math.Sin(angle * Math.PI / 180);
        }

        public void HighlightPolygon(int x, int y)
        {
            foreach (GraphicsPath graphicsPath in _graphicsPaths)
            {
                if (graphicsPath.IsVisible(x, y))
                {
                    //_graphics.FillPath(YellowBrush, graphicsPath);
                }
            }
        }
    }
}
