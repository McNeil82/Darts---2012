using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Darts_2012.Poco;

namespace Darts_2012
{
    class Board
    {
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

        private static readonly List<Circle> Circles = new List<Circle>
                                                           {
                                new Circle(15, 0, 50),
                                new Circle(35, 0, 25),
                                new Circle(188, 0, 1),
                                new Circle(209, -1, 3),
                                new Circle(313, -1, 1),
                                new Circle(335, -1, 2)
                            };

        private readonly List<Piece> _circlePieces = new List<Piece>();
        private readonly List<Piece> _slicePieces = new List<Piece>();

        private readonly int _outmostCircleRadius = Circles[Circles.Count - 1].Radius;
        private readonly int _outmostCircleOffset = Circles[Circles.Count - 1].Offset;

        public Board()
        {
            InitializePieces();
        }

        private void InitializePieces()
        {
            foreach (var circle in Circles)
            {
                AddPiece(circle);
            }

            foreach (var slice in _slices)
            {
                AddPiece(slice);
            }
        }

        private void AddPiece(Circle circle)
        {
            var radius = circle.Radius;
            var offset = circle.Offset;
            var x = -radius + offset;
            var y = -radius + offset;
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(x, y, radius * 2, radius * 2);
            _circlePieces.Add(new Piece(circle.Value, graphicsPath));
        }

        private void AddPiece(Slice slice)
        {
            var polygonPoints = new PointF[20];

            for (var angleIndex = 0; angleIndex < 19; ++angleIndex)
            {
                var circlePointX = XOnCircle(slice.BeginAngle + angleIndex, _outmostCircleRadius) + _outmostCircleOffset;
                var circlePointY = YOnCircle(slice.BeginAngle + angleIndex, _outmostCircleRadius) + _outmostCircleOffset;
                polygonPoints[angleIndex] = new PointF(circlePointX, circlePointY);
            }
            polygonPoints[19] = new PointF(0, 0);

            var graphicsPath = new GraphicsPath();
            graphicsPath.AddPolygon(polygonPoints);
            _slicePieces.Add(new Piece(slice.Value, graphicsPath));
        }

        private static float XOnCircle(int angle, int radius)
        {
            return radius * (float)Math.Cos(angle * Math.PI / 180);
        }

        private static float YOnCircle(int angle, int radius)
        {
            return radius * (float)Math.Sin(angle * Math.PI / 180);
        }

        public Throw DetectThrow(int mouseX, int mouseY, int centerX, int centerY)
        {
            var @throw = new Throw();
            var gridX = mouseX - centerX;
            var gridY = mouseY - centerY;

            for (var circleIndex = 0; circleIndex < _circlePieces.Count; circleIndex++)
            {
                var circle = _circlePieces[circleIndex];
                if (circle.GraphicsPath.IsVisible(gridX, gridY))
                {
                    if (circleIndex < 2)
                    {
                        @throw.Value = circle.Value;
                        @throw.Multiplier = 1;
                        return @throw;
                    }

                    @throw.Multiplier = circle.Value;
                    break;
                }
            }

            foreach (var slice in _slicePieces)
            {
                if (slice.GraphicsPath.IsVisible(gridX, gridY))
                {
                    @throw.Value = slice.Value;
                    return @throw;
                }
            }

            return @throw;
        }
    }
}
