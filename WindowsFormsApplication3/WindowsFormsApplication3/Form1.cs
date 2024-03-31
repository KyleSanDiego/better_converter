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
            Double n1, conv;

            n1 = int.Parse(txtnum1.Text);
            conv = n1 * 56.16 / 1;
            txtanswer.Text = conv.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtanswer.Clear();
        }
    }
}
