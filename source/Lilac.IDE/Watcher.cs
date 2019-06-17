using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lilac.IDE
{
    public partial class Watcher : Form
    {
        public Watcher()
        {
            InitializeComponent();
            this.lblAL.Text = "";
            this.lblAH.Text = "";
            this.lblBL.Text = "";
            this.lblBH.Text = "";
            this.lblCL.Text = "";
            this.lblCH.Text = "";
            this.lblX.Text = "";
            this.lblY.Text = "";
            this.lblPC.Text = "";
            this.lblSP.Text = "";
            this.lblIP.Text = "";
            this.lblSS.Text = "";
        }

        public void Update()
        {
            while (MainWindow.Program.virtualMachine.Running == true)
            {
                this.lblAL.Text = MainWindow.Program.virtualMachine.AL.ToString("X4");
                this.lblAH.Text = MainWindow.Program.virtualMachine.AH.ToString("X4");
                this.lblBL.Text = MainWindow.Program.virtualMachine.BL.ToString("X4");
                this.lblBH.Text = MainWindow.Program.virtualMachine.BH.ToString("X4");
                this.lblCL.Text = MainWindow.Program.virtualMachine.CL.ToString("X4");
                this.lblCH.Text = MainWindow.Program.virtualMachine.CH.ToString("X4");
                this.lblX.Text = MainWindow.Program.virtualMachine.X.ToString("X4");
                this.lblY.Text = MainWindow.Program.virtualMachine.Y.ToString("X4");
                this.lblPC.Text = MainWindow.Program.virtualMachine.PC.ToString("X4");
                this.lblSP.Text = MainWindow.Program.virtualMachine.SP.ToString("X4");
                this.lblIP.Text = MainWindow.Program.virtualMachine.IP.ToString("X4");
                this.lblSS.Text = MainWindow.Program.virtualMachine.SS.ToString("X4");
            }
        }
    }
}
