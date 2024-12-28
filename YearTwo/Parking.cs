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
    public partial class Parking : Form
    {
        public Parking()
        {
            InitializeComponent();
        }
        
        private DateTime CheckIn, Checkout;

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Checkout = DateTime.Now;
            txtCheckOut.Text = Checkout.ToString("dddd, dd-MMM-yyyy hh:mm:ss tt");

            if (txtCheckIn.Text != "")
            {
                string tout = Checkout.ToString("dd-MM-yyyy HH:mm");
                string tin = CheckIn.ToString("dd-MM-yyyy HH:mm");
                DateTime o = DateTime.ParseExact(tout, "dd-MM-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                DateTime i = DateTime.ParseExact(tin, "dd-MM-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                double totalMin = (o - i).TotalMinutes;
                txtResult.Text ="You are here " + totalMin + "min.\r\n";
                txtResult.AppendText ("We are free for you 1h.\r\n");

                totalMin -= 60;
                if (totalMin <= 0)
                {
                    totalMin = 0;
                    txtResult.AppendText("You no need to pay. See you again!");
                }
                else
                {
                    int min = (int)totalMin % 60;
                    int hour = (int)totalMin / 60;
                    txtResult.AppendText("You stay here " + hour +"h and " + min +"min.\r\n");

                    double payment = hour * 2000;

                    if (min == 0)
                        payment += 0;
                    else if (min <= 15)
                        payment += 500;
                    else if (min <= 30)
                        payment += 1000;
                    else if (min <= 45)
                        payment += 1500;
                    else 
                        payment += 2000;
                    txtResult.AppendText("Pay is " + payment + "Riel.");       
                }
            }
            else
            {
                MessageBox.Show("Please press Check In first!");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn = DateTime.Now;
            txtCheckIn.Text = CheckIn.ToString("dddd, dd-MMM-yyyy hh:mm:ss tt");
        }
    }
}
