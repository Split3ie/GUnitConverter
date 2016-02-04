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
                label1.Text = "Input a mm";
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
{6:0.####}'' = {7:0.#####} units", cm*10, unit*10, cm/100, (cm/100)*52.49, inch, inch/0.75, foot, foot*16);
            }
            else
            {
                label1.Text = "Wrong param!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label2.Text = "Input an units";
                return;
            }
            double unit = float.Parse(textBox2.Text);
            if (Double.TryParse(textBox2.Text, out unit))
            {
                double mm = unit * 19.05;
                label6.Text = string.Format("{1:0.###} cm", unit, mm/10);
                //label6.Text = string.Format("{0:0.####} = {1:0.######} mm", unit, mm / 10);
                label2.Text = string.Format(@"{0:0.####} untis:
{1:0.####} mm
{2:0.####} m
{3:0.####}'
{4:0.####}''", unit, mm, mm/1000, unit*0.75, unit/16);
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
