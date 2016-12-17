using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DeltaPrinter.Simulation.DeltaPrinterView
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AppearanceSettings
    {
        public SmoothingMode Smoothing { get; set; }

        public AppeareancePen StrokeSmall { get; set; }
        public AppeareancePen StrokeBig { get; set; }
        public AppeareancePen ConnectorBigPen { get; set; }

        public Color HeadAxisConnector { get; set; }
        public Color CoilHeaterColor { get; set; }
        public Color CoilCoolerColor { get; set; }
        public Color PrintHeadPlateColor { get; set; }
        public Color HeatPlateColor { get; set; }
        public Color GroundPlateColor { get; set; }

        [Browsable(false)]
        public Brush CoilHeaterBrush => new SolidBrush(CoilHeaterColor);
        [Browsable(false)]
        public Brush CoilCoolerBrush => new SolidBrush(CoilCoolerColor);
        [Browsable(false)]
        public Brush PrintHeadPlateBrush => new SolidBrush(PrintHeadPlateColor);
        [Browsable(false)]
        public Brush HeatPlateBrush => new SolidBrush(HeatPlateColor);
        [Browsable(false)]
        public Brush GroundPlateBrush => new SolidBrush(GroundPlateColor);


        public AppearanceSettings()
        {
            Smoothing = SmoothingMode.AntiAlias;

            StrokeSmall = new AppeareancePen();
            StrokeBig = new AppeareancePen() {Width = 4};
            ConnectorBigPen = new AppeareancePen {Color = Color.DarkSlateGray, Width = 3};

            HeadAxisConnector = Color.LightGray;

            CoilHeaterColor = Color.Red;
            CoilCoolerColor = Color.CornflowerBlue;
            PrintHeadPlateColor = Color.FromArgb(255, 10, 110, 120);
            HeatPlateColor = Color.FromArgb(80, 160, 50, 50);
            GroundPlateColor = Color.FromArgb(255, 110, 110, 110);
        }

    }
}