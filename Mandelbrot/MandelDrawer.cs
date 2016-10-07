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
        /* 
         * Reserve memory the size of the bitmap and write the pixelcolours directly into the memory.
         * This makes the method run faster because it doesn't need to reserve memory separately for
         * every pixel that needs to be drawn.
         */
        public unsafe Bitmap toBitmap()
        {
            Bitmap mandelDrawing = new Bitmap(ui.getPanelWidth(), ui.getPanelHeight());

            Rectangle rect = new Rectangle(0, 0, mandelDrawing.Width, mandelDrawing.Height);
            // Lock the bits
            BitmapData mandelDrawingData =
                mandelDrawing.LockBits(rect, ImageLockMode.WriteOnly,
                PixelFormat.Format32bppPArgb); 

            // Get the address of the first line.
            uint* ptr = (uint*)mandelDrawingData.Scan0;

            for (int pixelColumn = 1; pixelColumn < ui.getPanelHeight(); pixelColumn++)
            {
                uint* line = ptr;

                for (int pixelRow = 1; pixelRow < ui.getPanelWidth(); pixelRow++)
                {
                    *line++ = (uint)mandelNumber.mandelColor(getXLocation(pixelRow), getYLocation(pixelColumn)).ToArgb();
                }
                // Set pointer to next line
                ptr += mandelDrawingData.Stride / 4;
            }

            // Unlock the bits.
            mandelDrawing.UnlockBits(mandelDrawingData);

            return mandelDrawing;
        }

        private double getXLocation(int pixelColumn) // Converts x location in pixels to coordinates
        {
            return lb + (rb - lb) / ui.getPanelWidth() * pixelColumn;
        }

        private double getYLocation(int pixelRow) // Converts y location in pixels to coordinates
        {
            return bb + (tb - bb) / ui.getPanelHeight() * pixelRow;
        }
    }
}
