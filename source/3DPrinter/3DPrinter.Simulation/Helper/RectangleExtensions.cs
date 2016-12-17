using System.Drawing;

namespace DeltaPrinter.Simulation.Helper
{
    public static class RectangleExtensions
    {

        public static Point GetMidpoint(this Rectangle rect)
        {
            return new Point((int) (rect.X + rect.Width * 0.5), (int) (rect.Y + rect.Height * 0.5));
        }

        public static Rectangle Resize(this Rectangle rect, int changeSize)
        {
            return rect.Resize(-changeSize,-changeSize,changeSize,changeSize);
        }

        public static Rectangle Resize(this Rectangle rect, int changeX, int changeY, int changeRight, int changeBottom)
        {
            return new Rectangle(rect.X + changeX, 
                rect.Y + changeY, 
                rect.Width + (changeRight * 2), 
                rect.Height + (changeBottom * 2));
        }

    }
}