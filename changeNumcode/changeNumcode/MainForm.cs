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
    public partial class MainForm : Form
    {
        hexadecimal_conversion hex = null;
        Ascci asc = null;
        ColorCode cd = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(asc == null || asc.IsDisposed)
            {
                asc = new Ascci();
                asc.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(hex == null || hex.IsDisposed)
            {
                hex = new hexadecimal_conversion();
                hex.Show();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if(cd == null || cd.IsDisposed)
            {
                cd = new ColorCode();
                cd.Show();
            }
        }
    }
}
