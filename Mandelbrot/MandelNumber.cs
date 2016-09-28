using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    class MandelNumber
    {
        double beginX, beginY;

        public int CalculateMandelNumber(double a, double b)
        {
            beginX = a;
            beginY = b;
            return CalculateNumber(beginX, beginY);
        }

        private int CalculateNumber(double a, double b, int mandelnumber = 1)
        {
            if (DistanceToOrigin(a, b) >= 2 || mandelnumber >= 100)
                return mandelnumber;
            return CalculateNumber(Math.Pow(a, 2) - Math.Pow(b, 2) + beginX, 2 * a * b + beginY, mandelnumber + 1); 
        }

        private double DistanceToOrigin(double x, double y)
        {
            return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
    }
}
