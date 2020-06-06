using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ㄱ구구구구구단
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                if (num >= 1)
                {
                    int number = 0;
                    string sOutput = " 구구단 " + num + " 단 " + "\n";
                    for (int i = 1; i <= 9; i++)
                    {
                        number = num * i;
                        sOutput = sOutput + num + " * " + i + " = " + number + "\n";
                    }
                    {
                        label2.Text = sOutput;
                    }
                }
                else
                {
                    label2.Text = "숫자를 입력하세요";
                }
            }
            catch
            {
                label2.Text = "잘못된 입력입니다";
            }
        }
    }
}
