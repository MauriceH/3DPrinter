using System;

namespace _3DPrinter.Simulation.DeltaPrinterView.DirectMovement
{

    public class DirectMovementArgs : EventArgs
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public DirectMovementArgs(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}