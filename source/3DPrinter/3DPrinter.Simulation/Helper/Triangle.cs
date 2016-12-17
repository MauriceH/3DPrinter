using System.Drawing;

namespace DeltaPrinter.Simulation.Helper
{
    public class Triangle
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public double alpha { get; private set; }
        public double beta { get; private set; }
        public double gamma { get; private set; }

       public static Triangle T90GammaBy_C_alpha(double c, double alpha)
        {
            var tri = new Triangle();
            tri.gamma = 90;
            tri.alpha = alpha;
            tri.beta = 180 - tri.alpha - tri.gamma;
            tri.c = c;
            tri.a = tri.c * DegMath.Sin(tri.alpha) / DegMath.Sin(tri.gamma);
            tri.b = tri.c*DegMath.Sin(tri.beta)/DegMath.Sin(tri.gamma);
            return tri;
        }


        public static Triangle EqualSidedAB_By_C_A_B(double c, double ab)
        {
            var tri = new Triangle();
            tri.c = c;
            tri.a = ab;
            tri.b = ab;
            tri.alpha = DegMath.Acos((- c * c) / (-2 * ab * c));
            tri.beta = tri.alpha;
            tri.gamma = 180 - tri.alpha - tri.beta;
            return tri;
        }

        public Point CreatePointAB()
        {
            return new Point((int) a, (int) b);
        }
    }
}
 