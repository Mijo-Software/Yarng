﻿using System;
using System.Globalization;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;
using Yarng.Properties;

namespace Yarng
{
	/// <summary>
	/// Main form
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Default strings
		/// </summary>
		private readonly string
			strDefaultVowels = "aeiou",
			strDefaultConsonants = "bcdfghjklmnpqrstvwxyz",
			strDefaultAlphabet = "abcdefghijklmnopqrstuvwxyz";

		/// <summary>
		/// Letter strings
		/// </summary>
		private string
			strVowelPool,
			strConsonantPool;

		/// <summary>
		/// Letter variants
		/// </summary>
		private enum Letter : byte { Consonant = 0, Vowel /*Syllable, Semivowel, DoubleConsonant, DoubleVowel*/ };

		/// <summary>
		/// Languages
		/// </summary>
		private enum LetterLanguage : byte { Default = 0, English, German, Frence, Spanish, Portuguese, Italian, Dutch, Latin, UserDefined };

		/// <summary>
		/// culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Reset the settings
		/// </summary>
		private void ResetSettings()
		{
			strVowelPool = strDefaultVowels;
			strConsonantPool = strDefaultConsonants;
			numericNumberOfNames.Value = 10;
			numericCharacterLenghtsMin.Value = 3;
			numericCharacterLenghtsMax.Value = 10;
			textVowels.Text = strDefaultVowels;
			textConsonants.Text = strDefaultConsonants;
			comboLanguage.SelectedIndex = (byte)LetterLanguage.Default;
		}

		/// <summary>
		/// Count the specific chars of the string
		/// </summary>
		/// <param name="text">text</param>
		/// <param name="chr">char to count</param>
		/// <returns>number of chars</returns>
		/// <exception cref="ArgumentException">text must not null or emtpy</exception>
		private static uint CountChar(string text, char chr = '\0')
		{
			uint tmp = 0;
			if (string.IsNullOrEmpty(value: text))
			{
				throw new ArgumentException(message: "message", paramName: nameof(text));
			}
			else
			{
				foreach (var item in text)
				{
					if (item == chr)
					{
						tmp++;
					}
				}
			}
			return tmp;
		}

		/// <summary>
		/// Get the value of a specific char from a pool
		/// </summary>
		/// <param name="chr">char</param>
		/// <returns>value of a specific char</returns>
		private byte GetValueCharfromPools(char chr = '\0')
		{
			if ((byte)CountChar(text: strConsonantPool, chr: chr) != 0)
			{
				return (byte)CountChar(text: strConsonantPool, chr: chr);
			}
			else if ((byte)CountChar(text: strVowelPool, chr: chr) != 0)
			{
				return (byte)CountChar(text: strVowelPool, chr: chr);
			}
			return 1;
		}

		/// <summary>
		/// Check if a letter as string is a vowel
		/// </summary>
		/// <param name="letter"></param>
		/// <returns>true if is a vowel</returns>
		/// <exception cref="ArgumentException">text must not null or emtpy</exception>
		private bool IsVowel(string letter)
		{
			if (string.IsNullOrEmpty(value: letter))
			{
				throw new ArgumentException(message: Strings.message, paramName: nameof(letter));
			}
			return textVowels.Text.Contains(value: letter);
		}

		/// <summary>
		/// Check if a letter as string is a consonant
		/// </summary>
		/// <param name="letter"></param>
		/// <returns>true if is a consonant</returns>
		/// <exception cref="ArgumentException">text must not null or emtpy</exception>
		private bool IsConsonant(string letter)
		{
			if (string.IsNullOrEmpty(value: letter))
			{
				throw new ArgumentException(message: Strings.message, paramName: nameof(letter));
			}
			return textConsonants.Text.Contains(value: letter);
		}

		/// <summary>
		/// Check if a letter as string is a default vowel
		/// </summary>
		/// <param name="letter"></param>
		/// <returns>true if is a default vowel</returns>
		/// <exception cref="ArgumentException">text must not null or emtpy</exception>
		private bool IsVowelDefault(string letter)
		{
			if (string.IsNullOrEmpty(value: letter))
			{
				throw new ArgumentException(message: Strings.message, paramName: nameof(letter));
			}
			return strDefaultVowels.Contains(value: letter);
		}

