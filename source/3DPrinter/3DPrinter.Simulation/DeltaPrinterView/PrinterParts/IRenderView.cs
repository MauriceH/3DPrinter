using System.Drawing;
using DeltaPrinter.Simulation.DeltaPrinterView.Data;

namespace DeltaPrinter.Simulation.DeltaPrinterView.PrinterParts
{
    public interface IRenderView
    {
        void Render(ViewData viewData, Graphics g);
    }
}