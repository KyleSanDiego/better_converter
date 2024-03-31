using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbselect.SelectedItem.ToString() == "USD")
            {
                Double n1, conv;
                n1 = double.Parse(txtnum1.Text);
                conv = n1 * 56.15 / 1;
                txtanswer.Text = conv.ToString();
            }

            if (cbselect.SelectedItem.ToString() == "EURO")
            {
                Double n1, conv;
                n1 = double.Parse(txtnum1.Text);
                conv = n1 * 60.66 / 1;
                txtanswer.Text = conv.ToString();
            }

            if (cbselect.SelectedItem.ToString() == "YEN")
            {
                Double n1, conv;
                n1 = double.Parse(txtnum1.Text);
                conv = n1 * 0.37 / 1;
                txtanswer.Text = conv.ToString();
            }

            if (cbselect.SelectedItem.ToString() == "WON")
            {
                Double n1, conv;
                n1 = double.Parse(txtnum1.Text);
                conv = n1 * 0.042 / 1;
                txtanswer.Text = conv.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtanswer.Clear();
        }

        private void cbselect_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
