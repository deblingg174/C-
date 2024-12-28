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
    public partial class SalaryTax : Form
    {
        public SalaryTax( double salary)
        {
            InitializeComponent();
            this.salary = salary;
            txtSalary.Text = salary + "";
        }
        double salary;
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
     
            double bonus  = double.Parse(txtBonus.Text);
            int spouse    = int.Parse(txtSpouse.Text);
            int children  = int.Parse(txtChildren.Text);
            if (salary > 0 && bonus > 0)
            {
                if (spouse >= 1)
                    spouse = 1;
                else
                    spouse = 1;
                if (children >= 9)
                    children = 9;
                else if (children <= 0)
                    children = 0;

                txtSpouse.Text = spouse + "";
                txtChildren.Text = children + "";

                double tax, lastSalary;
                double family = (spouse + children) * 150000;
                salary -= family;

                if (salary <= 1500000)
                    tax = 0;
                else if (salary <= 2000000)
                    tax = salary * 0.05 - 75000;
                else if (salary <= 8500000)
                    tax = salary * 0.1 - 175000;
                else if (salary <= 12500000)
                    tax = salary * 0.15 - 600000;
                else 
                    tax = salary * 0.2 - 1225000;

                tax += bonus * 0.2;
                lastSalary = (salary + family + bonus) - tax;

                lTax.Text = tax.ToString("#,##0.## R");
                lSalary.Text = lastSalary.ToString("#,##0.## R");  
            }
            else
                MessageBox.Show("Invalid Input", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtBonus.Focus();
            }
        }

        private void txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSpouse.Focus();
            }
        }

        private void txtSpouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtChildren.Focus();
            }
        }

        private void txtChildren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalculate_Click(sender, e);
            }
        }
    }
}
