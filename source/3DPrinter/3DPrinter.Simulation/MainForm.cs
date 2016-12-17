using System.Windows.Forms;
using DeltaPrinter.Simulation.DeltaPrinterView.DirectMovement;

namespace DeltaPrinter.Simulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void delterPrinterView_OnDirectMove(object sender, DirectMovementArgs e)
        {
            delterPrinterView.SetHeadPosition(e.Point);
        }

        void test()
        {
            
        }
    }
}
