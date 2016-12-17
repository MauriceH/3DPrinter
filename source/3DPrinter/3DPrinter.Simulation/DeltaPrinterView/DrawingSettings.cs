using System.Drawing;
using System.Drawing.Drawing2D;

namespace _3DPrinter.Simulation.DeltaPrinterView
{
    public class DrawingSettings
    {

        public Pen StrokePenSmall { get; set; } = new Pen(Color.Black, 1);
        public Pen StrokePenBig { get; set; } = new Pen(Color.Black, 4);

        public Brush CoilHeaterBrush { get; set; } = new SolidBrush(Color.Red);
        public Brush CoilCoolerBrush { get; set; } = new SolidBrush(Color.CornflowerBlue);
        public Brush PrintHeadPlateBrush { get; set; } = new SolidBrush(Color.FromArgb(255, 10, 110, 120));
        public Brush HeatPlateBrush { get; set; } = new SolidBrush(Color.FromArgb(80, 160, 50, 50));

        public SmoothingMode Smoothing { get; set; } = SmoothingMode.AntiAlias;

        public Color HeadAxisConnector { get; set; } = Color.LightGray;
        public Brush GroundPlateBrush { get; set; } = new SolidBrush(Color.FromArgb(255,110,110,110));
        public Pen ConnectorBigPen { get; set; } = new Pen(Color.DarkSlateGray,3);

        public DrawingSettings()
        {
            ConnectorBigPen.StartCap = LineCap.Round;
            ConnectorBigPen.EndCap =LineCap.Round;
        }

    }
}