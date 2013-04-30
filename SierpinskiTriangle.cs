using System;
//using System.Collections.Generic;
//using System.Text;
using System.Drawing;
using System.Threading;

namespace FractalViewer
{
    class SierpinskiTriangle
    {
        private Graphics g;
        private Color color;
        private Brush colorBrush;
        private Pen colorPen;
        private float precision;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="g">Control's graphics</param>
        /// <param name="color">Color for the fractal</param>
        public SierpinskiTriangle(Graphics g, Color color)
        {
            this.g = g;
            this.color = color;
        }

        public void draw(int width, int height, float precision)
        {
            colorBrush = new SolidBrush(color);
            colorPen = new Pen(colorBrush, 1.0F);
            this.precision = precision;

            Point top = new Point(width >> 1, height - (int)(height * 0.90));
            Point bottomLeft = new Point(width - (int)(width * 0.90), height - (int)(height * 0.10));
            Point bottomRight = new Point(width - (int)(width * 0.10), height - (int)(height * 0.10));

            //Draw outer triangle
            g.DrawLine(colorPen, top, bottomLeft);
            g.DrawLine(colorPen, bottomLeft, bottomRight);
            g.DrawLine(colorPen, bottomRight, top);

            Point midpointLeft = new Point(Math.Abs(top.X + bottomLeft.X) >> 1, Math.Abs(top.Y + bottomLeft.Y) >> 1);
            Point midpointBottom = new Point(Math.Abs(bottomLeft.X + bottomRight.X) >> 1, Math.Abs(bottomLeft.Y + bottomRight.Y) >> 1);
            Point midpointRight = new Point(Math.Abs(bottomRight.X + top.X) >> 1, Math.Abs(bottomRight.Y + top.Y) >> 1);

            //Draw inner 3 triangles
            g.DrawLine(colorPen, midpointLeft, midpointBottom);
            g.DrawLine(colorPen, midpointBottom, midpointRight);
            g.DrawLine(colorPen, midpointRight, midpointLeft);

            //recursive draw within each of the 3 triangles
            DrawSierp(top,midpointLeft,midpointRight);
            DrawSierp(midpointLeft,bottomLeft,midpointBottom);
            DrawSierp(midpointRight,midpointBottom, bottomRight);

            colorPen.Dispose();
            colorBrush.Dispose();
        }

        public void DrawSierp(Point a, Point b, Point c)
        {
            if ((a.X - b.X) > this.precision)//not to small to draw
            {
                DrawSierp(a, new Point((a.X + b.X) >> 1, (a.Y + b.Y) >> 1), new Point((c.X + a.X) >> 1, (c.Y + a.Y) >> 1));
                DrawSierp(new Point((a.X + b.X) >> 1, (a.Y + b.Y) >> 1), b, new Point((b.X + c.X) >> 1, (b.Y + c.Y) >> 1));
                DrawSierp(new Point((c.X + a.X) >> 1, (c.Y + a.Y) >> 1), new Point((b.X + c.X) >> 1, (b.Y + c.Y) >> 1), c);
            }
            else
            {
                return;
            }
 
            g.DrawLine(colorPen, a, b);
            g.DrawLine(colorPen, b, c);
            g.DrawLine(colorPen, c, a);
            g.DrawLine(colorPen, a, new Point((a.X + b.X) >> 1, (a.Y + b.Y) >> 1));
            g.DrawLine(colorPen, b, new Point((a.X + b.X) >> 1, (a.Y + b.Y) >> 1));
            g.DrawLine(colorPen, c, new Point((b.X + c.X) >> 1, (b.Y + c.Y) >> 1));
            g.DrawLine(colorPen, a, new Point((c.X + a.X) >> 1, (c.Y + a.Y) >> 1));
            g.DrawLine(colorPen, b, new Point((b.X + c.X) >> 1, (b.Y + c.Y) >> 1));
            g.DrawLine(colorPen, c, new Point((c.X + a.X) >> 1, (c.Y + a.Y) >> 1));

        }
    }
}
