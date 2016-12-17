using System.Drawing;
using _3DPrinter.Simulation.DeltaPrinterView.Data;

namespace _3DPrinter.Simulation.DeltaPrinterView.PrinterParts
{
    public interface IRenderView
    {
        void Render(ViewData viewData, Graphics g);
    }
}