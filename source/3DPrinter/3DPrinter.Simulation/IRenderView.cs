using System.Drawing;

namespace _3DPrinter.Simulation
{
    public interface IRenderView
    {
        void Render(ViewData viewData, Graphics g);
    }
}