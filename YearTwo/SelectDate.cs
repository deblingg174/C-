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
    public partial class SelectDate : Form
    {
        public SelectDate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectDate_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            for (int i = year - 200; i <= year + 200; i++)
                comboYear.Items.Add(i);

            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            comboYear.SelectedItem = year;
            comboMonth.SelectedIndex = month - 1;
            comboDay.SelectedItem = day;
        }

        private void comboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateDay();
        }

        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateDay();
        }
        private void CreateDay()
        {
            int month = comboMonth.SelectedIndex + 1;
            int year = int.Parse(comboYear.SelectedItem +"");
            if (month >= 1)
            {
                int maxDay = DateTime.DaysInMonth(year, month);
                string text = comboDay.Text;
                int oldDay = 0;
                if (text != "")
                {
                    oldDay = int.Parse(comboDay.Text);
                }
                   
                comboDay.Items.Clear();
                for (int i = 1; i <= maxDay; i++)
                {
                    comboDay.Items.Add(i);
                }
                if (comboDay.Items.IndexOf(oldDay) < 0)
                    comboDay.SelectedIndex = maxDay - 1;
            }  
        }
    }
}