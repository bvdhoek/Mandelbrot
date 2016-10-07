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

        public Color MandelColor(double a, double b)
        {
            return colorPicker.GetColorByMandelnumber(CalculateMandelNumber(a, b));
        }

        private int CalculateMandelNumber(double a, double b)
        {
            x = a;
            y = b;
            return CalculateNumber(x, y);
        }

        private int CalculateNumber(double a, double b, int mandelnumber = 1)
        {
            if (Distance(a, b) >= 4 || mandelnumber >= maxNumber)
                return mandelnumber;
            return CalculateNumber(a*a - b*b + x, 2 * a * b + y, mandelnumber + 1);
        }

        public double Distance(double x, double y)
        {
            return x * x + y * y;
        }

    }
}
