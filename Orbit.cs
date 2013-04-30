using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace FractalViewer
{
    class Orbit
    {
        private Graphics g;
        private Color orbitColor;
        #region Properties
        public float Seed {get; set;}
        public int DisplayCount{ get; set;}
        #endregion

        /// <summary>
        /// Constructor for Orbit
        /// </summary>
        /// <param name="g">Graphic of the Control</param>
        /// <param name="orbitColor">Color to draw orbit paths</param>
        /// <param name="seed">Starting point on the y=x</param>
        /// <param name="displayCount">How many lines to draw</param>
        public Orbit(Graphics g, Color orbitColor, float seed, int displayCount)
        {
            this.g = g;
            this.orbitColor = orbitColor;
            this.Seed = seed;
            this.DisplayCount = displayCount;
        }

        /// <summary>
        /// Draw given control
        /// </summary>
        /// <param name="width">width of control</param>
        /// <param name="height">height of control</param>
        public void Draw(int width, int height)
        {
            //Resize and shift to fit.
            FractalViewer.ViewPoint viewPoint = new ViewPoint(3, width, height);

            using(Brush blackBrush = new SolidBrush(Color.Black))
            using (Pen blackPen = new Pen(blackBrush, 1F))
            {
                int Points = 2000;
                PointF[] parabola = new PointF[Points];

                /*
                 * Draw parabola and x=y line
                 */
                //Get points of parabola
                Parallel.For(0, Points, delegate(int x)
                {
                    parabola[x] = new PointF(viewPoint.X((float)(-3 + (x * .005))), viewPoint.Y((float)((-3 + (x * .005)) * (-3 + (x * .005)) - 2)));
                });

                //draw parabola
                g.DrawLines(blackPen, parabola);

                //Draw grid
                g.DrawLine(blackPen, viewPoint.X(-3), viewPoint.Y(-3), viewPoint.X(3), viewPoint.Y(3));//Draws diagonal
                g.DrawLine(blackPen, viewPoint.X(0), viewPoint.Y(-3), viewPoint.X(0), viewPoint.Y(5)); //Draws vertical
                g.DrawLine(blackPen, viewPoint.X(-3), viewPoint.Y(0), viewPoint.X(3), viewPoint.Y(0)); //Draws horizontal

            }

            /*
             * Draw orbit paths
             */
            using(Brush orbitBrush = new SolidBrush(orbitColor))
            using (Pen orbitPen = new Pen(orbitBrush, 1F))
            {
                float y;
                for (int i = 0; i < DisplayCount; i++)
                {
                    y = Seed * Seed - 2;
                    g.DrawLine(orbitPen, viewPoint.X(Seed), viewPoint.Y(Seed), viewPoint.X(Seed), viewPoint.Y(y));
                    g.DrawLine(orbitPen, viewPoint.X(Seed), viewPoint.Y(y), viewPoint.X(y), viewPoint.Y(y));
                    Seed = y;
                }
            }
        }
    }
}
