using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3DPrinter.Simulation.DeltaPrinterView.DirectMovement;

namespace _3DPrinter.Simulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void delterPrinterView_OnDirectMove(object sender, DirectMovementArgs e)
        {

        }
    }
}
