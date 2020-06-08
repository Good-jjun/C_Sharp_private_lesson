using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 짝수_홀수
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);

            if (num % 2 == 0)

                label2.Text = num + "는" + "짝수입니다";

            if (num % 2 == 1)
                label2.Text = num + "는" + " 홀수입니다";

        }
    }
}
