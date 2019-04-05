using System;
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

		private void ResetSettings()
		{
			numericNumberOfNames.Value = 10;
			numericCharacterLenghtsMin.Value = 3;
			numericCharacterLenghtsMax.Value = 10;
			textVowels.Text = strVowels;
			textConsonants.Text = strConsonants;
			comboLanguage.SelectedIndex = 0;
		}

		private void MwcNumericCharacterLenghtsMin(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;
			bool up = true;
			if (e.Delta < 0)
			{
				up = false;
			}
			if (up)
			{
				numericCharacterLenghtsMin.UpButton();
			} else {
				numericCharacterLenghtsMin.DownButton();
			}
		}

		private void MwcNumericCharacterLenghtsMax(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;
			bool up = true;
			if (e.Delta < 0)
			{
				up = false;
			}
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
			numericCharacterLenghtsMin.MouseWheel += new MouseEventHandler(MwcNumericCharacterLenghtsMin);
			numericCharacterLenghtsMax.MouseWheel += new MouseEventHandler(MwcNumericCharacterLenghtsMax);
			this.ResetSettings();
		}

		#region Click handlers

		private void ButtonShowProbabilityTable_Click(object sender, EventArgs e)
		{
			ProbabilityTableForm formProbabilityTable = new ProbabilityTableForm();
			formProbabilityTable.ShowDialog();
		}

		private void ButtonLoadDefaultSettings_Click(object sender, EventArgs e)
		{
			ResetSettings();
			MessageBox.Show("The settings were resetted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ButtonLoadTemplate_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSaveTemplate_Click(object sender, EventArgs e)
		{
		}

		private void ButtonAbout_Click(object sender, EventArgs e)
		{
		}

		private void ButtonHistory_Click(object sender, EventArgs e)
		{
		}

		private void ButtonHowTo_Click(object sender, EventArgs e)
		{
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Close();
	  }

		private void ButtonGenerate_Click(object sender, EventArgs e)
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
					if (n == 0)
					{
						ch = Char.ToUpper(ch);
					}
					sbName.Length = 0;
					sbName.Append(ch);
					sbNames.Append(sbName);
				}
				textList.AppendText(sbNames.ToString());
				if (i < numericNumberOfNames.Value - 1)
				{
					textList.AppendText(", \r\n");
				}
			}
		}

		private void ButtonClearList_Click(object sender, EventArgs e)
		{
		}

		private void ButtonCopyList_Click(object sender, EventArgs e)
		{
		}

		private void buttonExportList_Click(object sender, EventArgs e)
		{
		}

		private void ButtonPrintList_Click(object sender, EventArgs e)
		{
		}

		private void ButtonStepLeft_Click(object sender, EventArgs e)
		{
		}

		private void ButtonStepRight_Click(object sender, EventArgs e)
		{
		}

		private void ButtonMirror_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSort_Click(object sender, EventArgs e)
		{
		}

		private void ButtonScramble_Click(object sender, EventArgs e)
		{
		}

		#endregion

		#region ValueChanged handlers

		private void NumericNumberOfNames_ValueChanged(object sender, EventArgs e)
		{
		}

		private void NumericCharacterLenghtsMin_ValueChanged(object sender, EventArgs e)
		{
			if (numericCharacterLenghtsMin.Value > numericCharacterLenghtsMax.Value)
			{
				MessageBox.Show("The min-value mustn't be bigger than the max-value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numericCharacterLenghtsMin.Value = numericCharacterLenghtsMax.Value;
			}
		}

		private void NumericCharacterLenghtsMax_ValueChanged(object sender, EventArgs e)
		{
			if (numericCharacterLenghtsMax.Value < numericCharacterLenghtsMin.Value)
			{
				MessageBox.Show("The max-value mustn't be lesser than the min-value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numericCharacterLenghtsMax.Value = numericCharacterLenghtsMin.Value;
			}
		}

		#endregion

		#region Enter handlers

		private void ButtonShowProbabilityTable_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonLoadDefaultSettings_Enter(object sender, EventArgs e)
		{
		}

		private void ComboLanguage_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonLoadTemplate_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonSaveTemplate_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonAbout_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonHistory_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonHowTo_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonExit_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonGenerate_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonClearList_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonCopyList_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonExportList_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonPrintList_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonStepLeft_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonStepRight_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonMirror_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonSort_Enter(object sender, EventArgs e)
		{
		}

		private void ButtonScramble_Enter(object sender, EventArgs e)
		{
		}

		private void NumericNumberOfNames_Enter(object sender, EventArgs e)
		{
		}

		private void NumericCharacterLenghtsMin_Enter(object sender, EventArgs e)
		{
		}

		private void NumericCharacterLenghtsMax_Enter(object sender, EventArgs e)
		{
		}

		private void TextVowels_Enter(object sender, EventArgs e)
		{
		}

		private void TextConsonants_Enter(object sender, EventArgs e)
		{
		}

		private void TextList_Enter(object sender, EventArgs e)
		{
		}

		#endregion

		#region MouseEnter handers

		private void TextVowels_MouseEnter(object sender, EventArgs e)
		{
		}

		private void TextConsonants_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonShowProbabilityTable_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonLoadDefaultSettings_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ComboLanguage_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonLoadTemplate_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonSaveTemplate_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonAbout_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonHistory_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonHowTo_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonExit_MouseEnter(object sender, EventArgs e)
		{
		}

		private void TextList_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonGenerate_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonClearList_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonCopyList_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonExportList_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonPrintList_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonStepLeft_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonStepRight_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonMirror_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonSort_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonScramble_MouseEnter(object sender, EventArgs e)
		{
		}

		#endregion

		#region Leave handlers

		private void TextVowels_Leave(object sender, EventArgs e)
		{
			if (textVowels.TextLength == 0)
			{
				MessageBox.Show("The text field must include not less than one vowel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textVowels.Text = strVowels;
			}
		}

		private void TextConsonants_Leave(object sender, EventArgs e)
		{
			if (textConsonants.TextLength == 0)
			{
				MessageBox.Show("The text field must include not less than one consonant.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textConsonants.Text = strConsonants;
			}
		}

		private void NumericNumberOfNames_Leave(object sender, EventArgs e)
		{
		}

		private void NumericCharacterLenghtsMin_Leave(object sender, EventArgs e)
		{
		}

		private void NumericCharacterLenghtsMax_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonShowProbabilityTable_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonLoadDefaultSettings_Leave(object sender, EventArgs e)
		{
		}

		private void ComboLanguage_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonLoadTemplate_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonSaveTemplate_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonAbout_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonHistory_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonHowTo_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonExit_Leave(object sender, EventArgs e)
		{
		}

		private void TextList_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonGenerate_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonClearList_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonCopyList_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonExportList_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonPrintList_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonStepLeft_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonStepRight_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonMirror_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonSort_Leave(object sender, EventArgs e)
		{
		}

		private void ButtonScramble_Leave(object sender, EventArgs e)
		{
		}

		#endregion

		#region MouseLeave handlers

		private void TextVowels_MouseLeave(object sender, EventArgs e)
		{
		}

		private void TextConsonants_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonShowProbabilityTable_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonLoadDefaultSettings_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ComboLanguage_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonLoadTemplate_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonSaveTemplate_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonAbout_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonHistory_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonHowTo_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonExit_MouseLeave(object sender, EventArgs e)
		{
		}

		private void TextList_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonGenerate_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonClearList_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonCopyList_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonExportList_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonPrintList_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonStepLeft_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonStepRight_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonMirror_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonSort_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonScramble_MouseLeave(object sender, EventArgs e)
		{
		}

		#endregion
	}
}
