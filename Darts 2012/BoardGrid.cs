using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Darts_2012
{
    class BoardGrid
    {
        enum Cicles
        {
            POINT_OF_ORIGIN,
            BULLSEYE,
            BULL,
            INNER_SINGLE,
            TRIPLE,
            OUTER_SINGLE,
            DOUBLE
        }

        private const string OFFSET = "offset";
        private const string RADIUS = "radius";

        private static Brush cyanBrush = new SolidBrush(Color.Cyan);
        private static Pen cyanPen = new Pen(Color.Cyan);
        private static Brush yellowBrush = new SolidBrush(Color.Yellow);

        private Point center;
        private int width;
        private int height;
        private List<SolidBrush> brushes;
        private OrderedDictionary angleOfNumbers;
        private OrderedDictionary radiiAndOffsets;

        public BoardGrid(Point center, int width, int height)
        {
            this.center = center;
            this.width = width;
            this.height = height;

            initializeBrushes();
            initializeAngles();
            initializeRadiiAndOffsets();
        }

        private void initializeBrushes()
        {
            brushes = new List<SolidBrush>(4);
            brushes.Add(new SolidBrush(Color.Red));
            brushes.Add(new SolidBrush(Color.Green));
            brushes.Add(new SolidBrush(Color.Black));
            brushes.Add(new SolidBrush(Color.White));
        }

        private void initializeAngles()
        {
            angleOfNumbers = new OrderedDictionary();
            angleOfNumbers.Add(20, 261);
            angleOfNumbers.Add(1, 279);
            angleOfNumbers.Add(18, 297);
            angleOfNumbers.Add(4, 315);
            angleOfNumbers.Add(13, 333);
            angleOfNumbers.Add(6, 351);
            angleOfNumbers.Add(10, 9);
            angleOfNumbers.Add(15, 27);
            angleOfNumbers.Add(2, 45);
            angleOfNumbers.Add(17, 63);
            angleOfNumbers.Add(3, 81);
            angleOfNumbers.Add(19, 99);
            angleOfNumbers.Add(7, 117);
            angleOfNumbers.Add(16, 135);
            angleOfNumbers.Add(8, 153);
            angleOfNumbers.Add(11, 171);
            angleOfNumbers.Add(14, 189);
            angleOfNumbers.Add(9, 207);
            angleOfNumbers.Add(12, 225);
            angleOfNumbers.Add(5, 243);
        }

        private void initializeRadiiAndOffsets()
        {
            HybridDictionary pointOfOriginRadiusAndOffset = new HybridDictionary();
            pointOfOriginRadiusAndOffset.Add(RADIUS, 0);
            pointOfOriginRadiusAndOffset.Add(OFFSET, 0);
            HybridDictionary bullsEyeRadiusAndOffset = new HybridDictionary();
            bullsEyeRadiusAndOffset.Add(RADIUS, 15);
            bullsEyeRadiusAndOffset.Add(OFFSET, 0);
            HybridDictionary bullRadiusAndOffset = new HybridDictionary();
            bullRadiusAndOffset.Add(RADIUS, 35);
            bullRadiusAndOffset.Add(OFFSET, 0);
            HybridDictionary innerSingleRadiusAndOffset = new HybridDictionary();
            innerSingleRadiusAndOffset.Add(RADIUS, 188);
            innerSingleRadiusAndOffset.Add(OFFSET, 0);
            HybridDictionary tripleRadiusAndOffset = new HybridDictionary();
            tripleRadiusAndOffset.Add(RADIUS, 209);
            tripleRadiusAndOffset.Add(OFFSET, -1);
            HybridDictionary outerSingleRadiusAndOffset = new HybridDictionary();
            outerSingleRadiusAndOffset.Add(RADIUS, 313);
            outerSingleRadiusAndOffset.Add(OFFSET, -1);
            HybridDictionary doubleRadiusAndOffset = new HybridDictionary();
            doubleRadiusAndOffset.Add(RADIUS, 335);
            doubleRadiusAndOffset.Add(OFFSET, -1);

            radiiAndOffsets = new OrderedDictionary();
            radiiAndOffsets.Add(Cicles.POINT_OF_ORIGIN, pointOfOriginRadiusAndOffset);
            radiiAndOffsets.Add(Cicles.BULLSEYE, bullsEyeRadiusAndOffset);
            radiiAndOffsets.Add(Cicles.BULL, bullRadiusAndOffset);
            radiiAndOffsets.Add(Cicles.INNER_SINGLE, innerSingleRadiusAndOffset);
            radiiAndOffsets.Add(Cicles.TRIPLE, tripleRadiusAndOffset);
            radiiAndOffsets.Add(Cicles.OUTER_SINGLE, outerSingleRadiusAndOffset);
            radiiAndOffsets.Add(Cicles.DOUBLE, doubleRadiusAndOffset);
        }

        public void drawGrid(Graphics graphics)
        {
            graphics.TranslateTransform(center.X, center.Y);

            for (int radiiAndOffsetsIndex = 0; radiiAndOffsetsIndex < radiiAndOffsets.Count - 1; ++radiiAndOffsetsIndex)
            {
                for (int angleIndex = 0; angleIndex < angleOfNumbers.Count; ++angleIndex)
                {
                    drawDouble(graphics, brushes[angleIndex % 2 + radiiAndOffsetsIndex % 2],
                           (HybridDictionary)radiiAndOffsets[radiiAndOffsetsIndex], (HybridDictionary)radiiAndOffsets[radiiAndOffsetsIndex + 1],
                           (int)angleOfNumbers[angleIndex], (int)angleOfNumbers[angleIndex + 1 == angleOfNumbers.Count ? 0 : angleIndex + 1]);
                }
            }

            graphics.ResetTransform();
            graphics.FillRectangle(yellowBrush, center.X, 0, 1, height);
            graphics.FillRectangle(yellowBrush, 0, center.Y, width, 1);
        }

        private static void drawDouble(Graphics graphics, Brush brush, HybridDictionary innerCircle, HybridDictionary outerCircle, int beginAngle, int endAngle)
        {
            PointF[] polygonPoints = new PointF[38];
            polygonPoints[0] = new PointF(xOnCircle(beginAngle, (int)innerCircle[RADIUS]) + (int)innerCircle[OFFSET], yOnCircle(beginAngle, (int)innerCircle[RADIUS]) + (int)innerCircle[OFFSET]);
            polygonPoints[1] = new PointF(xOnCircle(beginAngle, (int)outerCircle[RADIUS]) + (int)outerCircle[OFFSET], yOnCircle(beginAngle, (int)outerCircle[RADIUS]) + (int)outerCircle[OFFSET]);
            for (int i = 2; i < 19; ++i)
            {
                polygonPoints[i] = new PointF(xOnCircle(beginAngle + (i - 1), (int)outerCircle[RADIUS]) + (int)outerCircle[OFFSET], yOnCircle(beginAngle + (i - 1), (int)outerCircle[RADIUS]) + (int)outerCircle[OFFSET]);
            }
            polygonPoints[19] = new PointF(xOnCircle(endAngle, (int)outerCircle[RADIUS]) + (int)outerCircle[OFFSET], yOnCircle(endAngle, (int)outerCircle[RADIUS]) + (int)outerCircle[OFFSET]);
            polygonPoints[20] = new PointF(xOnCircle(endAngle, (int)innerCircle[RADIUS]) + (int)innerCircle[OFFSET], yOnCircle(endAngle, (int)innerCircle[RADIUS]) + (int)innerCircle[OFFSET]);
            for (int i = 21; i < 38; ++i)
            {
                polygonPoints[i] = new PointF(xOnCircle(endAngle - (i - 20), (int)innerCircle[RADIUS]) + (int)innerCircle[OFFSET], yOnCircle(endAngle - (i - 20), (int)innerCircle[RADIUS]) + (int)innerCircle[OFFSET]);
            }
            graphics.FillPolygon(brush, polygonPoints);
        }

        private void drawCircle(Graphics graphics, int radius, int offset)
        {
            int x = center.X - radius + offset;
            int y = center.Y - radius + offset;
            graphics.DrawEllipse(cyanPen, x, y, radius * 2, radius * 2);
        }

        private static float xOnCircle(int angle, int radius)
        {
            return radius * (float)Math.Cos(angle * Math.PI / 180);
        }

        private static float yOnCircle(int angle, int radius)
        {
            return radius * (float)Math.Sin(angle * Math.PI / 180);
        }
    }
}
