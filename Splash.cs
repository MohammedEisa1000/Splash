using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_screen
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            label1.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 120)
            {
                timer1.Enabled = false;
                Form1 f = new Form1();
                f.Show();
                this.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
