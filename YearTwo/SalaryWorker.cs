using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace YearTwo
{
    public partial class SalaryWorker : Form
    {
        public SalaryWorker()
        {
            InitializeComponent();
        }
        private double totalSalary;
        private void button1_Click(object sender, EventArgs e)
        {
            long totalTime = long.Parse(txtTotalTime.Text);
            if (totalTime > 0)
            {
                double basicSalary = 50;
                if (totalTime >= 100)
                {
                    //Report 1
                    long ex1, ex2;
                    double bRate1 = 1.25, bRate2 = 1.5, bSalary;
                    long ex = totalTime - 100;
                    if (ex <= 20)
                    {
                        ex1 = ex;
                        ex2 = 0;
                    }
                    else
                    {
                        ex1 = 20;
                        ex2 = ex - 20;
                    }
                    bSalary = (ex1 * bRate1) + (ex2 * bRate2);
                    totalSalary = basicSalary + bSalary;
                    string result = "Extra Time 1 = " + ex1 + "H \r\n";
                    result += "Extra Time 2 = " + ex2 + "H \r\n";
                    result += "Bonus Rate 1 = " + bRate1.ToString("$0.00") + "/H \r\n";
                    result += "Bonus Rate 2 = " + bRate2.ToString("$0.00") + "/H \r\n";
                    result += "Bonus Salary = " + bSalary.ToString("$0.00") + "\r\n";
                    result += "Basic Salary = " + basicSalary.ToString("$0.00") + "\r\n";
                    result += "------------------------------------------------\r\n";
                    result += "Total Salary = " + totalSalary.ToString("$0.00") + "\r\n";
                    txtResult.Text = result;
                }
                else
                {
                    //Report 2
                    double lRate = 0.5;
                    double lSalary = (100 - totalTime) * lRate;
                    totalSalary = basicSalary - lSalary;
                    string result = "Basic Salary = " + basicSalary.ToString("$0.00") + "\r\n";
                           result += "Lost Rate = " + lRate.ToString("$0.00" + "/H\r\n");
                           result += "Lost Salary = " + lSalary.ToString("$0.00" + "\r\n");
                           result += "------------------------------------------------\r\n";
                           result += "Total Salary = " + totalSalary.ToString("$0.00") + "\r\n";
                    txtResult.Text = result;


                }
            }
            else
                MessageBox.Show("Invalided Input");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = Interaction.InputBox("Enter Rate $","Rate $","4000",-1,-1);
            if (text != "")
            {
                double rate = double.Parse(text.Trim());
                new SalaryTax(totalSalary * rate).ShowDialog(this);

            }

            
        }

        private void txtTotalTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
