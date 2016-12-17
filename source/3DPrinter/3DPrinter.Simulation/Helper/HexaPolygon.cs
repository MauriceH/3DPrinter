using System.Collections.Generic;
using System.Drawing;

namespace _3DPrinter.Simulation.Helper
{
    public class HexaPolygon
    {

        public Point[] Points { get; private set; }

        public HexaPolygon(double radius, double forcedThreeSideWith)
        {
            var midpointDegrees = CalcMidpointDegrees(radius, forcedThreeSideWith);
            var fillerDegrees = (360 - (midpointDegrees * 3)) / 3;
            var b = Triangle.T90GammaBy_C_alpha(radius, fillerDegrees * 0.5).CreatePointAB().FlipX();
            var a = Triangle.T90GammaBy_C_alpha(radius, (fillerDegrees * 0.5) + midpointDegrees).CreatePointAB().FlipX();
            var c = b.FlipX();
            var d = a.FlipX();
            var e = Triangle.T90GammaBy_C_alpha(radius, (midpointDegrees * 0.5)).CreatePointAB().FlipY();
            var f = e.FlipX();
            Points = new[] {a,b,c,d,e,f};
        }

        private static double CalcMidpointDegrees(double size, double connectorLength)
        {
            var tmpTri = Triangle.EqualSidedAB_By_C_A_B(connectorLength, size);
            return tmpTri.gamma;
        }
    }
}