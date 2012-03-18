using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Darts_2012
{
    class Board
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
                                       {Outline.Bullseye, new Circle(15, 0, 50)},
                                       {Outline.Bull, new Circle(35, 0, 25)},
                                       {Outline.InnerSingle, new Circle(188, 0, 1)},
                                       {Outline.Triple, new Circle(209, -1, 3)},
                                       {Outline.OuterSingle, new Circle(313, -1, 1)},
                                       {Outline.Double, new Circle(335, -1, 2)}
                                   };

        private readonly List<Piece> _circlePieces = new List<Piece>();
        private readonly List<Piece> _slicePieces = new List<Piece>();

        public Board()
        {
            InitializePieces();
        }

        private void InitializePieces()
        {
            AddPiece(Outline.Bullseye);
            AddPiece(Outline.Bull);
            AddPiece(Outline.InnerSingle);
            AddPiece(Outline.Triple);
            AddPiece(Outline.OuterSingle);
            AddPiece(Outline.Double);

            for (var sliceIndex = 0; sliceIndex < _slices.Count; ++sliceIndex)
            {
                var outerCircle = (Circle)_circles[Outline.Double];
                var slice = _slices[sliceIndex];
                AddPiece(outerCircle, slice);
            }
        }

        private void AddPiece(Outline outline)
        {
            var circle = (Circle)_circles[outline];
            var radius = circle.Radius;
            var offset = circle.Offset;
            var x = -radius + offset;
            var y = -radius + offset;
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(x, y, radius * 2, radius * 2);
            _circlePieces.Add(new Piece(circle.Value, graphicsPath));
        }

        private void AddPiece(Circle outerCircle, Slice slice)
        {
            var polygonPoints = new PointF[20];

            for (var outerCircleIndex = 0; outerCircleIndex < 19; ++outerCircleIndex)
            {
                polygonPoints[outerCircleIndex] = new PointF(XOnCircle(slice.BeginAngle + outerCircleIndex, outerCircle.Radius) + outerCircle.Offset,
                    YOnCircle(slice.BeginAngle + outerCircleIndex, outerCircle.Radius) + outerCircle.Offset);
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

        public int GetPoints(int mouseX, int mouseY, int centerX, int centerY)
        {
            var circlePoints = 0;
            var gridX = mouseX - centerX;
            var gridY = mouseY - centerY;

            for (var circleIndex = 0; circleIndex < _circlePieces.Count; circleIndex++)
            {
                var circle = _circlePieces[circleIndex];
                if (circle.GraphicsPath.IsVisible(gridX, gridY))
                {
                    if (circleIndex < 2)
                    {
                        return circle.Value;
                    }

                    circlePoints = circle.Value;
                    break;
                }
            }

            foreach (var slice in _slicePieces)
            {
                if (slice.GraphicsPath.IsVisible(gridX, gridY))
                {
                    return circlePoints * slice.Value;
                }
            }

            return circlePoints;
        }
    }
}
