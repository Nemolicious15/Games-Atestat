using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Games
{
    public partial class Jocuri : Form
    {
        public Jocuri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("joc1.exe");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("joc2.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("joc3.exe");
            frmCancer pua = new frmCancer();
            pua.Show();
        }
    }
}
