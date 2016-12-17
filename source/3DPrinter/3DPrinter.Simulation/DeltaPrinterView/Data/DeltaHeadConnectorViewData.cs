using System.Drawing;
using _3DPrinter.Simulation.Helper;

namespace _3DPrinter.Simulation.DeltaPrinterView.Data
{
    public class DeltaHeadConnector
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }

        public DeltaHeadConnector Offset(Point currentPosition)
        {
            return new DeltaHeadConnector()
            {
                PointA = this.PointA.MoveOffset(currentPosition),
                PointB = this.PointB.MoveOffset(currentPosition),
            };
        }
    }
}