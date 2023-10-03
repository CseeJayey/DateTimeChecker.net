using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DateTimeLib;

namespace DateTimeChecker
{
    public partial class FormDateTimeChecker : Form
    {
        DTLib dtlib = new DTLib();
        public FormDateTimeChecker() => InitializeComponent();

        private void btnCheck_Click(object sender, EventArgs e) => dtlib.isValidDate(txtYear.Text, txtMonth.Text, txtDay.Text);

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDay.Clear();
            txtMonth.Clear();
            txtYear.Clear();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < rand.Next(1, 5); i++)
            {
                txtDay.Text = rand.Next(1, 50).ToString();
                txtMonth.Text = rand.Next(1, 20).ToString();
                txtYear.Text = rand.Next(1960, 5000).ToString();
            }
        }
    }
}