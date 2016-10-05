using System;
using System.Collections.Generic;
using System.Drawing;

namespace Mandelbrot
{
    class MandelNumber
    {
        private double x, y;
        private int maxNumber;
        private ColorPicker colorPicker;

        public MandelNumber(int max, ColorPicker colorPicker)
        {
            this.colorPicker = colorPicker;
            maxNumber = max;
        }

        public Color mandelColor(double a, double b)
        {
            return colorPicker.getColorByMandelnumber(CalculateMandelNumber(a, b));
        }

        private int CalculateMandelNumber(double a, double b)
        {
            x = a;
            y = b;
            return CalculateNumber(x, y);
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
