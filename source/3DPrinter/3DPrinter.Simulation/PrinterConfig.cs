namespace _3DPrinter.Simulation
{
    public class PrinterConfig
    {

        public double GroundPlateCornerRadius { get; set; } = 200;
        public double GroundPlateCornerDistance { get; set; } = 120;
        public double GroundAxisConnectPointRadius { get; set; } = 180;

        public int HeatPlateRadius { get; set; } = 100;

        public double PrintHeadCornerRadius { get; set; } = 50;
        public double PrintHeadCornerDistance { get; set; } = 20;
        public double AxisConnectPointRadius { get; set; } = 45;
        public double AxisConnectPointDistance { get; set; } = 15;

    }
}