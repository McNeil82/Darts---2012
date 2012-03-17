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
            graphics.FillRectangle(cyanBrush, middle.X, 0, 1, height);
            graphics.FillRectangle(cyanBrush, 0, middle.Y, width, 1);

            drawCircle(graphics, bullsEyeRadius, bullsEyeOffset);
            drawCircle(graphics, bullRadius, bullOffset);
            drawCircle(graphics, innerSingleRadius, innerSingleOffset);
            drawCircle(graphics, tripleRadius, tripleOffset);
            drawCircle(graphics, outerSingleRadius, outerSingleOffset);
            drawCircle(graphics, doubleRadius, doubleOffset);
        }

        private void drawCircle(Graphics graphics, int radius, int offset)
        {
            int x = middle.X - radius - offset;
            int y = middle.Y - radius - offset;
            graphics.DrawEllipse(yellowPen, x, y, radius * 2, radius * 2);
        }
    }
}
