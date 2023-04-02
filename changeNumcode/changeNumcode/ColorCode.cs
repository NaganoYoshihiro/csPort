using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeNumcode
{
    public partial class ColorCode : Form
    {
        public ColorCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int R = (int)numericUpDown_R.Value;
            int G = (int)numericUpDown_G.Value;
            int B = (int)numericUpDown_B.Value;

            Color color = Color.FromArgb(R,G,B);
            panel1.BackColor = color;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }
    }
}
