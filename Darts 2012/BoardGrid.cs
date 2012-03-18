using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;

namespace Darts_2012
{
    class BoardGrid
    {
        enum Cicles
        {
            PointOfOrigin,
            Bullseye,
            Bull,
            InnerSingle,
            Triple,
            OuterSingle,
            Double
        }

        private const string Offset = "offset";
        private const string Radius = "radius";

        private static readonly Brush YellowBrush = new SolidBrush(Color.Yellow);

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
        private readonly OrderedDictionary _angleOfNumbers = new OrderedDictionary
                                  {
                                      {20, 261},
                                      {1, 279},
                                      {18, 297},
                                      {4, 315},
                                      {13, 333},
                                      {6, 351},
                                      {10, 9},
                                      {15, 27},
                                      {2, 45},
                                      {17, 63},
                                      {3, 81},
                                      {19, 99},
                                      {7, 117},
                                      {16, 135},
                                      {8, 153},
                                      {11, 171},
                                      {14, 189},
                                      {9, 207},
                                      {12, 225},
                                      {5, 243}
                                  };
        private readonly OrderedDictionary _radiiAndOffsets = new OrderedDictionary
                                   {
                                       {Cicles.PointOfOrigin, new HybridDictionary { { Radius, 0 }, { Offset, 0 } }},
                                       {Cicles.Bullseye, new HybridDictionary { { Radius, 15 }, { Offset, 0 } }},
                                       {Cicles.Bull, new HybridDictionary { { Radius, 35 }, { Offset, 0 } }},
                                       {Cicles.InnerSingle, new HybridDictionary { { Radius, 188 }, { Offset, 0 } }},
                                       {Cicles.Triple, new HybridDictionary { { Radius, 209 }, { Offset, -1 } }},
                                       {Cicles.OuterSingle, new HybridDictionary { { Radius, 313 }, { Offset, -1 } }},
                                       {Cicles.Double, new HybridDictionary { { Radius, 335 }, { Offset, -1 } }}
                                   };

        public BoardGrid(Point center, int width, int height)
        {
            _center = center;
            _width = width;
            _height = height;
        }

        public void DrawGrid(Graphics graphics)
        {
            graphics.TranslateTransform(_center.X, _center.Y);

            for (int radiiAndOffsetsIndex = 0; radiiAndOffsetsIndex < _radiiAndOffsets.Count - 1; ++radiiAndOffsetsIndex)
            {
                for (int angleIndex = 0; angleIndex < _angleOfNumbers.Count; ++angleIndex)
                {
                    DrawDouble(graphics, _brushes[angleIndex % 2 + radiiAndOffsetsIndex % 2],
                           (HybridDictionary)_radiiAndOffsets[radiiAndOffsetsIndex], (HybridDictionary)_radiiAndOffsets[radiiAndOffsetsIndex + 1],
                           (int)_angleOfNumbers[angleIndex], (int)_angleOfNumbers[angleIndex + 1 == _angleOfNumbers.Count ? 0 : angleIndex + 1]);
                }
            }

            graphics.ResetTransform();
            graphics.FillRectangle(YellowBrush, _center.X, 0, 1, _height);
            graphics.FillRectangle(YellowBrush, 0, _center.Y, _width, 1);
        }

        private static void DrawDouble(Graphics graphics, Brush brush, HybridDictionary innerCircle, HybridDictionary outerCircle, int beginAngle, int endAngle)
        {
            var polygonPoints = new PointF[38];
            polygonPoints[0] = new PointF(XOnCircle(beginAngle, (int)innerCircle[Radius]) + (int)innerCircle[Offset], YOnCircle(beginAngle, (int)innerCircle[Radius]) + (int)innerCircle[Offset]);
            polygonPoints[1] = new PointF(XOnCircle(beginAngle, (int)outerCircle[Radius]) + (int)outerCircle[Offset], YOnCircle(beginAngle, (int)outerCircle[Radius]) + (int)outerCircle[Offset]);
            for (var outerCircleIndex = 2; outerCircleIndex < 19; ++outerCircleIndex)
            {
                polygonPoints[outerCircleIndex] = new PointF(XOnCircle(beginAngle + (outerCircleIndex - 1), (int)outerCircle[Radius]) + (int)outerCircle[Offset], YOnCircle(beginAngle + (outerCircleIndex - 1), (int)outerCircle[Radius]) + (int)outerCircle[Offset]);
            }
            polygonPoints[19] = new PointF(XOnCircle(endAngle, (int)outerCircle[Radius]) + (int)outerCircle[Offset], YOnCircle(endAngle, (int)outerCircle[Radius]) + (int)outerCircle[Offset]);
            polygonPoints[20] = new PointF(XOnCircle(endAngle, (int)innerCircle[Radius]) + (int)innerCircle[Offset], YOnCircle(endAngle, (int)innerCircle[Radius]) + (int)innerCircle[Offset]);
            for (var innerCircleIndex = 21; innerCircleIndex < 38; ++innerCircleIndex)
            {
                polygonPoints[innerCircleIndex] = new PointF(XOnCircle(endAngle - (innerCircleIndex - 20), (int)innerCircle[Radius]) + (int)innerCircle[Offset], YOnCircle(endAngle - (innerCircleIndex - 20), (int)innerCircle[Radius]) + (int)innerCircle[Offset]);
            }
            graphics.FillPolygon(brush, polygonPoints);
        }

        private static float XOnCircle(int angle, int radius)
        {
            return radius * (float)Math.Cos(angle * Math.PI / 180);
        }

        private static float YOnCircle(int angle, int radius)
        {
            return radius * (float)Math.Sin(angle * Math.PI / 180);
        }
    }
}
