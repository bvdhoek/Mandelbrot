using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    class Preset
    {
        public string name { get; }
        public int r { get; }
        public int g { get; }
        public int b { get; }
        public int max { get; }
        public double centerX { get; }
        public double centerY { get; }
        public double scale { get; }

        public Preset(string name, int r, int g, int b, int max, double centerX, double centerY, double scale)
        {
            this.name = name;
            this.r = r;
            this.g = g;
            this.b = b;
            this.max = max;
            this.centerX = centerX;
            this.centerY = centerY;
            this.scale = scale;
        }
    }
}
