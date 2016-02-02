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
            try
            {
                if (textBox1.Text == "")
                    label1.Text = "Input a cm";
                double m = float.Parse(textBox1.Text);
                double unit = (m*10) / 19.05;
                label1.Text = string.Format("{0:0.####} units", unit);
                label2.Text = string.Format("{0} mm = {1:0.#######} untis", m*10, unit);
                double unit2 = (m/100)*53.333;
                label3.Text = string.Format("{0} m = {1:0.#####} units",m/100, unit2);
            }
            catch{}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                    label2.Text = "Input an units";
                double unit = float.Parse(textBox2.Text);
                double cm = unit * 19.05;
                label6.Text = string.Format("{0:0.####} = {1:0.######} cm", unit, cm/10);
            }
            catch { }    
        }
    }
}