		/// <summary>
		/// Check if a letter as string is a default consonant
		/// </summary>
		/// <param name="letter"></param>
		/// <returns>true if is a default consonant</returns>
		/// <exception cref="ArgumentException">text must not null or emtpy</exception>
		private bool IsConsonantDefault(string letter)
		{
			if (string.IsNullOrEmpty(value: letter))
			{
				throw new ArgumentException(message: Strings.message, paramName: nameof(letter));
			}
			return strDefaultConsonants.Contains(value: letter);
		}

		/// <summary>
		/// Get the sort of a the	char
		/// </summary>
		/// <param name="letter">char</param>
		/// <returns>value</returns>
		/// <exception cref="ArgumentException">text must not null or empty</exception>
		private byte GetSortOfChar(string letter)
		{
			if (string.IsNullOrEmpty(value: letter))
			{
				throw new ArgumentException(message: Strings.message, paramName: nameof(letter));
			}
			if (IsVowel(letter: letter))
			{
				return (byte)Letter.Vowel;
			}
			else if (IsConsonant(letter: letter))
			{
				return (byte)Letter.Consonant;
			}
			else
			{
				switch (letter)
				{
					case "a": return (byte)Letter.Vowel;
					case "b":
					case "c":
					case "d": return (byte)Letter.Consonant;
					case "e": return (byte)Letter.Vowel;
					case "f":
					case "g":
					case "h": return (byte)Letter.Consonant;
					case "i": return (byte)Letter.Vowel;
					case "j":
					case "k":
					case "l":
					case "m":
					case "n": return (byte)Letter.Consonant;
					case "o": return (byte)Letter.Vowel;
					case "p":
					case "q":
					case "r":
					case "s":
					case "t": return (byte)Letter.Consonant;
					case "u": return (byte)Letter.Vowel;
					case "v":
					case "w":
					case "x":
					case "y":
					case "z": return (byte)Letter.Consonant;
				}
			}
			return (byte)Letter.Consonant;
		}

