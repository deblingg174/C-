using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearTwo
{
    public partial class SumValue : Form
    {
        public SumValue()
        {
            InitializeComponent();
        }

        private void SumValue_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(textBox1.Text);
            double v2 = double.Parse(textBox2.Text);
            double sum = v1 + v2;
            string r = v1 + " + " + v2 + " = " + sum;
            txtResult.AppendText(r + "\r\n");

            textBox1.Clear();
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
