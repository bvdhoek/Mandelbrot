using System.Drawing;

namespace Mandelbrot
{
    class ColorPicker
    {
        int redMultiplier, greenMultiplier, blueMultiplier;

        public ColorPicker(int redMultiplier, int greenMultiplier, int blueMultiplier)
        {
            this.redMultiplier = redMultiplier;
            this.greenMultiplier = greenMultiplier;
            this.blueMultiplier = blueMultiplier;
        }

        public Color getColorByMandelnumber(int mandelnumber)
        {
            return Color.FromArgb(
                (redMultiplier * mandelnumber) % 255,
                (greenMultiplier * mandelnumber) % 255,
                (blueMultiplier * mandelnumber) % 255
            );
        }
    }
}
