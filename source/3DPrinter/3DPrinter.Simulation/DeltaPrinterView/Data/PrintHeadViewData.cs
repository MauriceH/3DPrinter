using System.Drawing;
using System.Linq;
using _3DPrinter.Simulation.Helper;

namespace _3DPrinter.Simulation.DeltaPrinterView.Data
{
    public class PrintHeadViewData
    {

        private readonly DeltaHeadConnector a;
        private readonly DeltaHeadConnector b;
        private readonly DeltaHeadConnector c;
        private readonly Point[] plateCorners;

        public Point CurrentPosition { get; set; }

        public DeltaHeadConnector A => a.Offset(CurrentPosition);
        public DeltaHeadConnector B => b.Offset(CurrentPosition);
        public DeltaHeadConnector C => c.Offset(CurrentPosition);

        public Point[] PlateCorners => plateCorners.Select((x) => x.MoveOffset(CurrentPosition)).ToArray();
        

        public PrintHeadViewData(PrinterConfig config)
        {
            var headPlate = new HexaPolygon(config.PrintHeadCornerRadius,config.PrintHeadCornerDistance);
            plateCorners = headPlate.Points;

            var connectors = new HexaPolygon(config.AxisConnectPointRadius, config.AxisConnectPointDistance);
            
            a = new DeltaHeadConnector()
            {
                PointA = connectors.Points[0],
                PointB = connectors.Points[1]
            };
            b = new DeltaHeadConnector()
            {
                PointA = connectors.Points[2],
                PointB = connectors.Points[3]
            };
            c = new DeltaHeadConnector()
            {
                PointA = connectors.Points[4],
                PointB = connectors.Points[5]
            };
        }      
    }
}