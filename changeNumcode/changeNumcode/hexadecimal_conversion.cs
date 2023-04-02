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
    public partial class hexadecimal_conversion : Form
    {
        public hexadecimal_conversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(int.Parse(textBox1.Text), 2);
            textBox3.Text = Convert.ToString(int.Parse(textBox1.Text), 8);
            textBox4.Text = Convert.ToString(int.Parse(textBox1.Text), 16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToInt64(textBox5.Text, 2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToInt32(textBox7.Text, 8).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(textBox9.Text, System.Globalization.NumberStyles.HexNumber);
            textBox10.Text = x1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] byteary = Encoding.ASCII.GetBytes(textBox11.Text);
            textBox12.Text = BitConverter.ToString(byteary).Replace("-", " ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
