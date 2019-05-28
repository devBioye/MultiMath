using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MultiMath
{
    public partial class Licence : Form
    {
        public Licence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string licence = textBox1.Text;
            if (licence == "prst-y3zd-56gh-99oc")
            {
                MessageBox.Show("Confirm Successfully.Restart the Application", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Hide();
                Properties.Settings.Default.licenced = licence;
                Properties.Settings.Default.Save();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Wrong Licence", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("www.opinesorbit.blogspot.com/2017/01/how-multimath-works.html");
        }
    }
}
