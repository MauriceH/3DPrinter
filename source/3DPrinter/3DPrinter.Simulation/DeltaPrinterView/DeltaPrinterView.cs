using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _3DPrinter.Simulation.DeltaPrinterView.Data;
using _3DPrinter.Simulation.DeltaPrinterView.DirectMovement;
using _3DPrinter.Simulation.DeltaPrinterView.PrinterParts;
using _3DPrinter.Simulation.Helper;

namespace _3DPrinter.Simulation.DeltaPrinterView
{
    public partial class DeltaPrinterView : UserControl
    {
        public delegate void DirectMovementEventHandler(object sender, DirectMovementArgs e);
        public event DirectMovementEventHandler OnDirectMove;


        private readonly PrinterView view;
        private PrinterConfig printerConfig;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ViewData PrinterData { get; private set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DrawingSettings DrawSettings { get; set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PrinterConfig PrinterConfig
        {
            get { return printerConfig;  }
            set
            {
                printerConfig = value;
                CreatePrinterData();
            }
        }

        public void SetHeadPosition(Point point)
        {
            var head = PrinterData?.PrintHead;
            if (head != null) head.CurrentPosition = point;
            Refresh();
        }

        public DeltaPrinterView()
        {
            InitializeComponent();
            printerConfig = new PrinterConfig();
            CreatePrinterData();
            view = new PrinterView(ClientRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (PrinterData == null)
            {
                return;
            }
            var g = e.Graphics;
            
            PrinterData.DrawSettings = DrawSettings ?? new DrawingSettings();

            g.SmoothingMode = PrinterData.DrawSettings.Smoothing;
            
            view.Render(PrinterData, g);
            base.OnPaint(e);
        }

        private void CreatePrinterData()
        {
            var config = PrinterConfig ?? new PrinterConfig();
            var cRect = new Rectangle(0, 0, 400, 400);
            var data = new ViewData
            {
                PrintArea = cRect,
                Midpoint = cRect.GetMidpoint(),
                PrintHead = new PrintHeadViewData(config),
                PrinterBase =  new PrintBaseViewData(config, ClientRectangle.GetMidpoint())
            };
            data.PrintHead.CurrentPosition = data.Midpoint;
            PrinterData = data;
        }



        #region " Direct Movement "
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) RaiseDirectMovementEvent(e.Location);
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) RaiseDirectMovementEvent(e.Location);
            base.OnMouseMove(e);
        }

        private void RaiseDirectMovementEvent(Point location)
        {
            if (OnDirectMove == null) return;
            var midpoint = PrinterData?.Midpoint;
            if (!midpoint.HasValue) return;
            OnDirectMove(this, new DirectMovementArgs(location.X - midpoint.Value.X, location.Y - midpoint.Value.Y));
        }
        #endregion

    }
}
