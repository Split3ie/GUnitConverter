using System;
using System.Windows.Forms;

namespace HammerUnitsConverter
{
    public partial class Form1 : Form
    {
        private readonly UnitConverter UConverter = new UnitConverter();
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
                UConverter.MakeConvertToUnit(cm);
                label1.Text = string.Format("{0:0.##} units", UConverter.Unit);
                label2.Text = string.Format(@"{0} cm = {1:0.######} units
{2:0.####} m = {3:0.#####} units 
{4:0.####}' =  {5:0.######} units 
{6:0.####}'' = {7:0.#####} units", UConverter.Cm, UConverter.Unit, UConverter.M, (UConverter.M)*52.49, UConverter.Inch, UConverter.Inch/0.75, UConverter.Foot, UConverter.Foot*16);
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
                UConverter.MakeConvertToCm(unit);
                label6.Text = string.Format("{1:0.###} cm", UConverter.Unit, UConverter.Cm);
                //label6.Text = string.Format("{0:0.####} = {1:0.######} mm", unit, mm / 10);
                label2.Text = string.Format(@"{0:0.####} units:
{1:0.####} mm
{2:0.####} m
{3:0.####}'
{4:0.####}''", UConverter.Unit, UConverter.MM, UConverter.M, UConverter.Inch, UConverter.Foot);
            }
            else
            {
                label2.Text = "Wrong param!";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/id/The_Split/");
        }
    }
}
