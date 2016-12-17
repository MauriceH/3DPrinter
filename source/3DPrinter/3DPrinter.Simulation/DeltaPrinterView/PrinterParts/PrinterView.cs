using System;
using System.Drawing;
using System.Linq;
using DeltaPrinter.Simulation.DeltaPrinterView.Data;
using DeltaPrinter.Simulation.Helper;

namespace DeltaPrinter.Simulation.DeltaPrinterView.PrinterParts
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



        private void DrawGroundPlate(AppearanceSettings ws, Graphics g, PrintBaseViewData baseData)
        {
            var entries = baseData.GroundPlateCorners.Concat(new[] {baseData.GroundPlateCorners.First()}).ToArray();
            g.DrawLines(ws.StrokeBig.Pen, entries);
            g.FillPolygon(ws.GroundPlateBrush, entries);
        }

        private void DrawHeatPlate(AppearanceSettings ws, Graphics g, PrintBaseViewData baseData) 
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
                g.DrawEllipse(viewData.DrawSettings.StrokeSmall.Pen, rect);
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
            var dsConnectorBigPen = ds.ConnectorBigPen.Pen;
            g.DrawLine(dsConnectorBigPen, data.PrinterBase.A.PointA, data.PrintHead.A.PointA);           
            g.DrawLine(dsConnectorBigPen, data.PrinterBase.A.PointB, data.PrintHead.A.PointB);
            g.DrawLine(dsConnectorBigPen, data.PrinterBase.B.PointA, data.PrintHead.B.PointA);           
            g.DrawLine(dsConnectorBigPen, data.PrinterBase.B.PointB, data.PrintHead.B.PointB);
            g.DrawLine(dsConnectorBigPen, data.PrinterBase.C.PointA, data.PrintHead.C.PointA);           
            g.DrawLine(dsConnectorBigPen, data.PrinterBase.C.PointB, data.PrintHead.C.PointB);           
        }

    }
}