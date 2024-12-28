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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string user = UserName.Text.Trim();
            string password = Password.Text;

            bool cuser = user.ToLower() == "devit".ToLower();
            bool cpass = password == "devit";

            if (cuser && cpass)
            {
                //Open Program
                this.Hide();
                new SumValue().Show(this);
            }else if (cuser)
            {
                MessageBox.Show("Incorrect password");
            }else
            {
                MessageBox.Show("Invalid user name");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
