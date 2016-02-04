using System;
using System.Windows.Forms;

namespace HammerTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                label1.Text = "Input a cm";
                return;
            }
            double m;
            if (Double.TryParse(textBox1.Text, out m))
            {
                double unit = (m * 10) / 19.05;
                label1.Text = string.Format("{0:0.####} units", unit);
                label2.Text = string.Format("{0} mm = {1:0.#######} untis", m * 10, unit);
                double unit2 = (m / 100) * 53.333;
                label3.Text = string.Format("{0} m = {1:0.#####} units", m / 100, unit2);
            }
            else
            {
                label1.Text = "Wrong param!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Text = "Input an units";
                return;
            }
            double unit = float.Parse(textBox2.Text);
            if (Double.TryParse(textBox2.Text, out unit))
            {
                double cm = unit * 19.05;
                label6.Text = string.Format("{0:0.####} = {1:0.######} cm", unit, cm / 10);
            }
            else
            {
                label2.Text = "Wrong param!";
            }
        }
    }
}
