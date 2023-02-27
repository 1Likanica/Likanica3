using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Likanica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private double f(double x)
        {
            if (radioButton1.Checked) return Math.Abs(Math.Sin(x));
            else if (radioButton2.Checked) return Math.Pow(x, 2);
            else if (radioButton3.Checked) return Math.Exp(x);
            else return 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            textBox4.Text += 
                "X = " + x.ToString();
            textBox4.Text += Environment.NewLine +
                "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine +
                "Z = " + z.ToString();
            double a = Math.Max(f(x) + y + z, x * y * z);
            double b = Math.Min(f(x) + y + z, x * y * z);
            double q = a / b;
            textBox4.Text += Environment.NewLine +
                "q = " + q.ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
