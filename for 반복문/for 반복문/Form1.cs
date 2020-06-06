using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_반복문
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sData01 = "";
            for (int i = 17; i <= 100; i++)
            {
                if ((i % 17) == 0)
                    sData01 = sData01 + i.ToString() + ",";
            }
            label2.Text = "17로 나누어 떨어지는 수 :" + sData01;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
