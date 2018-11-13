using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yarng
{
    public partial class MainForm : Form
    {
        static string
            strVowels = "aeiou",
            strConsonants = "bcdfghjklmnpqrstvwxyz",
            strAlphabet = strVowels + strConsonants;

        private void resetSettings()
        {
            numericNumberOfNames.Value = 10;
            numericCharacterLenghtsMin.Value = 3;
            numericCharacterLenghtsMax.Value = 10;
            textVowels.Text = strVowels;
            textConsonants.Text = strConsonants;
            comboLanguage.SelectedIndex = 0;
        }

        private void mwcNumericCharacterLenghtsMin(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            bool up = true;
            int wheelDelta = 0;
            wheelDelta += e.Delta;
            if (wheelDelta < 0) up = false;
            if (up)
            {
                numericCharacterLenghtsMin.UpButton();
            } else {
                numericCharacterLenghtsMin.DownButton();
            }
        }

        private void mwcNumericCharacterLenghtsMax(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            bool up = true;
            int wheelDelta = 0;
            wheelDelta += e.Delta;
            if (wheelDelta < 0) up = false;
            if (up)
            {
                numericCharacterLenghtsMax.UpButton();
            } else {
                numericCharacterLenghtsMax.DownButton();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            numericCharacterLenghtsMin.MouseWheel += new MouseEventHandler(mwcNumericCharacterLenghtsMin);
            numericCharacterLenghtsMax.MouseWheel += new MouseEventHandler(mwcNumericCharacterLenghtsMax);
            this.resetSettings();
        }

        private void buttonShowProbabilityTable_Click(object sender, EventArgs e)
        {
            ProbabilityTableForm formProbabilityTable = new ProbabilityTableForm();
            formProbabilityTable.ShowDialog();
        }

        private void buttonLoadDefaultSettings_Click(object sender, EventArgs e)
        {
            this.resetSettings();
            MessageBox.Show("The settings were resetted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLoadTemplate_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveTemplate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {

        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {

        }

        private void buttonHowTo_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int nLengthOfName;
            char ch;
            Random _r = new Random();
            StringBuilder
                sbName = new StringBuilder(""),
                sbNames = new StringBuilder("");
            bool isEven;
            if (_r.Next(0, 10) % 2 == 0)
            {
                isEven = true;
            } else {
                isEven = false;
            }
            textList.Clear();
            progressGenerate.Value = 0;
            progressGenerate.Maximum = (int)numericNumberOfNames.Value - 1;
            //progressGenerate.Step = 1;
            for (int i = 0; i < numericNumberOfNames.Value; i++)
            {
                progressGenerate.Value = i;
                //progressGenerate.PerformStep();
                nLengthOfName = _r.Next((int)numericCharacterLenghtsMin.Value, (int)numericCharacterLenghtsMax.Value + 1);
                sbNames.Length = 0;
                for (int n = 0; n < nLengthOfName; n++)
                {
                    if (isEven)
                    {
                        ch = textVowels.Text[_r.Next(textVowels.TextLength)];
                    } else {
                        ch = textConsonants.Text[_r.Next(textConsonants.TextLength)];
                    }
                    isEven = !isEven;
                    if (n == 0) ch = Char.ToUpper(ch);
                    sbName.Length = 0;
                    sbName.Append(ch);
                    sbNames.Append(sbName);
                }
                textList.AppendText(sbNames.ToString());
                if (i < numericNumberOfNames.Value - 1) textList.AppendText(", \r\n");
            }
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {

        }

        private void buttonCopyList_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportList_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrintList_Click(object sender, EventArgs e)
        {

        }

        private void buttonStepLeft_Click(object sender, EventArgs e)
        {

        }

        private void buttonStepRight_Click(object sender, EventArgs e)
        {

        }

        private void buttonMirror_Click(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }

        private void buttonScramble_Click(object sender, EventArgs e)
        {

        }

        private void numericNumberOfNames_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericCharacterLenghtsMin_ValueChanged(object sender, EventArgs e)
        {
            if (numericCharacterLenghtsMin.Value > numericCharacterLenghtsMax.Value)
            {
                MessageBox.Show("The min-value mustn't be bigger than the max-value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numericCharacterLenghtsMin.Value = numericCharacterLenghtsMax.Value;
            }
        }

        private void numericCharacterLenghtsMax_ValueChanged(object sender, EventArgs e)
        {
            if (numericCharacterLenghtsMax.Value < numericCharacterLenghtsMin.Value)
            {
                MessageBox.Show("The max-value mustn't be lesser than the min-value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numericCharacterLenghtsMax.Value = numericCharacterLenghtsMin.Value;
            }
        }

        private void textVowels_Leave(object sender, EventArgs e)
        {
            if (textVowels.TextLength == 0)
            {
                MessageBox.Show("The text field must include not less than one vowel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textVowels.Text = strVowels;
            }
        }

        private void textConsonants_Leave(object sender, EventArgs e)
        {
            if (textConsonants.TextLength == 0)
            {
                MessageBox.Show("The text field must include not less than one consonant.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textConsonants.Text = strConsonants;
            }
        }


    }
}
