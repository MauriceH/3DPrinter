using System.Drawing;

namespace DeltaPrinter.Simulation.Helper
{
    public static class PointExtensions
    {
        public static Rectangle CreateRectAround(this Point point, int size)
        {
            return new Rectangle(point.X-size,point.Y-size,(size*2)+1,(size*2)+1);
        }

        public static Point MoveOffset(this Point pnt, Point pointOffset)
        {
            return pnt.MoveOffset(pointOffset.X, pointOffset.Y);
        }

        public static Point MoveOffset(this Point pnt, int x, int y)
        {
            return new Point(pnt.X + x, pnt.Y + y);
        }

        public static Point FlipX(this Point pnt)
        {
            return new Point(pnt.X * -1, pnt.Y);
        }

        public static Point FlipY(this Point pnt)
        {
            return new Point(pnt.X, pnt.Y * -1);
        }
    }
}