using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Drawing;

namespace FractalViewer
{
    class ViewPoint
    {
        private int type;
        private int width;
        private int height;


        public ViewPoint(int type, int width, int height)
        {
            this.type = type;
            this.width = width;
            this.height = height;
        }

        public float Y(float y)
        {
            float result = 0f;
            float shift;
            float stretch;

            switch (type)
            {
                case 3:
                    shift = 0.7F;
                    stretch = 5.0F;
                    result =  (float)((height - (y * (height / stretch))) * shift);
                    break;
                case 5:
                    shift = (float)(-0.49 * height);
                    stretch = 0.4F;
                    result = (float)((height - (y * (height * stretch))) + shift);
                    break;
                case 4:
                    shift = (float)(-0.5 * height);
                    stretch = 0.4F;
                    result = (float)((height - (y * (height * stretch))) + shift);
                    break;
                case 7:
                    shift = (float)(-0.5 * height);
                    stretch = 0.3F;
                    result =  (float)((height - (y * (height * stretch))) + shift);
                    break;
                default:
                    break;
            }
            return result;
        }

        public float X(float x)
        {
            float result = 0f;
            float shift;
            float stretch;

            switch (type)
            {
                case 3:
                    shift = (width >> 1);
                    result =  (float)(((width * 0.2F) * x) + shift);
                    break;
                case 4:
                    shift = (0.60F * width);
                    stretch = 0.3F;
                    result = (float)(((width * stretch) * x) + shift);
                    break;
                case 5:
                    shift = (0.45F * width);
                    stretch = 0.3F;
                    result = (float)(((width * stretch) * x) + shift);
                    break;
                case 7:
                    shift = (0.70F * width);
                    stretch = 0.1F;
                    result = (float)(((width * stretch) * x) + shift);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
