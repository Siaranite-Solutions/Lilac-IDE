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
    public partial class BinaryArray : Form
    {
        public BinaryArray(string output)
        {
            InitializeComponent();
            richTextBox1.Text = output;
            richTextBox1.SelectAll();
            richTextBox1.Copy();
            richTextBox1.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
