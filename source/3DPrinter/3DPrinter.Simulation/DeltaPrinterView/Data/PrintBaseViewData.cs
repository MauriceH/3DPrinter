using System.Drawing;
using System.Linq;
using DeltaPrinter.Simulation.Helper;

namespace DeltaPrinter.Simulation.DeltaPrinterView.Data
{
    public class PrintBaseViewData
    {

        public DeltaHeadConnector A { get; private set;}
        public DeltaHeadConnector B { get; private set;}
        public DeltaHeadConnector C { get; private set;}

        public Point[] GroundPlateCorners { get; private set; }

        public Rectangle HeatPlate { get; private set; }

        public PrintBaseViewData(PrinterConfig config, Point midPoint)
        {
            var headPlate = new HexaPolygon(config.GroundPlateCornerRadius, config.GroundPlateCornerDistance);
            GroundPlateCorners = headPlate.Points.Select((x)=>x.MoveOffset(midPoint)).ToArray();

            var connectors = new HexaPolygon(config.GroundAxisConnectPointRadius, config.AxisConnectPointDistance);

            A = new DeltaHeadConnector()
            {
                PointA = connectors.Points[0],
                PointB = connectors.Points[1]
            }.Offset(midPoint);
            B = new DeltaHeadConnector()
            {
                PointA = connectors.Points[2],
                PointB = connectors.Points[3]
            }.Offset(midPoint);
            C = new DeltaHeadConnector()
            {
                PointA = connectors.Points[4],
                PointB = connectors.Points[5]
            }.Offset(midPoint);

            HeatPlate = midPoint.CreateRectAround(config.HeatPlateRadius);
        }

    }
}