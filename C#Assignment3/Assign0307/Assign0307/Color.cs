using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign0307
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public int getRed()
        {
            return red;
        }
        public int getGreen()
        {
            return green;
        }
        public int getBlue()
        {
            return blue;
        }

        public int getAlpha()
        {
            return alpha;
        }

        public void setRed(int red)
        {
            this.red = red;
        }
        public void setGreen(int green)
        {
            this.green = green;
        }
        public void setBlue(int blue)
        {
            this.blue = blue;
        }

        public void setAlpha(int alpha)
        {
            this.alpha = alpha;
        }

        public double getGrayScaleValue()
        {
            return ((red + green + blue) * 1.0) / 3;
        }
    }
}
