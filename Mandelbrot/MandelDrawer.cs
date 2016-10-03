using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    class MandelDrawer
    {
        double lb, rb, tb, bb; // leftbound rightbound topbound bottombound

        public MandelDrawer(double lb, double rb, double tb, double bb)
        {
            this.lb = lb;
            this.rb = rb;
            this.tb = tb;
            this.bb = bb;
        }

        public Bitmap list()
        {
            return null;
        }

        private double getXLocation(double x, double y)
        {
            return (rb - lb) / x + lb;
        }

        private double getYLocation(double x, double y)
        {
            return (tb - bb) / y + bb;
        }
    }
}
