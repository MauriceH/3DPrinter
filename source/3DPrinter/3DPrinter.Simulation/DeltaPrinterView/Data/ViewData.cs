using System.Drawing;

namespace _3DPrinter.Simulation.DeltaPrinterView.Data
{
    public class ViewData
    {
        public DrawingSettings DrawSettings { get; set; }
        public Rectangle PrintArea { get; set; }
        public Point Midpoint { get; set; }

        public PrintHeadViewData PrintHead { get; set; }
        public PrintBaseViewData PrinterBase { get; set; }
    }
}