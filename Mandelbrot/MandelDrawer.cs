using System.Drawing;
using System.Drawing.Imaging;

namespace Mandelbrot
{
    class MandelDrawer
    {
        UserInterface ui;
        MandelNumber mandelNumber;
        Coordinates coordinates;

        public MandelDrawer(Coordinates coordinates, UserInterface ui)
        {
            this.coordinates = coordinates;
            this.ui = ui;
            mandelNumber = new MandelNumber(ui.GetMaxNumber(), new ColorPicker(ui.GetRedMultiplier(), ui.GetGreenMultiplier(), ui.GetBlueMultiplier()));
        }
        /* 
         * Reserve memory the size of the bitmap and write the pixelcolours directly into the memory.
         * This makes the method run faster because it doesn't need to reserve memory separately for
         * every pixel that needs to be drawn.
         */
        public unsafe Bitmap toBitmap()
        {
            Bitmap mandelDrawing = new Bitmap(ui.GetPanelWidth(), ui.GetPanelHeight());

            Rectangle rect = new Rectangle(0, 0, mandelDrawing.Width, mandelDrawing.Height);
            // Lock the bits
            BitmapData mandelDrawingData =
                mandelDrawing.LockBits(rect, ImageLockMode.WriteOnly,
                PixelFormat.Format32bppPArgb); 

            // Get the address of the first line.
            uint* ptr = (uint*) mandelDrawingData.Scan0;

            for (int pixelColumn = 1; pixelColumn < ui.GetPanelHeight(); pixelColumn++)
            {
                uint* line = ptr;

                for (int pixelRow = 1; pixelRow < ui.GetPanelWidth(); pixelRow++)
                {
                    *line++ = (uint) mandelNumber.MandelColor(coordinates.GetXLocation(pixelRow), coordinates.GetYLocation(pixelColumn)).ToArgb();
                }
                // Set pointer to next line
                ptr += mandelDrawingData.Stride / 4;
            }

            // Unlock the bits.
            mandelDrawing.UnlockBits(mandelDrawingData);

            return mandelDrawing;
        }
    }
}
