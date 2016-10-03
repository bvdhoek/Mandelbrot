using System;
using System.Drawing;

namespace Mandelbrot
{
    class MandelNumber
    {
        double x, y;
        int maxNumber, mandelNumber;
        Color color;

        public MandelNumber(double a, double b)
        {
            mandelNumber = CalculateMandelNumber(a, b);
            color = mandelColor();
        }

        public Color getColor()
        {
            return color;
        }

        public int getNumber()
        {
            return mandelNumber;
        }

        private Color mandelColor()
        {
            if (mandelNumber % 2 == 0)
                return Color.Black;
            return Color.White;
        }

        private int CalculateMandelNumber(double a, double b, int maxNumber = 100)
        {
            this.maxNumber = maxNumber;
            x = a;
            y = b;
            return CalculateNumber(x, y);
        }

        public void setMaxNumber(int maxNumber)
        {
            this.maxNumber = maxNumber;
        }

        private int CalculateNumber(double a, double b, int mandelnumber = 1)
        {
            if (DistanceToOrigin(a, b) >= 2 || mandelnumber >= maxNumber)
                return mandelnumber;
            return CalculateNumber(Math.Pow(a, 2) - Math.Pow(b, 2) + x, 2 * a * b + y, mandelnumber + 1);
        }

        private double DistanceToOrigin(double x, double y)
        {
            return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
    }
}
