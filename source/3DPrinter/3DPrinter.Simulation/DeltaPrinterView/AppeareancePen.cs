using System.ComponentModel;
using System.Drawing;

namespace DeltaPrinter.Simulation.DeltaPrinterView
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AppeareancePen
    {
        private Pen pen;

        private int width;
        private Color color;

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                Createpen();
            }
        }

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                Createpen();
            }
        }


        [Browsable(false)]
        public Pen Pen => pen;


        public AppeareancePen()
        {
            color = Color.Black;
            Width = 1;
        }

        private void Createpen()
        {
            pen = new Pen(color,(float) width);
        }
    }
}