using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDemoC_Sharp
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 3;
            gunaCircleProgressBar1.Value = startpoint;
            if (gunaCircleProgressBar1.Value == 100)
            {

                gunaCircleProgressBar1.Value = 0;
                timer1.Stop();
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.Show();
            }
    }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
