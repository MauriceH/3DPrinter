using System;
using System.Drawing;
using System.Linq;
using _3DPrinter.Simulation.DeltaPrinterView.Data;
using _3DPrinter.Simulation.Helper;

namespace _3DPrinter.Simulation.DeltaPrinterView.PrinterParts
{
    public class PrinterView : IRenderView
    {
        private readonly Rectangle printRect;
        private readonly PrintHeadView printHeadView;

        public PrinterView(Rectangle printRect)
        {
            this.printRect = printRect;
            printHeadView = new PrintHeadView();
        }

        public void Render(ViewData viewData, Graphics g)
        {
            var ws = viewData.DrawSettings;
            DrawGroundPlate(ws,g,viewData.PrinterBase);
            DrawHeatPlate(ws, g, viewData.PrinterBase);
            printHeadView.Render(viewData, g);
            DrawConnections(viewData, g);
            DrawHeadConnectors(viewData , g);
        }



        private void DrawGroundPlate(DrawingSettings ws, Graphics g, PrintBaseViewData baseData)
        {
            var entries = baseData.GroundPlateCorners.Concat(new[] {baseData.GroundPlateCorners.First()}).ToArray();
            g.DrawLines(ws.StrokePenBig, entries);
            g.FillPolygon(ws.GroundPlateBrush, entries);
        }

        private void DrawHeatPlate(DrawingSettings ws, Graphics g, PrintBaseViewData baseData) 
        {
            g.FillEllipse(ws.HeatPlateBrush,baseData.HeatPlate);
            g.DrawEllipse(new Pen(((SolidBrush)ws.HeatPlateBrush).Color,4), baseData.HeatPlate);
        }

        private void DrawHeadConnectors(ViewData viewData, Graphics g)
        {
            var connectorBrush = new SolidBrush(viewData.DrawSettings.HeadAxisConnector);

            Action<Point> drawConnector = (x) =>
            {
                var rect = x.CreateRectAround(4);
                g.FillEllipse(connectorBrush, rect);
                g.DrawEllipse(viewData.DrawSettings.StrokePenSmall, rect);
            };

            var baseData = viewData.PrinterBase;
            drawConnector(baseData.A.PointA);
            drawConnector(baseData.A.PointB);
            drawConnector(baseData.B.PointA);
            drawConnector(baseData.B.PointB);
            drawConnector(baseData.C.PointA);
            drawConnector(baseData.C.PointB);


        }

        private void DrawConnections(ViewData data, Graphics g)
        {
            var ds = data.DrawSettings;
            g.DrawLine(ds.ConnectorBigPen, data.PrinterBase.A.PointA, data.PrintHead.A.PointA);           
            g.DrawLine(ds.ConnectorBigPen, data.PrinterBase.A.PointB, data.PrintHead.A.PointB);
            g.DrawLine(ds.ConnectorBigPen, data.PrinterBase.B.PointA, data.PrintHead.B.PointA);           
            g.DrawLine(ds.ConnectorBigPen, data.PrinterBase.B.PointB, data.PrintHead.B.PointB);
            g.DrawLine(ds.ConnectorBigPen, data.PrinterBase.C.PointA, data.PrintHead.C.PointA);           
            g.DrawLine(ds.ConnectorBigPen, data.PrinterBase.C.PointB, data.PrintHead.C.PointB);           
        }

    }
}