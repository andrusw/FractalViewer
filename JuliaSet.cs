using System;
//using System.Collections.Generic;
//using System.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace FractalViewer
{
    class JuliaSet 
    {
        private Graphics g;
        private const int MAX_COLORS = 9;
        private Color[] ComplexColors = new Color[MAX_COLORS];
        private const float a1 = -1.5F;
        private const float b1 = -1.5F;
        private const float length = 10.0F;
        private const float a2 = 1.5F;//a1 + length;
        private const float b2 = 1.5F;//b1 + length;
        private const int maxiter = 1000;

        public JuliaSet(Graphics g, Color[] ComplexColors)
        {
            this.g = g;
            this.ComplexColors = ComplexColors;
        }

        public void draw(int width, int height, float real, float complex) 
        {
            Brush[] brushes = new Brush[MAX_COLORS];
            Pen[] pens = new Pen[MAX_COLORS];

            Parallel.For(0, MAX_COLORS, delegate(int i)
            {
                brushes[i] = new SolidBrush(ComplexColors[i]);
                pens[i] = new Pen(brushes[i], 2.0F);
            });

            float c1 = real;
            float c2 = complex;
            float size = (length / width);

            for (float x0 = a1; x0 < a2; x0 = x0 + size)
            {
                for (float y0 = b1; y0 < b2; y0 = y0 + size)
                {
                    float x = x0;
                    float y = y0;
                    int i = 0;

                    while (i < maxiter)
                    {
                        float r = x * x + y * y;
                        if (r > 4)
                        {
                            break;
                        }
                        float t = x * x - y * y + c1;
                        y = 2 * x * y + c2;
                        x = t;
                        i++;
                    }
                    FractalViewer.ViewPoint viewpoint = new ViewPoint(5,width, height);

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

            Parallel.For(0, MAX_COLORS, delegate(int i)
            {
                pens[i].Dispose();
                brushes[i].Dispose();
            });
        }
    }
}
