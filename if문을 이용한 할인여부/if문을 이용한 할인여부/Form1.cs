using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if문을_이용한_할인여부
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                bool bData01 = iData01 <= 15 || iData01 >= 65;

                if (bData01 == true)
                    label3.Text = "할인여부:할인가능";
                else
                    label3.Text = "할인여부:할인불가능";
            }
            catch
            {
                label2.Text = "결과에 이상이 있습니다";
            }
        }
    }
}
