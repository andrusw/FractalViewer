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
        private const float third = 0.33333F;

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
            using(Brush backgroundBrush = new SolidBrush(backgroundColor))
            {

                //Shift the upperLeft point to make room for tool strip at top
                PointF upperLeft = new PointF((iwidth) * 0.04F, (iheight) * 0.04F);
                //Shift height to fit inside.
                float width = (iheight * 0.95F);
                float thirdWidth = third * width;
                float twoThirdWidth = 2 * thirdWidth;

                using (Brush colorBrush = new SolidBrush(mainColor))
                {
                    //draw main block
                    g.FillRectangle(colorBrush, upperLeft.X, upperLeft.Y, width, width);
                }

                //sub divide the block by clearing top-middle, right-middle, bottom-middle, and left-middle.
                PointF top = new PointF(upperLeft.X + thirdWidth, upperLeft.Y);
                g.FillRectangle(backgroundBrush, top.X, top.Y, thirdWidth, thirdWidth);

                PointF left = new PointF(upperLeft.X, upperLeft.Y + thirdWidth);
                g.FillRectangle(backgroundBrush, left.X, left.Y, thirdWidth, thirdWidth);

                PointF right = new PointF(upperLeft.X + twoThirdWidth, upperLeft.Y + thirdWidth);
                g.FillRectangle(backgroundBrush, right.X, right.Y, thirdWidth, thirdWidth);

                PointF bottom = new PointF(upperLeft.X + thirdWidth, upperLeft.Y + twoThirdWidth);
                g.FillRectangle(backgroundBrush, bottom.X, bottom.Y, thirdWidth, thirdWidth);

                DrawBox(backgroundBrush, upperLeft, thirdWidth);
                DrawBox(backgroundBrush,new PointF(upperLeft.X + twoThirdWidth, upperLeft.Y), thirdWidth);
                DrawBox(backgroundBrush, new PointF(upperLeft.X + thirdWidth, upperLeft.Y + thirdWidth), thirdWidth);
                DrawBox(backgroundBrush, new PointF(upperLeft.X, upperLeft.Y + twoThirdWidth), thirdWidth);
                DrawBox(backgroundBrush, new PointF(upperLeft.X + twoThirdWidth, upperLeft.Y + twoThirdWidth), thirdWidth);
            }
        }

        /// <summary>
        /// Recursive function to remove parts of the square block.  
        /// </summary>
        /// <param name="upperLeft">The upper left of the block. </param>
        /// <param name="width">Represents the length. </param>
        private void DrawBox(Brush backgroundBrush, PointF upperLeft, float width)
        {
            float thirdWidth = width * third;
            float twoThirdWidth = 2 * thirdWidth;

            if (thirdWidth > this.precision)
            {
                    //Remove 4 more blocks
                    PointF top = new PointF(upperLeft.X + thirdWidth, upperLeft.Y);
                    this.g.FillRectangle(backgroundBrush, top.X, top.Y, thirdWidth, thirdWidth);

                    PointF left = new PointF(upperLeft.X, upperLeft.Y + thirdWidth);
                    this.g.FillRectangle(backgroundBrush, left.X, left.Y, thirdWidth, thirdWidth);

                    PointF right = new PointF(upperLeft.X + twoThirdWidth, upperLeft.Y + thirdWidth);
                    this.g.FillRectangle(backgroundBrush, right.X, right.Y, thirdWidth, thirdWidth);

                    PointF bottom = new PointF(upperLeft.X + thirdWidth, upperLeft.Y + twoThirdWidth);
                    this.g.FillRectangle(backgroundBrush, bottom.X, bottom.Y, thirdWidth, thirdWidth);

                    //Recursive into the 5 remaining.
                    DrawBox(backgroundBrush,upperLeft, thirdWidth);
                    DrawBox(backgroundBrush, new PointF(upperLeft.X + twoThirdWidth, upperLeft.Y), thirdWidth);
                    DrawBox(backgroundBrush, new PointF(upperLeft.X + thirdWidth, upperLeft.Y + thirdWidth), thirdWidth);
                    DrawBox(backgroundBrush, new PointF(upperLeft.X, upperLeft.Y + twoThirdWidth), thirdWidth);
                    DrawBox(backgroundBrush, new PointF(upperLeft.X + twoThirdWidth, upperLeft.Y + twoThirdWidth), thirdWidth);
            }
            else
            {
                return;
            }
        }
    }
}
