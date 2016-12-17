using System.Drawing;
using DeltaPrinter.Simulation.Helper;

namespace DeltaPrinter.Simulation.DeltaPrinterView.Data
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