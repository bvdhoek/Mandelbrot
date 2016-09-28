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
        Point location;

        public MandelNumber(Point p)
        {
            location = p;
        }

        private int CalculateMandelNumber(double a, double b, int mandelnumber = 1)
        {
            if (DistanceToOrigin(a, b) >= 2)
                return mandelnumber;
            return CalculateMandelNumber(Math.Pow(a, 2) - Math.Pow(b, 2) + location.X, 2 * a * b + location.Y, mandelnumber + 1); 
        }

        private double DistanceToOrigin(double x, double y)
        {
            return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
    }
}
