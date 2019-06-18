using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apollo_IL;

namespace Lilac.IDE
{
    public partial class Watcher : Form
    {
        public Debugger Program;

        public Watcher()
        {
            InitializeComponent();
            lblAL.Text = "";
            lblAH.Text = "";
            lblBL.Text = "";
            lblBH.Text = "";
            lblCL.Text = "";
            lblCH.Text = "";
            lblX.Text = "";
            lblY.Text = "";
            lblPC.Text = "";
            lblSP.Text = "";
            lblIP.Text = "";
            lblSS.Text = "";
        }

        private void UpdateRegisters()
        {
            lblAL.Text = Program.virtualMachine.AL.ToString("X4");
            lblAH.Text = Program.virtualMachine.AH.ToString("X4");
            lblBL.Text = Program.virtualMachine.BL.ToString("X4");
            lblBH.Text = Program.virtualMachine.BH.ToString("X4");
            lblCL.Text = Program.virtualMachine.CL.ToString("X4");
            lblCH.Text = Program.virtualMachine.CH.ToString("X4");
            lblX.Text = Program.virtualMachine.X.ToString("X4");
            lblY.Text = Program.virtualMachine.Y.ToString("X4");
            lblPC.Text = Program.virtualMachine.PC.ToString("X4");
            lblSP.Text = Program.virtualMachine.SP.ToString("X4");
            lblIP.Text = Program.virtualMachine.IP.ToString("X4");
            lblSS.Text = Program.virtualMachine.SS.ToString("X4");
        }

        public void Start()
        {
            Program.virtualMachine.Running = true;
            while (Program.virtualMachine.Running == true)
            {
                while (Program.virtualMachine.ram.memory[Program.virtualMachine.IP] != 0x00)
                {
                    /// <summary>
                    /// Gets the operation from the first six bytes of the instruction pointer
                    /// </summary>
                    /// <returns>operation from instruction pointer</returns>
                    byte opcode = (byte) Program.virtualMachine.GetFirstSix(Program.virtualMachine.ram.memory[Program.virtualMachine.IP]);
                    Program.virtualMachine.GetAddressMode(Program.virtualMachine.ram.memory[Program.virtualMachine.IP]);
                    Program.virtualMachine.ParseOpcode(opcode);
                    Program.virtualMachine.IP = Program.virtualMachine.PC;
                    Program.virtualMachine.PC++;
                    UpdateRegisters();
                    Thread.Sleep(500);
                }
            }
            Program.virtualMachine.Running = false;
            Program.virtualMachine.Halt();
        }
    }
}
