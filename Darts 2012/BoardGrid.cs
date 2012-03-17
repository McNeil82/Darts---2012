using System;
using System.Collections.Generic;
using System.Drawing;
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
        private static int tripleOffset = 1;
        private static int outerSingleRadius = 313;
        private static int outerSingleOffset = 1;
        private static int doubleRadius = 334;
        private static int doubleOffset = 2;
        
        private static Point pointZero = new Point(0, 0);
        private static int sixAngle = 351;
        private static int tenAngle = 9;
        private static int fifteenAngle = 27;
        private static int twoAngle = 45;
        private static int sevenTeenAngle = 63;
        private static int threeAngle = 81;
        private static int nineTeenAngle = 99;
        private static int sevenAngle = 117;
        private static int sixTeenAngle = 135;
        private static int eightAngle = 153;
        private static int elevenAngle = 171;
        private static int fourTeenAngle = 189;
        private static int nineAngle = 207;
        private static int twelveAngle = 225;
        private static int fiveAngle = 243;
        private static int twentyAngle = 261;
        private static int oneAngle = 279;
        private static int eightTeenAngle = 297;
        private static int fourAngle = 315;
        private static int thirTeenAngle = 333;

        private Point middle;
        private int width;
        private int height;

        public BoardGrid(Point middle, int width, int height)
        {
            this.middle = middle;
            this.width = width;
            this.height = height;
        }

        public void drawGrid(Graphics graphics)
        {
            graphics.FillRectangle(yellowBrush, middle.X, 0, 1, height);
            graphics.FillRectangle(yellowBrush, 0, middle.Y, width, 1);

            drawCircle(graphics, bullsEyeRadius, bullsEyeOffset);
            drawCircle(graphics, bullRadius, bullOffset);
            drawCircle(graphics, innerSingleRadius, innerSingleOffset);
            drawCircle(graphics, tripleRadius, tripleOffset);
            drawCircle(graphics, outerSingleRadius, outerSingleOffset);
            drawCircle(graphics, doubleRadius, doubleOffset);

            graphics.TranslateTransform(middle.X, middle.Y);
            drawLine(graphics, sixAngle);
            drawLine(graphics, tenAngle);
            drawLine(graphics, fifteenAngle);
            drawLine(graphics, twoAngle);
            drawLine(graphics, sevenTeenAngle);
            drawLine(graphics, threeAngle);
            drawLine(graphics, nineTeenAngle);
            drawLine(graphics, sevenAngle);
            drawLine(graphics, sixTeenAngle);
            drawLine(graphics, eightAngle);
            drawLine(graphics, elevenAngle);
            drawLine(graphics, fourTeenAngle);
            drawLine(graphics, nineAngle);
            drawLine(graphics, twelveAngle);
            drawLine(graphics, fiveAngle);
            drawLine(graphics, twentyAngle);
            drawLine(graphics, oneAngle);
            drawLine(graphics, eightTeenAngle);
            drawLine(graphics, fourAngle);
            drawLine(graphics, thirTeenAngle);
        }

        private void drawCircle(Graphics graphics, int radius, int offset)
        {
            int x = middle.X - radius - offset;
            int y = middle.Y - radius - offset;
            graphics.DrawEllipse(cyanPen, x, y, radius * 2, radius * 2);
        }

        private static void drawLine(Graphics graphics, int angle)
        {
            PointF pointOnDouble = new PointF(xOnCircle(angle, doubleRadius), yOnCircle(angle, doubleRadius));
            graphics.DrawLine(cyanPen, pointZero, pointOnDouble);
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
