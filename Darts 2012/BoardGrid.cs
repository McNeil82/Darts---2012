using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Darts_2012
{
    class BoardGrid
    {
        private static Brush cyanBrush = new SolidBrush(Color.Cyan);
        private static Pen cyanPen = new Pen(cyanBrush);
        private static Brush yellowBrush = new SolidBrush(Color.Yellow);
        private static Pen yellowPen = new Pen(yellowBrush);

        private static int bullsEyeRadius = 15;
        private static int bullsEyeOffset = 0;
        private static int bullRadius = 35;
        private static int bullOffset = 0;
        private static int innerSingleRadius = 188;
        private static int innerSingleOffset = 0;
        private static int tripleRadius = 209;
        private static int tripleOffset = -1;
        private static int outerSingleRadius = 313;
        private static int outerSingleOffset = -1;
        private static int doubleRadius = 334;
        private static int doubleOffset = -2;

        private Point center;
        private int width;
        private int height;
        OrderedDictionary angleOfNumbers;

        public BoardGrid(Point center, int width, int height)
        {
            this.center = center;
            this.width = width;
            this.height = height;

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

        public void drawGrid(Graphics graphics)
        {
            graphics.FillRectangle(yellowBrush, center.X, 0, 1, height);
            graphics.FillRectangle(yellowBrush, 0, center.Y, width, 1);

            drawCircle(graphics, bullsEyeRadius, bullsEyeOffset);
            drawCircle(graphics, bullRadius, bullOffset);
            drawCircle(graphics, innerSingleRadius, innerSingleOffset);
            drawCircle(graphics, tripleRadius, tripleOffset);
            drawCircle(graphics, outerSingleRadius, outerSingleOffset);
            drawCircle(graphics, doubleRadius, doubleOffset);

            graphics.TranslateTransform(center.X, center.Y);

            for (int i = 0; i < angleOfNumbers.Count; ++i)
            {
                drawDouble(graphics, (int)angleOfNumbers[i], (int)angleOfNumbers[i + 1 == angleOfNumbers.Count ? 0 : i + 1]);
            }
        }

        private static void drawDouble(Graphics graphics, int beginAngle, int endAngle)
        {
            PointF[] polygonPoints = new PointF[38];
            polygonPoints[0] = new PointF(xOnCircle(beginAngle, outerSingleRadius) + outerSingleOffset, yOnCircle(beginAngle, outerSingleRadius) + outerSingleOffset);
            polygonPoints[1] = new PointF(xOnCircle(beginAngle, doubleRadius) + doubleOffset, yOnCircle(beginAngle, doubleRadius) + doubleOffset);
            for (int i = 2; i < 19; ++i)
            {
                polygonPoints[i] = new PointF(xOnCircle(beginAngle + (i - 1), doubleRadius) + doubleOffset, yOnCircle(beginAngle + (i - 1), doubleRadius) + doubleOffset);
            }
            polygonPoints[19] = new PointF(xOnCircle(endAngle, doubleRadius) + doubleOffset, yOnCircle(endAngle, doubleRadius) + doubleOffset);
            polygonPoints[20] = new PointF(xOnCircle(endAngle, outerSingleRadius) + outerSingleOffset, yOnCircle(endAngle, outerSingleRadius) + outerSingleOffset);
            for (int i = 21; i < 38; ++i)
            {
                polygonPoints[i] = new PointF(xOnCircle(endAngle - (i - 20), outerSingleRadius) + outerSingleOffset, yOnCircle(endAngle - (i - 20), outerSingleRadius) + outerSingleOffset);
            }
            graphics.FillPolygon(yellowBrush, polygonPoints);
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