		/// <summary>
		/// ???
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		/// <exception cref="ArgumentNullException">mouse event arguments must not null</exception>
		private void NumericCharacterLenghtsMin(object sender, MouseEventArgs e)
		{
			if (e is null)
			{
				throw new ArgumentNullException(paramName: nameof(e));
			}
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

		/// <summary>
		/// ???
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		/// <exception cref="ArgumentNullException">mouse event arguments must not null</exception>
		private void NumericCharacterLenghtsMax(object sender, MouseEventArgs e)
		{
			if (e is null)
			{
				throw new ArgumentNullException(paramName: nameof(e));
			}
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

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm() => InitializeComponent();

		/// <summary>
		/// Load the main form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void MainForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar_Leave(sender: null, EventArgs.Empty);
			numericCharacterLenghtsMin.MouseWheel += NumericCharacterLenghtsMin;
			numericCharacterLenghtsMax.MouseWheel += NumericCharacterLenghtsMax;
			ResetSettings();
		}

		#region Click handlers

		/// <summary>
		/// Show the probability table form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonShowProbabilityTable_Click(object sender, EventArgs e)
		{
			using ProbabilityTableForm formProbabilityTable = new ProbabilityTableForm();
			formProbabilityTable.Consonants = textConsonants.Text;
			formProbabilityTable.Vowels = textVowels.Text;
			formProbabilityTable.ConsonantPool = strConsonantPool;
			formProbabilityTable.VowelPool = strVowelPool;
			formProbabilityTable.NumericValueCharA = GetValueCharfromPools(chr: CharacterResources.a[index: 0]);
			formProbabilityTable.NumericValueCharB = GetValueCharfromPools(chr: CharacterResources.b[index: 0]);
			formProbabilityTable.NumericValueCharC = GetValueCharfromPools(chr: CharacterResources.c[index: 0]);
			formProbabilityTable.NumericValueCharD = GetValueCharfromPools(chr: CharacterResources.d[index: 0]);
			formProbabilityTable.NumericValueCharE = GetValueCharfromPools(chr: CharacterResources.e[index: 0]);
			formProbabilityTable.NumericValueCharF = GetValueCharfromPools(chr: CharacterResources.f[index: 0]);
			formProbabilityTable.NumericValueCharG = GetValueCharfromPools(chr: CharacterResources.g[index: 0]);
			formProbabilityTable.NumericValueCharH = GetValueCharfromPools(chr: CharacterResources.h[index: 0]);
			formProbabilityTable.NumericValueCharI = GetValueCharfromPools(chr: CharacterResources.i[index: 0]);
			formProbabilityTable.NumericValueCharJ = GetValueCharfromPools(chr: CharacterResources.j[index: 0]);
			formProbabilityTable.NumericValueCharK = GetValueCharfromPools(chr: CharacterResources.k[index: 0]);
			formProbabilityTable.NumericValueCharL = GetValueCharfromPools(chr: CharacterResources.l[index: 0]);
			formProbabilityTable.NumericValueCharM = GetValueCharfromPools(chr: CharacterResources.m[index: 0]);
			formProbabilityTable.NumericValueCharN = GetValueCharfromPools(chr: CharacterResources.n[index: 0]);
			formProbabilityTable.NumericValueCharO = GetValueCharfromPools(chr: CharacterResources.o[index: 0]);
			formProbabilityTable.NumericValueCharP = GetValueCharfromPools(chr: CharacterResources.p[index: 0]);
			formProbabilityTable.NumericValueCharQ = GetValueCharfromPools(chr: CharacterResources.q[index: 0]);
			formProbabilityTable.NumericValueCharR = GetValueCharfromPools(chr: CharacterResources.r[index: 0]);
			formProbabilityTable.NumericValueCharS = GetValueCharfromPools(chr: CharacterResources.s[index: 0]);
			formProbabilityTable.NumericValueCharT = GetValueCharfromPools(chr: CharacterResources.t[index: 0]);
			formProbabilityTable.NumericValueCharU = GetValueCharfromPools(chr: CharacterResources.u[index: 0]);
			formProbabilityTable.NumericValueCharV = GetValueCharfromPools(chr: CharacterResources.v[index: 0]);
			formProbabilityTable.NumericValueCharW = GetValueCharfromPools(chr: CharacterResources.w[index: 0]);
			formProbabilityTable.NumericValueCharX = GetValueCharfromPools(chr: CharacterResources.x[index: 0]);
			formProbabilityTable.NumericValueCharY = GetValueCharfromPools(chr: CharacterResources.y[index: 0]);
			formProbabilityTable.NumericValueCharZ = GetValueCharfromPools(chr: CharacterResources.z[index: 0]);
			formProbabilityTable.SortOfCharA = GetSortOfChar(letter: CharacterResources.a);
			formProbabilityTable.SortOfCharB = GetSortOfChar(letter: CharacterResources.b);
			formProbabilityTable.SortOfCharC = GetSortOfChar(letter: CharacterResources.c);
			formProbabilityTable.SortOfCharD = GetSortOfChar(letter: CharacterResources.d);
			formProbabilityTable.SortOfCharE = GetSortOfChar(letter: CharacterResources.e);
			formProbabilityTable.SortOfCharF = GetSortOfChar(letter: CharacterResources.f);
			formProbabilityTable.SortOfCharG = GetSortOfChar(letter: CharacterResources.g);
			formProbabilityTable.SortOfCharH = GetSortOfChar(letter: CharacterResources.h);
			formProbabilityTable.SortOfCharI = GetSortOfChar(letter: CharacterResources.i);
			formProbabilityTable.SortOfCharJ = GetSortOfChar(letter: CharacterResources.j);
			formProbabilityTable.SortOfCharK = GetSortOfChar(letter: CharacterResources.k);
			formProbabilityTable.SortOfCharL = GetSortOfChar(letter: CharacterResources.l);
			formProbabilityTable.SortOfCharM = GetSortOfChar(letter: CharacterResources.m);
			formProbabilityTable.SortOfCharN = GetSortOfChar(letter: CharacterResources.n);
			formProbabilityTable.SortOfCharO = GetSortOfChar(letter: CharacterResources.o);
			formProbabilityTable.SortOfCharP = GetSortOfChar(letter: CharacterResources.p);
			formProbabilityTable.SortOfCharQ = GetSortOfChar(letter: CharacterResources.q);
			formProbabilityTable.SortOfCharR = GetSortOfChar(letter: CharacterResources.r);
			formProbabilityTable.SortOfCharS = GetSortOfChar(letter: CharacterResources.s);
			formProbabilityTable.SortOfCharT = GetSortOfChar(letter: CharacterResources.t);
			formProbabilityTable.SortOfCharU = GetSortOfChar(letter: CharacterResources.u);
			formProbabilityTable.SortOfCharV = GetSortOfChar(letter: CharacterResources.v);
			formProbabilityTable.SortOfCharW = GetSortOfChar(letter: CharacterResources.w);
			formProbabilityTable.SortOfCharX = GetSortOfChar(letter: CharacterResources.x);
			formProbabilityTable.SortOfCharY = GetSortOfChar(letter: CharacterResources.y);
			formProbabilityTable.SortOfCharZ = GetSortOfChar(letter: CharacterResources.z);
			if (formProbabilityTable.ShowDialog() == DialogResult.OK)
			{
				textConsonants.Text = formProbabilityTable.Consonants;
				textVowels.Text = formProbabilityTable.Vowels;
				strConsonantPool = formProbabilityTable.ConsonantPool;
				strVowelPool = formProbabilityTable.VowelPool;
				comboLanguage.SelectedIndex = (byte)LetterLanguage.UserDefined;
			}
		}

		/// <summary>
		/// Load the default settings
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonLoadDefaultSettings_Click(object sender, EventArgs e)
		{
			ResetSettings();
			MessageBox.Show(text: Strings.settingsResetted, caption: Strings.information, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// Load a specific template
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonLoadTemplate_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Savea specific template
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonSaveTemplate_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Open the about form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonAbout_Click(object sender, EventArgs e)
		{
			using AboutForm about = new AboutForm();
			about.ShowDialog();
		}

		/// <summary>
		/// Open the history form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonHistory_Click(object sender, EventArgs e)
		{
			using HistoryForm history = new HistoryForm();
			history.ShowDialog();
		}

		/// <summary>
		/// Open the howTo form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonHowTo_Click(object sender, EventArgs e)
		{
			using HowToForm how = new HowToForm();
			how.ShowDialog();
		}

		/// <summary>
		/// Exit the application
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonExit_Click(object sender, EventArgs e) => Close();

		/// <summary>
		/// Generate the name list
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonGenerate_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			StringBuilder
				sbName = new StringBuilder(value: ""),
				sbNames = new StringBuilder(value: "");
			bool isEven = random.Next(minValue: 0, maxValue: 10) % 2 == 0;
			textList.Clear();
			progressGenerate.Value = 0;
			progressGenerate.Maximum = (int)numericNumberOfNames.Value - 1;
			progressGenerate.Step = 1;
			for (int i = 0; i < numericNumberOfNames.Value; i++)
			{
				//progressGenerate.Value = i;
				progressGenerate.PerformStep();
				int nLengthOfName = random.Next(minValue: (int)numericCharacterLenghtsMin.Value, maxValue: (int)numericCharacterLenghtsMax.Value + 1);
				sbNames.Length = 0;
				for (int n = 0; n < nLengthOfName; n++)
				{
					char chr = isEven
						? strVowelPool[index: random.Next(maxValue: strVowelPool.Length)]
						: strConsonantPool[index: random.Next(maxValue: strConsonantPool.Length)];
					isEven = !isEven;
					if (n == 0)
					{
						chr = char.ToUpper(c: chr, culture: culture);
					}
					sbName.Length = 0;
					sbName.Append(value: chr);
					sbNames.Append(value: sbName);
				}
				textList.AppendText(text: sbNames.ToString());
				if (i < numericNumberOfNames.Value - 1)
				{
					textList.AppendText(text: Strings.commaSpaceEnter);
				}
			}
		}

		/// <summary>
		/// Speech the name list
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonSpeechText_Click(object sender, EventArgs e)
		{
			using SpeechSynthesizer speaker = new SpeechSynthesizer();
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

		/// <summary>
		/// Clear the name list
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonClearList_Click(object sender, EventArgs e) => textList.Clear();

		/// <summary>
		/// Copy the name list to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonCopyList_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textList.Text))
			{
				Clipboard.SetText(text: textList.Text);
			}
		}

		/// <summary>
		/// Export the name list
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonExportList_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 
		/// </summary>Print the name list
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonPrintList_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Step left
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonStepLeft_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Step right
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonStepRight_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Mirror
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonMirror_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Sort
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonSort_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Scramble
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void ButtonScramble_Click(object sender, EventArgs e)
		{
		}

		#endregion

		#region DoubleClick handlers

		/// <summary>
		/// Show the vowel pool
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void LabelVowels_DoubleClick(object sender, EventArgs e) => MessageBox.Show(text: $"vowel pool: {strVowelPool}", caption: Strings.information, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		/// <summary>
		/// Show the consonant pool
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void LabelConsonants_DoubleClick(object sender, EventArgs e) => MessageBox.Show(text: $"consonant pool: {strConsonantPool}", caption: Strings.information, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

		#endregion

		#region ValueChanged handlers

		/// <summary>
		/// ???
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void NumericNumberOfNames_ValueChanged(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// ??
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void NumericCharacterLenghtsMin_ValueChanged(object sender, EventArgs e)
		{
			if (numericCharacterLenghtsMin.Value > numericCharacterLenghtsMax.Value)
			{
				MessageBox.Show(text: Strings.minValueMustBigger, caption: Strings.warning, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
				numericCharacterLenghtsMin.Value = numericCharacterLenghtsMax.Value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void NumericCharacterLenghtsMax_ValueChanged(object sender, EventArgs e)
		{
			if (numericCharacterLenghtsMax.Value < numericCharacterLenghtsMin.Value)
			{
				MessageBox.Show(text: Strings.maxValueMustLesser, caption: Strings.warning, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
				numericCharacterLenghtsMax.Value = numericCharacterLenghtsMin.Value;
			}
		}

		#endregion

		#region Enter handlers

		/// <summary>
		/// Set the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e) => toolStripStatusLabel.Text = ((Control)sender).AccessibleDescription;

		/// <summary>
		/// Set the information text of a ToolStripMenuItem in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbarOfToolStripMenuItem_Enter(object sender, EventArgs e) => toolStripStatusLabel.Text = ((ToolStripMenuItem)sender).AccessibleDescription;

		#endregion

		#region Leave handlers

		/// <summary>
		/// Clear the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => toolStripStatusLabel.Text = string.Empty;

		/// <summary>
		/// Clear the information text in the status bar while check if the text box of vowels is not empty
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextVowels_Leave(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = string.Empty;
			if (textVowels.TextLength == 0)
			{
				MessageBox.Show(text: Strings.mustHaveVowels, caption: Strings.warning, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
				textVowels.Text = strDefaultVowels;
			}
		}

		/// <summary>
		/// Clear the information text in the status bar while check if the text box of consonants is not empty
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextConsonants_Leave(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = string.Empty;
			if (textConsonants.TextLength == 0)
			{
				MessageBox.Show(text: Strings.mustHaveConsonants, Strings.warning, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
				textConsonants.Text = strDefaultConsonants;
			}
		}

		#endregion

		#region SelectedIndexChanged handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ComboLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboLanguage.SelectedIndex)
			{
				default:
				{
					strVowelPool = strDefaultVowels;
					strConsonantPool = strDefaultConsonants;
					break;
				}
				case (byte)LetterLanguage.English:
				{
					int[] arrLanguageValueEnglish = { 11, 2, 2, 6, 13, 2, 2, 9, 6, 1, 1, 3, 3, 7, 7, 1, 0, 5, 6, 9, 2, 1, 2, 0, 2, 0 };
					strConsonantPool = "";
					strVowelPool = "";
					for (int n = 0; n < arrLanguageValueEnglish.Length; n++)
					{
						MessageBox.Show(n.ToString());
						for (int i = 0; i < arrLanguageValueEnglish[n]; i++)
						{
							if (IsVowelDefault(strDefaultAlphabet[index: i].ToString()))
							{
								strVowelPool += strDefaultAlphabet[index: i];
							}
							else if (IsConsonantDefault(strDefaultAlphabet[index: i].ToString()))
							{
							strConsonantPool += strDefaultAlphabet[index: i];
							}
						}
					}
					break;
				}
				case (byte)LetterLanguage.German:
				{
					strConsonantPool = "";
					strVowelPool = "";
					break;
				}
				case (byte)LetterLanguage.Frence:
				{
					strConsonantPool = "";
					strVowelPool = "";
					break;
				}
				case (byte)LetterLanguage.Spanish:
				{
					strConsonantPool = "";
					strVowelPool = "";
					break;
				}
				case (byte)LetterLanguage.Portuguese:
				{
					strConsonantPool = "";
					strVowelPool = "";
					break;
				}
				case (byte)LetterLanguage.Italian:
				{
					strConsonantPool = "";
					strVowelPool = "";
					break;
				}
				case (byte)LetterLanguage.Dutch:
				{
					strConsonantPool = "";
					strVowelPool = "";
					break;
				}
				case (byte)LetterLanguage.Latin:
				{
					strConsonantPool = "";
					strVowelPool = "";
					break;
				}
			}
		}

		#endregion

	}
}
