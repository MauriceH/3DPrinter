using System;
using System.Drawing;
using System.Linq;
using _3DPrinter.Simulation.DeltaPrinterView.Data;
using _3DPrinter.Simulation.Helper;

namespace _3DPrinter.Simulation.DeltaPrinterView.PrinterParts
{
    public class PrintHeadView : IRenderView
    {
        
        public void Render(ViewData viewData, Graphics g)
        {
            var headData = viewData.PrintHead;
            var ws = viewData.DrawSettings;
            DrawHeadPlate(ws, g, headData);
            DrawHeater(ws, headData, g);
            DrawHeadConnectors(viewData, g);
        }



        private void DrawHeadPlate(DrawingSettings ws, Graphics g, PrintHeadViewData headData)
        {
            var headPlateCorners = headData.PlateCorners.Concat(new []{headData.PlateCorners.First()}).ToArray();
            g.FillPolygon(ws.PrintHeadPlateBrush,headPlateCorners);
            g.DrawLines(ws.StrokePenSmall, headPlateCorners);

        }

        private void DrawHeadConnectors(ViewData viewData, Graphics g)
        {
            var connectorBrush = new SolidBrush(viewData.DrawSettings.HeadAxisConnector);

            Action<Point> drawConnector = (x) =>
            {
                var rect = x.CreateRectAround(2);
                g.FillEllipse(connectorBrush, rect);
                g.DrawEllipse(viewData.DrawSettings.StrokePenSmall, rect);
            };

            var headData = viewData.PrintHead;
            drawConnector(headData.A.PointA);
            drawConnector(headData.A.PointB);
            drawConnector(headData.B.PointA);
            drawConnector(headData.B.PointB);
            drawConnector(headData.C.PointA);
            drawConnector(headData.C.PointB);


        }

        private void DrawHeater(DrawingSettings ws, PrintHeadViewData headData, Graphics g)
        {
            var pointRec = headData.CurrentPosition.CreateRectAround(4);
            g.FillEllipse(ws.CoilCoolerBrush, pointRec.Resize(4));
            g.DrawEllipse(ws.StrokePenSmall, pointRec.Resize(4));
            g.FillEllipse(ws.CoilHeaterBrush, pointRec);
        }
    }
}