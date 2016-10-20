using System;

namespace Mandelbrot
{
     class Coordinates
    {
        private UserInterface userInterface;
        private double leftBound, bottomBound, size;

        public Coordinates(double centerX, double centerY, double scale, UserInterface userInterface)
        {
            leftBound = centerX - scale;
            bottomBound = centerY - scale;
            size = 2 * scale;
            this.userInterface = userInterface;
        }

        /*
         * x is the pixel of which you want to know the coordinate (relative to the panel)
         * size * x / panelWidth is the offset
         * leftBound + offset = x coordinate
        */
        public double GetXLocation(double x)
        {
            double offset = size * x / userInterface.GetPanelWidth();
            return leftBound + offset;
        }

        /*
         * y is the pixel of which you want to know the coordinate (relative to the panel)
         * size * y / panelHeight is the offset
         * bottomBount + offset = y coordinate
        */
        public double GetYLocation(double y)
        {
            double offset = size * y / userInterface.GetPanelHeight();
            return bottomBound + offset;
        }
    }
}