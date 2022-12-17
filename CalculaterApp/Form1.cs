using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelresulte_Click(object sender, EventArgs e)
        {

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            // input
            int num1 = int.Parse(textBoxnum1.Text);
            int num2 = int.Parse(textBoxnum2.Text);
            //action
            int res = num1 + num2;

            //output
            labelresulte.Text = res.ToString();
            labelresultinfo.Text = num1.ToString() + " + " + num2.ToString() + " = " + res.ToString();
        }

        private void labelresultinfo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBoxnum1.Text);
            int num2 = int.Parse(textBoxnum2.Text);
            //action
            int res = num1 - num2;

            //output
            labelresulte.Text = res.ToString();
            labelresultinfo.Text = num1.ToString() + " - " + num2.ToString() + " = " + res.ToString();
        }

        private void buttonrest_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBoxnum1.Text);
            int num2 = int.Parse(textBoxnum2.Text);
            //action
            int res = num1 / num2;

            //output
            labelresulte.Text = res.ToString();
            labelresultinfo.Text = num1.ToString() + " / " + num2.ToString() + " = " + res.ToString();
        }

        private void buttonmult_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBoxnum1.Text);
            int num2 = int.Parse(textBoxnum2.Text);
            //action
            int res = num1 * num2;

            //output
            labelresulte.Text = res.ToString();
            labelresultinfo.Text = num1.ToString() + " * " + num2.ToString() + " = " + res.ToString();
        }
    }
}
