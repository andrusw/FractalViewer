using System;
//using System.Collections.Generic;
//using System.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace FractalViewer
{
    class NewtonsMethod
    {
        private Graphics g;
        private const int MAX_COLORS = 9;
        private Color[] ComplexColors = new Color[MAX_COLORS];
        private const float epsilon = 0.01F;
        private const float a1 = -7.0F;
        //private const float b1 = -7.0F;
        private const float length = 10.0F;
        private const int maxiter = 40;
        private const float a2 = 3.0F;//a1 + length;
        //private const float b2 = 3.0F;//b1 + length;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="g">Contol's Graphic</param>
        /// <param name="ComplexColors">Color Array of size 9</param>
        public NewtonsMethod(Graphics g, Color[] ComplexColors)
        {
            this.g = g;
            this.ComplexColors = ComplexColors;
        }

        /// <summary>
        /// Draws the newton's method
        /// </summary>
        /// <param name="width">width of the drawing surface</param>
        /// <param name="height">height of the drawing surface</param>
        public void draw(int width, int height)
        {
            float size = (length / width); //length / width

            /*
             * Create brush/pens
             */
            Brush[] brushes = new Brush[MAX_COLORS];
            Pen[] pens = new Pen[MAX_COLORS];
            Parallel.For(0, MAX_COLORS, delegate(int i)
            {
                brushes[i] = new SolidBrush(ComplexColors[i]);
                pens[i] = new Pen(brushes[i], 2.0F);
            });

            //adjust to fit screen
            FractalViewer.ViewPoint viewpoint = new ViewPoint(7, width, height);

            for (float x0 = a1; x0 < a2; x0 = x0 + size)
            {
                for (float y0 = a1; y0 < a2; y0 = y0 + size)
                {
                    float x = x0;
                    float y = y0;
                    int i = 0;

                    while (i < maxiter)
                    {
                        float z = x * x * x * x + y * y * y * y + 2 * x * x * y * y;
                        if (z > 10000)
                        {
                            g.DrawLine(pens[0], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                            break;
                        }
                        float x1 = (2 * x + (x * x - y * y) / z) * 0.33333F;
                        float y1 = (2 * y - 2 * x * y / z) * 0.33333F;
                        if (Math.Abs(x - x1) < epsilon && Math.Abs(y - y1) < epsilon)
                        {
                            if (x1 > 1)
                            {
                                g.DrawLine(pens[1], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                                break;
                            }
                            else if (x1 > 0)
                            {
                                g.DrawLine(pens[2], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                                break;
                            }
                            else if (y1 > 0)
                            {
                                g.DrawLine(pens[3], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                                break;
                            }
                            else // y1 <= 0
                            {
                                g.DrawLine(pens[4], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                                break;
                            }
                        }
                        x = x1;
                        y = y1;
                        i = i + 1;

                        if (i == maxiter) //escapes to infinity?
                        {
                            g.DrawLine(pens[0], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                            break;
                        }
                    }
                }
            }

            //Clean up
            Parallel.For(0, MAX_COLORS, delegate(int i)
            {
                pens[i].Dispose();
                brushes[i].Dispose();
            });
        }
    }
}
