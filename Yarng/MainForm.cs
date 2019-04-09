using System;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace Yarng
{
	public partial class MainForm : Form
	{
		private readonly string
			strVowels = "aeiou",
			strConsonants = "bcdfghjklmnpqrstvwxyz";

		private string
			strVowelPool,
			strConsonantPool;

		private void ResetSettings()
		{
			strVowelPool = strVowels;
			strConsonantPool = strConsonants;
			numericNumberOfNames.Value = 10;
			numericCharacterLenghtsMin.Value = 3;
			numericCharacterLenghtsMax.Value = 10;
			textVowels.Text = strVowels;
			textConsonants.Text = strConsonants;
			comboLanguage.SelectedIndex = 0;
		}

		private void SetStatusText(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				textInfo.Text = button.AccessibleDescription;
			}
			else if (sender is Label label)
			{
				textInfo.Text = label.AccessibleDescription;
			}
			else if (sender is ComboBox comboBox)
			{
				textInfo.Text = comboBox.AccessibleDescription;
			}
			else if (sender is TextBox textBox)
			{
				textInfo.Text = textBox.AccessibleDescription;
			}
			else if (sender is ProgressBar progressBar)
			{
				textInfo.Text = progressBar.AccessibleDescription;
			}
			else if (sender is NumericUpDown numericUpDown)
			{
				textInfo.Text = numericUpDown.AccessibleDescription;
			}
		}

		private void SetStatusText(string text)
		{
			textInfo.Text = text;
		}

		private void ClearStatusText()
		{
			SetStatusText(text: "");
		}

		private void NumericCharacterLenghtsMin(object sender, MouseEventArgs e)
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
			}
			else
			{
				numericCharacterLenghtsMin.DownButton();
			}
		}

		private void NumericCharacterLenghtsMax(object sender, MouseEventArgs e)
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
			}
			else
			{
				numericCharacterLenghtsMax.DownButton();
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			ClearStatusText();
			numericCharacterLenghtsMin.MouseWheel += new MouseEventHandler(NumericCharacterLenghtsMin);
			numericCharacterLenghtsMax.MouseWheel += new MouseEventHandler(NumericCharacterLenghtsMax);
			ResetSettings();
		}

		#region Click handlers

		private void ButtonShowProbabilityTable_Click(object sender, EventArgs e)
		{																																																											
			//new ProbabilityTableForm().ShowDialog();
			ProbabilityTableForm formProbabilityTable = new ProbabilityTableForm
			{
				Consonants = textConsonants.Text,
				Vowels = textVowels.Text,
				ConsonantPool = strConsonantPool,
				VowelPool = strVowelPool
			};
			if (formProbabilityTable.ShowDialog() == DialogResult.OK)
			{
				textConsonants.Text = "";
				textConsonants.Text = formProbabilityTable.Consonants;
				textVowels.Text = formProbabilityTable.Vowels;
				strConsonantPool = formProbabilityTable.ConsonantPool;
				strVowelPool = formProbabilityTable.VowelPool;
			}
		}

		private void ButtonLoadDefaultSettings_Click(object sender, EventArgs e)
		{
			ResetSettings();
			MessageBox.Show(text: "The settings were resetted", caption: "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		private void ButtonLoadTemplate_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSaveTemplate_Click(object sender, EventArgs e)
		{
		}

		private void ButtonAbout_Click(object sender, EventArgs e)
		{
			new AboutForm().ShowDialog();
		}

		private void ButtonHistory_Click(object sender, EventArgs e)
		{
			new HistoryForm().ShowDialog();
		}

		private void ButtonHowTo_Click(object sender, EventArgs e)
		{
			new HowToForm().ShowDialog();
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
				sbName = new StringBuilder(value: ""),
				sbNames = new StringBuilder(value: "");
			bool isEven;
			if (_r.Next(minValue: 0, maxValue: 10) % 2 == 0)
			{
				isEven = true;
			}
			else
			{
				isEven = false;
			}
			textList.Clear();
			progressGenerate.Value = 0;
			progressGenerate.Maximum = (int)numericNumberOfNames.Value - 1;
			progressGenerate.Step = 1;
			for (int i = 0; i < numericNumberOfNames.Value; i++)
			{
				//progressGenerate.Value = i;
				progressGenerate.PerformStep();
				nLengthOfName = _r.Next(minValue: (int)numericCharacterLenghtsMin.Value, maxValue: (int)numericCharacterLenghtsMax.Value + 1);
				sbNames.Length = 0;
				for (int n = 0; n < nLengthOfName; n++)
				{
					if (isEven)
					{
						ch = strVowelPool[_r.Next(maxValue: strVowelPool.Length)];
					}
					else
					{
						ch = strConsonantPool[_r.Next(maxValue: strConsonantPool.Length)];
					}
					isEven = !isEven;
					if (n == 0)
					{
						ch = char.ToUpper(c: ch);
					}
					sbName.Length = 0;
					sbName.Append(value: ch);
					sbNames.Append(value: sbName);
				}
				textList.AppendText(text: sbNames.ToString());
				if (i < numericNumberOfNames.Value - 1)
				{
					textList.AppendText(text: ", \r\n");
				}
			}
		}

		private void ButtonSpeechText_Click(object sender, EventArgs e)
		{
			SpeechSynthesizer speaker = new SpeechSynthesizer();
			speaker.SetOutputToDefaultAudioDevice();
			speaker.Rate = -2;
			speaker.Volume = 100;
			if (textList.SelectionLength > 0)
			{
				speaker.SpeakAsync(textToSpeak: textList.SelectedText);
			}
			else
			{
				speaker.SpeakAsync(textToSpeak: textList.Text);
			}
		}

		private void ButtonClearList_Click(object sender, EventArgs e)
		{
			textList.Clear();
		}

		private void ButtonCopyList_Click(object sender, EventArgs e)
		{
			if (textList.Text != "")
			{
				Clipboard.SetText(text: textList.Text);
			}
		}

		private void ButtonExportList_Click(object sender, EventArgs e)
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

		#region DoubleClick handlers

		private void LabelVowels_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show(text: "vowel pool: " + strVowelPool, caption: "information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		private void LabelConsonants_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show(text: "consonant pool: " + strConsonantPool, caption: "information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
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
				MessageBox.Show(text: "The min-value mustn't be bigger than the max-value.", caption: "Warning", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
				numericCharacterLenghtsMin.Value = numericCharacterLenghtsMax.Value;
			}
		}

		private void NumericCharacterLenghtsMax_ValueChanged(object sender, EventArgs e)
		{
			if (numericCharacterLenghtsMax.Value < numericCharacterLenghtsMin.Value)
			{
				MessageBox.Show(text: "The max-value mustn't be lesser than the min-value.", caption: "Warning", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
				numericCharacterLenghtsMax.Value = numericCharacterLenghtsMin.Value;
			}
		}

		#endregion

		#region Enter handlers

		private void ButtonShowProbabilityTable_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonLoadDefaultSettings_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboLanguage_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonLoadTemplate_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonSaveTemplate_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonAbout_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonHistory_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonHowTo_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonExit_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonGenerate_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonSpeechText_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonClearList_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonCopyList_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonExportList_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonPrintList_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonStepLeft_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonStepRight_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonMirror_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonSort_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonScramble_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericNumberOfNames_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericCharacterLenghtsMin_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericCharacterLenghtsMax_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void TextVowels_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void TextConsonants_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void TextList_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		#endregion

		#region MouseEnter handers

		private void TextVowels_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void TextConsonants_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonShowProbabilityTable_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonLoadDefaultSettings_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboLanguage_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonLoadTemplate_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonSaveTemplate_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonAbout_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonHistory_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonHowTo_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonExit_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void TextList_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonGenerate_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonSpeechText_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}


		private void ButtonClearList_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonCopyList_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonExportList_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonPrintList_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonStepLeft_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonStepRight_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonMirror_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonSort_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonScramble_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		#endregion

		#region Leave handlers

		private void TextVowels_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
			if (textVowels.TextLength == 0)
			{
				MessageBox.Show(text: "The text field must include not less than one vowel.", caption: "Warning", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
				textVowels.Text = strVowels;
			}
		}

		private void TextConsonants_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
			if (textConsonants.TextLength == 0)
			{
				MessageBox.Show(text: "The text field must include not less than one consonant.", caption: "Warning", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
				textConsonants.Text = strConsonants;
			}
		}

		private void NumericNumberOfNames_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericCharacterLenghtsMin_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericCharacterLenghtsMax_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonShowProbabilityTable_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonLoadDefaultSettings_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboLanguage_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonLoadTemplate_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonSaveTemplate_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonAbout_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonHistory_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonHowTo_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonExit_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void TextList_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonGenerate_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonSpeechText_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonClearList_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonCopyList_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonExportList_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonPrintList_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonStepLeft_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonStepRight_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonMirror_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonSort_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonScramble_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		#endregion

		#region MouseLeave handlers

		private void TextVowels_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void TextConsonants_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonShowProbabilityTable_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonLoadDefaultSettings_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboLanguage_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonLoadTemplate_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonSaveTemplate_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonAbout_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonHistory_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonHowTo_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonExit_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void TextList_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonGenerate_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonSpeechText_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonClearList_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonCopyList_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonExportList_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonPrintList_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonStepLeft_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonStepRight_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonMirror_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonSort_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonScramble_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		#endregion
	}
}
