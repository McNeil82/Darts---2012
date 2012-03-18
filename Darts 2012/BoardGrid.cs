using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Darts_2012
{
    class BoardGrid
    {
        enum Outline
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

        private readonly List<Slice> _slices = new List<Slice>
                            {
                                new Slice(20, 261),
                                new Slice(1, 279),
                                new Slice(18, 297),
                                new Slice(4, 315),
                                new Slice(13, 333),
                                new Slice(6, 351),
                                new Slice(10, 9),
                                new Slice(15, 27),
                                new Slice(2, 45),
                                new Slice(17, 63),
                                new Slice(3, 81),
                                new Slice(19, 99),
                                new Slice(7, 117),
                                new Slice(16, 135),
                                new Slice(8, 153),
                                new Slice(11, 171),
                                new Slice(14, 189),
                                new Slice(9, 207),
                                new Slice(12, 225),
                                new Slice(5, 243)
                            };

        private readonly OrderedDictionary _circles = new OrderedDictionary
                                   {
                                       {Outline.Bullseye, new Circle(15, 0)},
                                       {Outline.Bull, new Circle(35, 0)},
                                       {Outline.InnerSingle, new Circle(188, 0)},
                                       {Outline.Triple, new Circle(209, -1)},
                                       {Outline.OuterSingle, new Circle(313, -1)},
                                       {Outline.Double, new Circle(335, -1)}
                                   };

        private readonly List<GraphicsPath> _graphicsPaths = new List<GraphicsPath>();

        public BoardGrid(Point center, Graphics graphics)
        {
            _center = center;
            _graphics = graphics;
            _graphics.TranslateTransform(_center.X, _center.Y);
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            AddCircleToGrid(Outline.Bullseye);
            AddCircleToGrid(Outline.Bull);

            for (var circleIndex = 1; circleIndex < _circles.Count - 1; ++circleIndex)
            {
                for (var sliceIndex = 0; sliceIndex < _slices.Count; ++sliceIndex)
                {
                    AddPolygonToGrid((Circle)_circles[circleIndex], (Circle)_circles[circleIndex + 1],
                       _slices[sliceIndex].BeginAngle, _slices[sliceIndex + 1 == _slices.Count ? 0 : sliceIndex + 1].BeginAngle);
                }
            }
        }

        private void AddCircleToGrid(Outline outline)
        {
            var circle = (Circle)_circles[outline];
            var radius = circle.Radius;
            var offset = circle.Offset;
            var x = -radius + offset;
            var y = -radius + offset;
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(x, y, radius * 2, radius * 2);
            _graphicsPaths.Add(graphicsPath);
        }

        private void AddPolygonToGrid(Circle innerCircle, Circle outerCircle, int beginAngle, int endAngle)
        {
            var polygonPoints = new PointF[38];

            polygonPoints[0] = new PointF(XOnCircle(beginAngle, innerCircle.Radius) + innerCircle.Offset, YOnCircle(beginAngle, innerCircle.Radius) + innerCircle.Offset);
            polygonPoints[1] = new PointF(XOnCircle(beginAngle, outerCircle.Radius) + outerCircle.Offset, YOnCircle(beginAngle, outerCircle.Radius) + outerCircle.Offset);
            for (var outerCircleIndex = 2; outerCircleIndex < 19; ++outerCircleIndex)
            {
                polygonPoints[outerCircleIndex] = new PointF(XOnCircle(beginAngle + (outerCircleIndex - 1), outerCircle.Radius) + outerCircle.Offset,
                    YOnCircle(beginAngle + (outerCircleIndex - 1), outerCircle.Radius) + outerCircle.Offset);
            }
            polygonPoints[19] = new PointF(XOnCircle(endAngle, outerCircle.Radius) + outerCircle.Offset, YOnCircle(endAngle, outerCircle.Radius) + outerCircle.Offset);
            polygonPoints[20] = new PointF(XOnCircle(endAngle, innerCircle.Radius) + innerCircle.Offset, YOnCircle(endAngle, innerCircle.Radius) + innerCircle.Offset);
            for (var innerCircleIndex = 21; innerCircleIndex < 38; ++innerCircleIndex)
            {
                polygonPoints[innerCircleIndex] = new PointF(XOnCircle(endAngle - (innerCircleIndex - 20), innerCircle.Radius) + innerCircle.Offset,
                    YOnCircle(endAngle - (innerCircleIndex - 20), innerCircle.Radius) + innerCircle.Offset);
            }

            var graphicsPath = new GraphicsPath();
            graphicsPath.AddPolygon(polygonPoints);
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

        public void HighlightPolygon(int mouseX, int mouseY)
        {
            var gridX = mouseX - _center.X;
            var gridY = mouseY - _center.Y;

            foreach (var graphicsPath in _graphicsPaths)
            {
                if (graphicsPath.IsVisible(gridX, gridY))
                {
                    _graphics.FillPath(YellowBrush, graphicsPath);
                    break;
                }
            }
        }
    }
}
