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
    public partial class Ascci : Form
    {
        public Ascci()
        {
            InitializeComponent();
        }

        private void toAskButton_Click(object sender, EventArgs e)
        {
            string s = ToAsk.Text;
            string t = "";
            for (int i = 0; i < s.Length; i++)
            {
                t = t + Convert.ToInt32(s[i]) + ",";
            }
            ToLang.Text = t.Remove(t.Length-1);
        }
        
        private void toStrButton_Click(object sender, EventArgs e)
        {
            string xx = "";
            try
            {
                string ln = ToLang.Text;
                string[] ss = ln.Split(',');
                List<int> yy = new List<int>();
                for(int i =0; i < ss.Length; i++)
                {
                    int x = Convert.ToInt32(ss[i]);
                    yy.Add(x);
                    xx = xx + (char)yy[i];
                }
                printLabel.Text = xx;
            }catch(FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var a = MessageBox.Show("消去しますか?","操作確認",MessageBoxButtons.OKCancel);
            if(a == DialogResult.OK)
            {
                printLabel.Text = "";
            }else if(a == DialogResult.Cancel)
            {
                MessageBox.Show("キャンセルしました。");
            }
        }
    }
}
