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
    public partial class laon : Form
    {
        public laon()
        {
            InitializeComponent();
        }

        private void btnTher_Click(object sender, EventArgs e)
        {
            double loan = double.Parse(txtLoan.Text);
            double interestRate = double.Parse(txtRate.Text);
            int month = int.Parse(txtMonth.Text);

            DateTime dateTime = DateTime.Now;
            listView1.Items.Clear();

            interestRate /= 100;
            double installment, principal, interest, debt = loan;

            installment = (loan * interestRate) / (1 - Math.Pow((1 + interestRate), -month));

            for (int i = 1; i <= month; i++)
            {
                interest = debt * interestRate;
                principal = installment - interest;
                debt -= principal;

                if (i == month)
                {
                    installment = Math.Round(principal, 2) + Math.Round(interest, 2);
                }
                
                ListViewItem item = new ListViewItem(dateTime.AddMonths(i).ToString("dd-MM-yy"));
                item.SubItems.Add(installment.ToString("c2"));
                item.SubItems.Add(principal.ToString("c2"));
                item.SubItems.Add(interest.ToString("c2"));
                item.SubItems.Add(debt.ToString("c2"));
                listView1.Items.Add(item);
            }

            double totalInstallment = installment * month;
            double totalInterest = totalInstallment - loan;

            ListViewItem totalItem = new ListViewItem("Total");
            totalItem.SubItems.Add(totalInstallment.ToString("c2"));
            totalItem.SubItems.Add(loan.ToString("c2"));
            totalItem.SubItems.Add(totalInterest.ToString("c2"));
            totalItem.SubItems.Add("-");
            listView1.Items.Add(totalItem);

        }

        private void btnThay_Click(object sender, EventArgs e)
        {
            double loan = double.Parse(txtLoan.Text);
            double interestRate = double.Parse(txtRate.Text);
            int month = int.Parse(txtMonth.Text);

            DateTime dateTime = DateTime.Now;
            listView1.Items.Clear();

            interestRate /= 100;
            double installment, principal, interest, debt = loan;

            principal = loan / month;

            for (int i = 1; i <= month; i++)
            {
                interest = debt * interestRate;
                installment = principal + interest;
                debt -= principal;

                ListViewItem item = new ListViewItem(dateTime.AddMonths(i).ToString("dd-MM-yy"));
                item.SubItems.Add(installment.ToString("c2"));
                item.SubItems.Add(principal.ToString("c2"));
                item.SubItems.Add(interest.ToString("c2"));
                item.SubItems.Add(debt.ToString("c2"));
                listView1.Items.Add(item);
            }

            double totalInterest = (loan * interestRate) * (month + 1) / 2;
            double totalInstallment = totalInterest + loan;

            ListViewItem totalItem = new ListViewItem("Total");
            totalItem.SubItems.Add(totalInstallment.ToString("c2"));
            totalItem.SubItems.Add(loan.ToString("c2"));
            totalItem.SubItems.Add(totalInterest.ToString("c2"));
            totalItem.SubItems.Add("-");
            listView1.Items.Add(totalItem);
        }

        private void txtLoan_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
