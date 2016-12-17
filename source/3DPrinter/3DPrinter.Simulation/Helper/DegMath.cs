using System;

namespace DeltaPrinter.Simulation.Helper
{
    public static class DegMath
    {
        public static double Cos(double zahl)
        {
            return Math.Cos(zahl * (Math.PI / 180));
        }

        public static double Sin(double zahl)
        {
            return Math.Sin(zahl * (Math.PI / 180));
        }

        public static double Acos(double zahl)
        {
            var acos = Math.Acos(zahl);
            return (acos * (180 / Math.PI));
        }
    }
}