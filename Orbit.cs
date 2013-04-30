using System;
//using System.Collections.Generic;
//using System.Text;
using System.Drawing;
//using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace FractalViewer
{
    class Orbit
    {
        private float seed = 0.1f;
        private Graphics g;
        private Color orbitColor;
        private int displayCount = 50;

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
            this.seed = seed;
            this.displayCount = displayCount;
        }

        /// <summary>
        /// Seed Property
        /// </summary>
        public float Seed
        {
            get
            {
                return this.seed;
            }
            set
            {
                this.seed = value;
            }
        }

        /// <summary>
        /// Display Count Property
        /// </summary>
        public int DisplayCount
        {
            get
            {
                return this.displayCount;
            }
            set
            {
                this.displayCount = value;
            }

        }

        /// <summary>
        /// Draw given control
        /// </summary>
        /// <param name="width">width of control</param>
        /// <param name="height">height of control</param>
        public void Draw(int width, int height)
        {
            //Graph Color
            Brush blackBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(blackBrush, 1F);

            int Points = 2000;
            PointF[] parabola = new PointF[Points];

            //Resize and shift to fit.
            FractalViewer.ViewPoint viewPoint = new ViewPoint(3, width, height);


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
            g.DrawLine(blackPen, viewPoint.X(-3), viewPoint.Y(-3), viewPoint.X(3), viewPoint.Y(3));//Draws diagaonal
            g.DrawLine(blackPen, viewPoint.X(0), viewPoint.Y(-3), viewPoint.X(0), viewPoint.Y(5)); //Draws vertical
            g.DrawLine(blackPen, viewPoint.X(-3), viewPoint.Y(0), viewPoint.X(3), viewPoint.Y(0)); //Draws horizontal

            blackPen.Dispose();
            blackBrush.Dispose();


            /*
             * Draw orbit paths
             */
            Brush orbitBrush = new SolidBrush(orbitColor);
            Pen orbitPen = new Pen(orbitBrush, 1F);
            
            float y;
            for (int i = 0; i < displayCount; i++)
            {
                y = seed * seed - 2;
                g.DrawLine(orbitPen, viewPoint.X(seed), viewPoint.Y(seed), viewPoint.X(seed), viewPoint.Y(y));
                g.DrawLine(orbitPen, viewPoint.X(seed), viewPoint.Y(y), viewPoint.X(y), viewPoint.Y(y));
                seed = y;
            }

            orbitPen.Dispose();
            orbitBrush.Dispose();

        }
    }
}
