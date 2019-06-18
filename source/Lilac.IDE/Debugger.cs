using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apollo_IL;

namespace Lilac.IDE
{
    public class Debugger
    {
        public bool DebugMode = true;

        public VM virtualMachine;

        private void Execute()
        {
            virtualMachine.Execute();
        }

        public Debugger(byte[] executable, bool verbose)
        {
            this.Program = executable;
            virtualMachine = new VM(executable, (executable.Length + 1024));
        }

        public byte[] Program = null;

        public void Run()
        {
            byte[] LoadedApplication = Program;
            Globals.console = new RuntimeIO();
            Globals.DebugMode = DebugMode;
            Console.Title = "Apollo-VM Runtime - Debugger";
            try
            {
                Execute();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message + "\nPress any key to terminate...");
                Console.ReadKey(true);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }
    }
}
