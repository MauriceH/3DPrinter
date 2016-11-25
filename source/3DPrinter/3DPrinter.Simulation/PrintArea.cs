using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DPrinter.Simulation
{
    public partial class PrintArea : UserControl
    {

        private readonly PrinterView view;

        public ViewData ViewData { get; set; }

        public PrintArea()
        {
            InitializeComponent();
            view = new PrinterView(ClientRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TranslateTransform((float) (Width * 0.5),(float) (Height * 0.5));
            view.Render(this.ViewData, g);
            base.OnPaint(e);
        }
    }
}
