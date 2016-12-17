using System;
using System.Drawing;

namespace DeltaPrinter.Simulation.DeltaPrinterView.DirectMovement
{

    public class DirectMovementArgs : EventArgs
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point Point => new Point(X,Y);

        public DirectMovementArgs(int x, int y)
        {
            X = x;
            Y = y;
        }

        
    }
}