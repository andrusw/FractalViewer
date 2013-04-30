using System;
//using System.Collections.Generic;
//using System.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace FractalViewer
{
    class Mandelbrot
    {
        private const int MAX_COLORS = 9;
        private Graphics g;
        private Color [] ComplexColor = new Color[MAX_COLORS];
        private const float a1 = -4;
        private const float b1 = -5;
        private const float length = 10;
        private const float maxiter = 1000;
        private const float a2 = 6F; //(float)(a1 + length);
        private const float b2 = 5F;//(float)(b1 + length);


        public Mandelbrot(Graphics g, Color[] ComplexColor)
        {
            this.g = g;
            this.ComplexColor = ComplexColor;
        }

        public void draw(int width, int height)
        {
            /*
             * Get color arrays and make pens
             */
            Pen[] pens = new Pen[MAX_COLORS];
            Parallel.For(0, MAX_COLORS, delegate(int colorCount)
            {
                pens[colorCount] = new Pen(new SolidBrush(ComplexColor[colorCount]), 2.0F);
            });

            float size = (float)(length / width);
            FractalViewer.ViewPoint viewpoint = new ViewPoint(4, width, height);

            for (float x0 = a1; x0 < a2; x0 = x0 + size)
            {
                for (float y0 = b1; y0 < b2; y0 = y0 + size)
                {
                    float x = 0;
                    float y = 0;
                    int i = 0;
                    while (i < maxiter)
                    {
                        float r = (x * x + y * y);
                        if (r > 4)
                        {
                            //exit while loop
                            break;
                        }
                        float t = (x * x - y * y + x0);
                        y = (2.0F * x * y + y0);
                        x = t;
                        i++;
                    }                  

                    /*
                     * draw results
                     */
                    if (i == maxiter) //escapes to infinity
                    {
                        g.DrawLine(pens[0], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else if (i >= 76)
                    {
                        g.DrawLine(pens[1], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else if (i >= 46)
                    {
                        g.DrawLine(pens[2], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else if (i >= 26) //(change >> 1))// 1/2
                    {
                        g.DrawLine(pens[3], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else if (i >= 16) //(change * 0.3333)) // 1/3
                    {
                        g.DrawLine(pens[4], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else if (i >= 10)//(change >> 2))// 1/4
                    {
                        g.DrawLine(pens[5], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else if (i >= 6) //(change * 0.2)) //1/5
                    {
                        g.DrawLine(pens[6], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else if (i >= 4) //(change * 0.1666)) //1/6
                    {
                        g.DrawLine(pens[7], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else if (i >= 2) //change * 0.05) //1/20
                    {
                        g.DrawLine(pens[8], viewpoint.X(x0), viewpoint.Y(y0), viewpoint.X(x0 + 1), viewpoint.Y(y0 + 1));
                    }
                    else
                    {
                        //leave white
                    }
                }
            }

            Parallel.For(0, MAX_COLORS, delegate(int colorCount)
            {
                pens[colorCount].Dispose();
            });
        }
    }
}
