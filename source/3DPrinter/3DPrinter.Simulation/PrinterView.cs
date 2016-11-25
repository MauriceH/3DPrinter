using System.Drawing;

namespace _3DPrinter.Simulation
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
            printHeadView.Render(viewData, g);
        }
    }
}