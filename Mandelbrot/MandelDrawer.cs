using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System;
using System.Drawing.Imaging;

namespace Mandelbrot
{
    class MandelDrawer
    {
        double lb, rb, tb, bb; // leftbound rightbound topbound bottombound
        UserInterface ui;
        MandelNumber mandelNumber;

        public MandelDrawer(double centerX, double centerY, double baseValue, UserInterface ui)
        {
            this.ui = ui;
            mandelNumber = new MandelNumber(ui.getMaxNumber(), new ColorPicker(ui.getRedMultiplier(), ui.getGreenMultiplier(), ui.getBlueMultiplier()));
            lb = centerX - baseValue;
            rb = centerX + baseValue;
            tb = centerY + baseValue;
            bb = centerY - baseValue;
        }

        public Bitmap toBitmap()
        {
            Bitmap mandelDrawing = new Bitmap(ui.getPanelWidth(), ui.getPanelHeight());
            for (int pixelRow = 1; pixelRow < ui.getPanelWidth(); pixelRow++)
            {
                for (int pixelColumn = 1; pixelColumn < ui.getPanelHeight(); pixelColumn++)
                {
                    mandelDrawing.SetPixel(pixelRow, pixelColumn, mandelNumber.mandelColor(getXLocation(pixelRow), getYLocation(pixelColumn)));
                }
            }
            return mandelDrawing;
        }

        private double getXLocation(int pixelColumn)
        {
            return lb + (rb - lb) / ui.getPanelWidth() * pixelColumn;
        }

        private double getYLocation(int pixelRow)
        {
            return bb + (tb - bb) / ui.getPanelHeight() * pixelRow;
        }
    }
}
