using System;
//using System.Collections.Generic;
//using System.Text;
using System.Drawing;

namespace FractalViewer
{
    class BoxFractal
    {
        private Graphics g;
        private Color backgroundColor;
        private Color mainColor;
        private float precision;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="g">Control's graphics to enable drawing onto. </param>
        /// <param name="backgroundColor">The color for the background. </param>
        /// <param name="mainColor">Color of the fractal. </param>
        public BoxFractal(Graphics g, Color backgroundColor, Color mainColor, float precision)
        {
            this.g = g;
            this.backgroundColor = backgroundColor;
            this.mainColor = mainColor;
            this.precision = precision;
        }

        /// <summary>
        /// Starts the drawing processes with a solid square block then calls the recursive drawing to finish removing parts.
        /// </summary>
        /// <param name="iwidth">Width of the control to draw on. </param>
        /// <param name="iheight">Height of the control to draw on. </param>
        public void draw(int iwidth, int iheight)
        {
            float third = 0.33333F;
            //Create pens/brushes
            Brush colorBrush = new SolidBrush(mainColor);
            Pen colorPen = new Pen(colorBrush, 1.0F);
            Brush backgroundBrush = new SolidBrush(backgroundColor);
            Pen backgroundPen = new Pen(backgroundBrush, 1.0F);

            //Shift the upperLeft point to make room for tool strip at top
            PointF upperLeft = new PointF((iwidth) * 0.04F, (iheight) * 0.04F);
            //Shift height to fit inside.
            float width = (iheight * 0.95F);

            //draw main block
            g.FillRectangle(colorBrush, upperLeft.X, upperLeft.Y, width, width);

            //sub divide the block by clearing top-middle, right-middle, bottom-middle, and left-middle.
            PointF top = new PointF(upperLeft.X + width * third, upperLeft.Y);
            g.FillRectangle(backgroundBrush, top.X, top.Y, width * third, width * third);

            PointF left = new PointF(upperLeft.X, upperLeft.Y + width * third);
            g.FillRectangle(backgroundBrush, left.X, left.Y, width * third, width * third);

            PointF right = new PointF(upperLeft.X + 2 * width * third, upperLeft.Y + width * third);
            g.FillRectangle(backgroundBrush, right.X, right.Y, width * third, width * third);

            PointF bottom = new PointF(upperLeft.X + width * third, upperLeft.Y + 2 * width * third);
            g.FillRectangle(backgroundBrush, bottom.X, bottom.Y, width * third, width * third);

            //Clean up
            colorPen.Dispose();
            backgroundPen.Dispose();
            colorBrush.Dispose();
            backgroundBrush.Dispose();

            DrawBox(upperLeft, width * third);
            DrawBox(new PointF(upperLeft.X + 2 * width * third, upperLeft.Y), width * third);
            DrawBox(new PointF(upperLeft.X + width * third, upperLeft.Y + width * third), width * third);
            DrawBox(new PointF(upperLeft.X, upperLeft.Y + 2 * width * third), width * third);
            DrawBox(new PointF(upperLeft.X + 2 * width * third, upperLeft.Y + 2 * width * third), width * third);
        }

        /// <summary>
        /// Recursive function to remove parts of the square block.  
        /// </summary>
        /// <param name="upperLeft">The upper left of the block. </param>
        /// <param name="width">Represents the length. </param>
        private void DrawBox(PointF upperLeft, float width)
        {
            float third = 0.33333F;
            if (width * third > this.precision)
            {
                Brush backgroundBrush = new SolidBrush(backgroundColor);

                //Remove 4 more blocks
                PointF top = new PointF(upperLeft.X + width * third, upperLeft.Y);
                this.g.FillRectangle(backgroundBrush, top.X, top.Y, width * third, width * third);

                PointF left = new PointF(upperLeft.X, upperLeft.Y + width * third);
                this.g.FillRectangle(backgroundBrush, left.X, left.Y, width * third, width * third);

                PointF right = new PointF(upperLeft.X + 2 * width * third, upperLeft.Y + width * third);
                this.g.FillRectangle(backgroundBrush, right.X, right.Y, width * third, width * third);

                PointF bottom = new PointF(upperLeft.X + width * third, upperLeft.Y + 2 * width * third);
                this.g.FillRectangle(backgroundBrush, bottom.X, bottom.Y, width * third, width * third);

                backgroundBrush.Dispose();

                //Recursive into the 5 remaining.
                DrawBox(upperLeft, width * third);
                DrawBox(new PointF(upperLeft.X + 2 * width * third, upperLeft.Y), width * third);
                DrawBox(new PointF(upperLeft.X + width * third, upperLeft.Y + width * third), width * third);
                DrawBox(new PointF(upperLeft.X, upperLeft.Y + 2 * width * third), width * third);
                DrawBox(new PointF(upperLeft.X + 2 * width * third, upperLeft.Y + 2 * width * third), width * third);
            }
            else
            {
                return;
            }
        }
    }
}
