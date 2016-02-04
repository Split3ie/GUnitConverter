using System;
using System.Windows.Forms;

namespace HammerUnitsConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //linkLabel1.Links.Add(7,6, "steamcommunity.com/id/bawdyq/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                label1.Text = "Input a cm";
                label2.Text = "";
                return;
            }
            double cm;
            if (Double.TryParse(textBox1.Text, out cm))
            {
                double unit = cm / 19.05;
                label1.Text = string.Format("{0:0.##} units", unit*10);
                double inch = cm * 0.39370079;
                double foot = inch / 12;
                label2.Text = string.Format(@"{0} mm = {1:0.######} units
{2:0.####} m = {3:0.#####} units 
{4:0.####}' =  {5:0.######} units 
{6:0.####}'' = {7:0.#####} units", cm*10, unit*10, cm/100, unit * 10, inch, inch/0.75, foot, foot*16);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/id/bawdyq/");
        }
    }
}
