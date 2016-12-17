using System.Drawing;

namespace DeltaPrinter.Simulation.DeltaPrinterView.Data
{
    public class ViewData
    {
        public AppearanceSettings DrawSettings { get; set; }
        public Rectangle PrintArea { get; set; }
        public Point Midpoint { get; set; }

        public PrintHeadViewData PrintHead { get; set; }
        public PrintBaseViewData PrinterBase { get; set; }
    }
}