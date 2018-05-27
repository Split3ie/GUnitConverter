using HammerUnitsConverter.Logic;
using HammerUnitsConverter.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HammerUnitsConverter
{
    public partial class Form1 : Form
    {
        private readonly UnitConverter Converter = new UnitConverter();
        private readonly string DeveloperUrl = @"https://steamcommunity.com/id/The_Split/";
        private readonly string HelpUrl = @"https://developer.valvesoftware.com/wiki/Dimensions";
        private List<ConvertModel> History { get; set; }
        public Form1()
        {
            InitializeComponent();
            History = new List<ConvertModel>();
            historyDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            var convertModel = new ConvertModel();
            if (unitsRadioButton.Checked)
            {
                convertModel.Units = !string.IsNullOrEmpty(unitsTextBox.Text) ? float.Parse(unitsTextBox.Text) : 0;
                convertModel.Source = SourceScale.Unit;
            }
            else if (cmRadioButton.Checked)
            {
                convertModel.Cm = !string.IsNullOrEmpty(cmTextBox.Text) ? float.Parse(cmTextBox.Text) : 0;
                convertModel.Source = SourceScale.Cm;
            }
            else if (mRadioButton.Checked)
            {
                convertModel.M = !string.IsNullOrEmpty(mTextBox.Text) ? float.Parse(mTextBox.Text) : 0;
                convertModel.Source = SourceScale.M;
            }
            else if (inchesRadioButton.Checked)
            {
                convertModel.Inches = !string.IsNullOrEmpty(inchesTextBox.Text) ? float.Parse(inchesTextBox.Text) : 0;
                convertModel.Source = SourceScale.Inch;
            }
            else if (footRadioButton.Checked)
            {
                convertModel.Feet = !string.IsNullOrEmpty(footTextBox.Text) ? float.Parse(footTextBox.Text) : 0;
                convertModel.Source = SourceScale.Foot;
            }

            var result = Converter.DoConvert(convertModel);
            if (result != null)
            {
                RefreshView(result);
                if (result.Units != 0 || result.Cm != 0 || result.M != 0 || result.Inches != 0 || result.Feet != 0)
                    History.Add(result);

            }
            var bindingSource = new BindingSource();
            History.ForEach(x => bindingSource.Add(new HistoryViewModel { Units = x.Units, Cm = x.Cm, M = x.M, Inches = x.Inches, Feet = x.Feet }));
            historyDataGrid.DataSource = bindingSource;

        }
        private void RefreshView(ConvertModel result)
        {
            unitLabel.Text = result.Units.ToString();
            cmLabel.Text = result.Cm.ToString();
            mLabel.Text = result.M.ToString();
            inchLabel.Text = result.Inches.ToString();
            feetLabel.Text = result.Feet.ToString();

            unitsTextBox.Text = result.Units.ToString();
            cmTextBox.Text = result.Cm.ToString();
            mTextBox.Text = result.M.ToString();
            inchesTextBox.Text = result.Inches.ToString();
            footTextBox.Text = result.Feet.ToString();
        }
        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void unitsTextBox_Enter(object sender, EventArgs e)
        {
            unitsRadioButton.Checked = true;
        }

        private void cmTextBox_Enter(object sender, EventArgs e)
        {
            cmRadioButton.Checked = true;
        }

        private void mTextBox_Enter(object sender, EventArgs e)
        {
            mRadioButton.Checked = true;
        }

        private void inchesTextBox_Enter(object sender, EventArgs e)
        {
            inchesRadioButton.Checked = true;
        }

        private void footTextBox_Enter(object sender, EventArgs e)
        {
            footRadioButton.Checked = true;
        }

        private void saveHistory_Click(object sender, EventArgs e)
        {
            try
            {
                var list = new List<HistoryViewModel>();
                History.ForEach(x => list.Add(new HistoryViewModel { Units = x.Units, Cm = x.Cm, M = x.M, Inches = x.Inches, Feet = x.Feet }));
                var content = Converter.GenerateFile(list);
                if (content != null)
                {
                    var fileName = $"history_{DateTime.Now.ToString("ddMMyyyy")}.txt";
                    saveFileDialog1.FileName = fileName;
                    saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                            sw.WriteLine(content);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void selectedFromHistory(object sender, DataGridViewCellEventArgs e)
        {
            var row = historyDataGrid.Rows[e.RowIndex];
            var item = row.DataBoundItem as HistoryViewModel;
            RefreshView(new ConvertModel { Units = item.Units, Cm = item.Cm, M = item.M, Inches = item.Inches, Feet = item.Feet });

        }

        private void copyrightLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(DeveloperUrl);
        }

        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(HelpUrl);
        }
    }
}
