using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DeltaPrinter.Simulation.DeltaPrinterView.Data;
using DeltaPrinter.Simulation.DeltaPrinterView.DirectMovement;
using DeltaPrinter.Simulation.DeltaPrinterView.PrinterParts;
using DeltaPrinter.Simulation.Helper;

namespace DeltaPrinter.Simulation.DeltaPrinterView
{
    public partial class DeltaPrinterView : UserControl
    {
        public delegate void DirectMovementEventHandler(object sender, DirectMovementArgs e);
        public event DirectMovementEventHandler OnDirectMove;


        private readonly PrinterView view;
        private PrinterConfig printerConfig;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ViewData PrinterData { get; private set; }

        [Category("MyCategory")]
        public AppearanceSettings Appearance { get; set; }

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
            if (head == null) return;
            head.CurrentPosition = point.MoveOffset(PrinterData.Midpoint);
            Refresh();
        }

        public DeltaPrinterView()
        {
            Appearance = new AppearanceSettings();
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
            
            PrinterData.DrawSettings = Appearance;

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
