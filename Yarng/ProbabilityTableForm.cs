using System;
using System.Globalization;
using System.Windows.Forms;
using Yarng.Properties;

namespace Yarng
{
	/// <summary>
	/// ProbabilityTableForm
	/// </summary>
	internal partial class ProbabilityTableForm : Form
	{
		/// <summary>
		/// True if all char labels are able to uodate
		/// </summary>
		private bool isUpdatePercentLabels = true;

		/// <summary>
		/// Sum of all chararcters
		/// </summary>
		private uint sumChars;

		/// <summary>
		/// strings
		/// </summary>
		private string strConsonants, strConsonantPool, strVowels, strVowelPool;

		/// <summary>
		/// Culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Letter types
		/// </summary>
		private enum Letter : byte { Consonant = 0, Vowel /*Syllable, Semivowel, DoubleConsonant, DoubleVowel*/ }

		/// <summary>
		/// Consonants
		/// </summary>
		public string Consonants
		{
			get => strConsonants;
			set => strConsonants = value;
		}

		/// <summary>
		/// Vowels
		/// </summary>
		public string Vowels
		{
			get => strVowels;
			set => strVowels = value;
		}

		/// <summary>
		/// ConsonantPool
		/// </summary>
		public string ConsonantPool
		{
			get => strConsonantPool;
			set => strConsonantPool = value;
		}

		/// <summary>
		/// VowelPool
		/// </summary>
		public string VowelPool
		{
			get => strVowelPool;
			set => strVowelPool = value;
		}

		/// <summary>
		/// value of the character A
		/// </summary>
		public byte NumericValueCharA
		{
			//get => (byte)numericUpDownCharA.Value;
			set => numericUpDownCharA.Value = value;
		}

		/// <summary>
		/// value of the character B
		/// </summary>
		public byte NumericValueCharB
		{
			//get => (byte)numericUpDownCharB.Value;
			set => numericUpDownCharB.Value = value;
		}

		/// <summary>
		/// value of the character C
		/// </summary>
		public byte NumericValueCharC
		{
			//get => (byte)numericUpDownCharC.Value;
			set => numericUpDownCharC.Value = value;
		}

		/// <summary>
		/// value of the character D
		/// </summary>
		public byte NumericValueCharD
		{
			//get => (byte)numericUpDownCharD.Value;
			set => numericUpDownCharD.Value = value;
		}

		/// <summary>
		/// value of the character E
		/// </summary>
		public byte NumericValueCharE
		{
			//get => (byte)numericUpDownCharE.Value;
			set => numericUpDownCharE.Value = value;
		}

		/// <summary>
		/// value of the character F
		/// </summary>
		public byte NumericValueCharF
		{
			//get => (byte)numericUpDownCharF.Value;
			set => numericUpDownCharF.Value = value;
		}

		/// <summary>
		/// value of the character G
		/// </summary>
		public byte NumericValueCharG
		{
			//get => (byte)numericUpDownCharG.Value;
			set => numericUpDownCharG.Value = value;
		}

		/// <summary>
		/// value of the character F
		/// </summary>
		public byte NumericValueCharH
		{
			//get => (byte)numericUpDownCharH.Value;
			set => numericUpDownCharH.Value = value;
		}

		/// <summary>
		/// value of the character I
		/// </summary>
		public byte NumericValueCharI
		{
			//get => (byte)numericUpDownCharI.Value;
			set => numericUpDownCharI.Value = value;
		}

		/// <summary>
		/// value of the character J
		/// </summary>
		public byte NumericValueCharJ
		{
			//get => (byte)numericUpDownCharJ.Value;
			set => numericUpDownCharJ.Value = value;
		}

		/// <summary>
		/// value of the character K
		/// </summary>
		public byte NumericValueCharK
		{
			//get => (byte)numericUpDownCharK.Value;
			set => numericUpDownCharK.Value = value;
		}

		/// <summary>
		/// value of the character L
		/// </summary>
		public byte NumericValueCharL
		{
			//get => (byte)numericUpDownCharL.Value;
			set => numericUpDownCharL.Value = value;
		}

		/// <summary>
		/// value of the character M
		/// </summary>
		public byte NumericValueCharM
		{
			//get => (byte)numericUpDownCharM.Value;
			set => numericUpDownCharM.Value = value;
		}

		/// <summary>
		/// value of the character N
		/// </summary>
		public byte NumericValueCharN
		{
			//get => (byte)numericUpDownCharN.Value;
			set => numericUpDownCharN.Value = value;
		}

		/// <summary>
		/// value of the character O
		/// </summary>
		public byte NumericValueCharO
		{
			//get => (byte)numericUpDownCharO.Value;
			set => numericUpDownCharO.Value = value;
		}

		/// <summary>
		/// value of the character P
		/// </summary>
		public byte NumericValueCharP
		{
			//get => (byte)numericUpDownCharP.Value;
			set => numericUpDownCharP.Value = value;
		}

		/// <summary>
		/// value of the character Q
		/// </summary>
		public byte NumericValueCharQ
		{
			//get => (byte)numericUpDownCharQ.Value;
			set => numericUpDownCharQ.Value = value;
		}

		/// <summary>
		/// value of the character R
		/// </summary>
		public byte NumericValueCharR
		{
			//get => (byte)numericUpDownCharR.Value;
			set => numericUpDownCharR.Value = value;
		}

		/// <summary>
		/// value of the character S
		/// </summary>
		public byte NumericValueCharS
		{
			//get => (byte)numericUpDownCharS.Value;
			set => numericUpDownCharS.Value = value;
		}

		/// <summary>
		/// value of the character T
		/// </summary>
		public byte NumericValueCharT
		{
			//get => (byte)numericUpDownCharT.Value;
			set => numericUpDownCharT.Value = value;
		}

		/// <summary>
		/// value of the character U
		/// </summary>
		public byte NumericValueCharU
		{
			//get => (byte)numericUpDownCharU.Value;
			set => numericUpDownCharU.Value = value;
		}

		/// <summary>
		/// value of the character V
		/// </summary>
		public byte NumericValueCharV
		{
			//get => (byte)numericUpDownCharV.Value;
			set => numericUpDownCharV.Value = value;
		}

		/// <summary>
		/// value of the character W
		/// </summary>
		public byte NumericValueCharW
		{
			//get => (byte)numericUpDownCharW.Value;
			set => numericUpDownCharW.Value = value;
		}

		/// <summary>
		/// value of the character X
		/// </summary>
		public byte NumericValueCharX
		{
			//get => (byte)numericUpDownCharX.Value;
			set => numericUpDownCharX.Value = value;
		}

		/// <summary>
		/// value of the character Y
		/// </summary>
		public byte NumericValueCharY
		{
			//get => (byte)numericUpDownCharY.Value;
			set => numericUpDownCharY.Value = value;
		}

		/// <summary>
		/// value of the character Z
		/// </summary>
		public byte NumericValueCharZ
		{
			get => (byte)numericUpDownCharZ.Value;
			set => numericUpDownCharZ.Value = value;
		}

		/// <summary>
		/// sort of the character A
		/// </summary>
		public byte SortOfCharA
		{
			//get => (byte)comboBoxCharA.SelectedIndex;
			set => comboBoxCharA.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character B
		/// </summary>
		public byte SortOfCharB
		{
			//get => (byte)comboBoxCharB.SelectedIndex;
			set => comboBoxCharB.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character C
		/// </summary>
		public byte SortOfCharC
		{
			//get => (byte)comboBoxCharC.SelectedIndex;
			set => comboBoxCharC.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character D
		/// </summary>
		public byte SortOfCharD
		{
			//get => (byte)comboBoxCharD.SelectedIndex;
			set => comboBoxCharD.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character E
		/// </summary>
		public byte SortOfCharE
		{
			//get => (byte)comboBoxCharE.SelectedIndex;
			set => comboBoxCharE.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character F
		/// </summary>
		public byte SortOfCharF
		{
			//get => (byte)comboBoxCharF.SelectedIndex;
			set => comboBoxCharF.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character G
		/// </summary>
		public byte SortOfCharG
		{
			//get => (byte)comboBoxCharG.SelectedIndex;
			set => comboBoxCharG.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character H
		/// </summary>
		public byte SortOfCharH
		{
			//get => (byte)comboBoxCharH.SelectedIndex;
			set => comboBoxCharH.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character I
		/// </summary>
		public byte SortOfCharI
		{
			//get => (byte)comboBoxCharI.SelectedIndex;
			set => comboBoxCharI.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character J
		/// </summary>
		public byte SortOfCharJ
		{
			//get => (byte)comboBoxCharJ.SelectedIndex;
			set => comboBoxCharJ.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character K
		/// </summary>
		public byte SortOfCharK
		{
			//get => (byte)comboBoxCharK.SelectedIndex;
			set => comboBoxCharK.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character L
		/// </summary>
		public byte SortOfCharL
		{
			//get => (byte)comboBoxCharL.SelectedIndex;
			set => comboBoxCharL.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character M
		/// </summary>
		public byte SortOfCharM
		{
			//get => (byte)comboBoxCharM.SelectedIndex;
			set => comboBoxCharM.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character N
		/// </summary>
		public byte SortOfCharN
		{
			//get => (byte)comboBoxCharN.SelectedIndex;
			set => comboBoxCharN.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character O
		/// </summary>
		public byte SortOfCharO
		{
			//get => (byte)comboBoxCharO.SelectedIndex;
			set => comboBoxCharO.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character P
		/// </summary>
		public byte SortOfCharP
		{
			//get => (byte)comboBoxCharP.SelectedIndex;
			set => comboBoxCharP.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character Q
		/// </summary>
		public byte SortOfCharQ
		{
			//get => (byte)comboBoxCharQ.SelectedIndex;
			set => comboBoxCharQ.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character R
		/// </summary>
		public byte SortOfCharR
		{
			//get => (byte)comboBoxCharR.SelectedIndex;
			set => comboBoxCharR.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character S
		/// </summary>
		public byte SortOfCharS
		{
			//get => (byte)comboBoxCharS.SelectedIndex;
			set => comboBoxCharS.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character T
		/// </summary>
		public byte SortOfCharT
		{
			//get => (byte)comboBoxCharT.SelectedIndex;
			set => comboBoxCharT.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character U
		/// </summary>
		public byte SortOfCharU
		{
			//get => (byte)comboBoxCharU.SelectedIndex;
			set => comboBoxCharU.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character V
		/// </summary>
		public byte SortOfCharV
		{
			//get => (byte)comboBoxCharV.SelectedIndex;
			set => comboBoxCharV.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character W
		/// </summary>
		public byte SortOfCharW
		{
			//get => (byte)comboBoxCharW.SelectedIndex;
			set => comboBoxCharW.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character X
		/// </summary>
		public byte SortOfCharX
		{
			//get => (byte)comboBoxCharX.SelectedIndex;
			set => comboBoxCharX.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character Y
		/// </summary>
		public byte SortOfCharY
		{
			//get => (byte)comboBoxCharY.SelectedIndex;
			set => comboBoxCharY.SelectedIndex = value;
		}

		/// <summary>
		/// sort of the character Z
		/// </summary>
		public byte SortOfCharZ
		{
			//get => (byte)comboBoxCharZ.SelectedIndex;
			set => comboBoxCharZ.SelectedIndex = value;
		}

		/// <summary>
		/// Copy to clipboard
		/// </summary>
		/// <param name="text">text to copy</param>
		/// <param name="showMessage">true if show a message</param>
		private static void CopyToClipboard(string text, bool showMessage = false)
		{
			if (string.IsNullOrWhiteSpace(value: text))
			{
				Clipboard.SetText(text: text);
				if (showMessage)
				{
					MessageBox.Show(text: Strings.copiedToClipboard, caption: Strings.information, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				}
			}
		}

		/// <summary>
		/// Update all percent labels
		/// </summary>
		private void UpdatePercentLabels()
		{
			if (isUpdatePercentLabels)
			{
				sumChars = decimal.ToUInt32(d:
					numericUpDownCharA.Value +
					numericUpDownCharB.Value +
					numericUpDownCharC.Value +
					numericUpDownCharD.Value +
					numericUpDownCharE.Value +
					numericUpDownCharF.Value +
					numericUpDownCharG.Value +
					numericUpDownCharH.Value +
					numericUpDownCharI.Value +
					numericUpDownCharJ.Value +
					numericUpDownCharK.Value +
					numericUpDownCharL.Value +
					numericUpDownCharM.Value +
					numericUpDownCharN.Value +
					numericUpDownCharO.Value +
					numericUpDownCharP.Value +
					numericUpDownCharQ.Value +
					numericUpDownCharR.Value +
					numericUpDownCharS.Value +
					numericUpDownCharT.Value +
					numericUpDownCharU.Value +
					numericUpDownCharV.Value +
					numericUpDownCharW.Value +
					numericUpDownCharX.Value +
					numericUpDownCharY.Value +
					numericUpDownCharZ.Value);
				labelPercentCharA.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharA.Value / sumChars * 100);
				labelPercentCharB.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharB.Value / sumChars * 100);
				labelPercentCharC.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharC.Value / sumChars * 100);
				labelPercentCharD.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharD.Value / sumChars * 100);
				labelPercentCharE.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharE.Value / sumChars * 100);
				labelPercentCharF.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharF.Value / sumChars * 100);
				labelPercentCharG.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharG.Value / sumChars * 100);
				labelPercentCharH.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharH.Value / sumChars * 100);
				labelPercentCharI.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharI.Value / sumChars * 100);
				labelPercentCharJ.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharJ.Value / sumChars * 100);
				labelPercentCharK.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharK.Value / sumChars * 100);
				labelPercentCharL.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharL.Value / sumChars * 100);
				labelPercentCharM.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharM.Value / sumChars * 100);
				labelPercentCharN.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharN.Value / sumChars * 100);
				labelPercentCharO.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharO.Value / sumChars * 100);
				labelPercentCharP.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharP.Value / sumChars * 100);
				labelPercentCharQ.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharQ.Value / sumChars * 100);
				labelPercentCharR.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharR.Value / sumChars * 100);
				labelPercentCharS.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharS.Value / sumChars * 100);
				labelPercentCharT.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharT.Value / sumChars * 100);
				labelPercentCharU.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharU.Value / sumChars * 100);
				labelPercentCharV.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharV.Value / sumChars * 100);
				labelPercentCharW.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharW.Value / sumChars * 100);
				labelPercentCharX.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharX.Value / sumChars * 100);
				labelPercentCharY.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharY.Value / sumChars * 100);
				labelPercentCharZ.Text = string.Format(provider: culture, format: Strings.percentFormat, args: numericUpDownCharZ.Value / sumChars * 100);
				labelCharPool.Text = $"{Strings.charPool}{Strings.colonSpace}{sumChars}";
			}
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public ProbabilityTableForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Load the main window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ProbabilityTableForm_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = string.Empty;
			if (comboBoxCharA.SelectedIndex == -1)
			{
				comboBoxCharA.SelectedIndex = (byte)Letter.Vowel;
			}
			if (comboBoxCharB.SelectedIndex == -1)
			{
				comboBoxCharB.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharC.SelectedIndex == -1)
			{
				comboBoxCharC.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharD.SelectedIndex == -1)
			{
				comboBoxCharD.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharE.SelectedIndex == -1)
			{
				comboBoxCharE.SelectedIndex = (byte)Letter.Vowel;
			}
			if (comboBoxCharF.SelectedIndex == -1)
			{
				comboBoxCharF.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharG.SelectedIndex == -1)
			{
				comboBoxCharG.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharH.SelectedIndex == -1)
			{
				comboBoxCharH.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharI.SelectedIndex == -1)
			{
				comboBoxCharI.SelectedIndex = (byte)Letter.Vowel;
			}
			if (comboBoxCharJ.SelectedIndex == -1)
			{
				comboBoxCharJ.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharK.SelectedIndex == -1)
			{
				comboBoxCharK.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharL.SelectedIndex == -1)
			{
				comboBoxCharL.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharM.SelectedIndex == -1)
			{
				comboBoxCharM.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharN.SelectedIndex == -1)
			{
				comboBoxCharN.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharO.SelectedIndex == -1)
			{
				comboBoxCharO.SelectedIndex = (byte)Letter.Vowel;
			}
			if (comboBoxCharP.SelectedIndex == -1)
			{
				comboBoxCharP.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharQ.SelectedIndex == -1)
			{
				comboBoxCharQ.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharR.SelectedIndex == -1)
			{
				comboBoxCharR.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharS.SelectedIndex == -1)
			{
				comboBoxCharS.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharT.SelectedIndex == -1)
			{
				comboBoxCharT.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharU.SelectedIndex == -1)
			{
				comboBoxCharU.SelectedIndex = (byte)Letter.Vowel;
			}
			if (comboBoxCharV.SelectedIndex == -1)
			{
				comboBoxCharV.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharW.SelectedIndex == -1)
			{
				comboBoxCharW.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharX.SelectedIndex == -1)
			{
				comboBoxCharX.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharY.SelectedIndex == -1)
			{
				comboBoxCharY.SelectedIndex = (byte)Letter.Consonant;
			}
			if (comboBoxCharZ.SelectedIndex == -1)
			{
				comboBoxCharZ.SelectedIndex = (byte)Letter.Consonant;
			}
			//UpdatePercentLabels();
		}

		#region Click handlers

		/// <summary>
		/// Apply the changes of the characters
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonApply_Click(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = string.Empty;
			strConsonants = string.Empty;
			strVowels = string.Empty;
			strConsonantPool = string.Empty;
			strVowelPool = string.Empty;
			string temp = CharacterResources.a;
			foreach (Control control in Controls)
			{
				if (control is ComboBox)
				{
					switch (control.Name)
					{
						case "comboBoxCharA": temp = CharacterResources.a; break;
						case "comboBoxCharB": temp = CharacterResources.b; break;
						case "comboBoxCharC": temp = CharacterResources.c; break;
						case "comboBoxCharD": temp = CharacterResources.d; break;
						case "comboBoxCharE": temp = CharacterResources.e; break;
						case "comboBoxCharF": temp = CharacterResources.f; break;
						case "comboBoxCharG": temp = CharacterResources.g; break;
						case "comboBoxCharH": temp = CharacterResources.h; break;
						case "comboBoxCharI": temp = CharacterResources.i; break;
						case "comboBoxCharJ": temp = CharacterResources.j; break;
						case "comboBoxCharK": temp = CharacterResources.k; break;
						case "comboBoxCharL": temp = CharacterResources.l; break;
						case "comboBoxCharM": temp = CharacterResources.m; break;
						case "comboBoxCharN": temp = CharacterResources.n; break;
						case "comboBoxCharO": temp = CharacterResources.o; break;
						case "comboBoxCharP": temp = CharacterResources.p; break;
						case "comboBoxCharQ": temp = CharacterResources.q; break;
						case "comboBoxCharR": temp = CharacterResources.r; break;
						case "comboBoxCharS": temp = CharacterResources.s; break;
						case "comboBoxCharT": temp = CharacterResources.t; break;
						case "comboBoxCharU": temp = CharacterResources.u; break;
						case "comboBoxCharV": temp = CharacterResources.v; break;
						case "comboBoxCharW": temp = CharacterResources.w; break;
						case "comboBoxCharX": temp = CharacterResources.x; break;
						case "comboBoxCharY": temp = CharacterResources.y; break;
						case "comboBoxCharZ": temp = CharacterResources.z; break;
					}
					switch ((control as ComboBox).SelectedIndex)
					{
						case (byte)Letter.Vowel: strVowels += temp; break;
						case (byte)Letter.Consonant: strConsonants += temp; break;
					}
				}
			}
			switch (comboBoxCharA.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharA.Value; n++) { strVowelPool += CharacterResources.a; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharA.Value; n++) { strConsonantPool += CharacterResources.a; } break;
				default: break;
			}
			switch (comboBoxCharB.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharB.Value; n++) { strVowelPool += CharacterResources.b; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharB.Value; n++) { strConsonantPool += CharacterResources.b; } break;
				default: break;
			}
			switch (comboBoxCharC.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharC.Value; n++) { strVowelPool += CharacterResources.c; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharC.Value; n++) { strConsonantPool += CharacterResources.c; } break;
				default: break;
			}
			switch (comboBoxCharD.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharD.Value; n++) { strVowelPool += CharacterResources.d; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharD.Value; n++) { strConsonantPool += CharacterResources.d; } break;
				default: break;
			}
			switch (comboBoxCharE.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharE.Value; n++) { strVowelPool += CharacterResources.e; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharE.Value; n++) { strConsonantPool += CharacterResources.e; } break;
				default: break;
			}
			switch (comboBoxCharF.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharF.Value; n++) { strVowelPool += CharacterResources.f; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharF.Value; n++) { strConsonantPool += CharacterResources.f; } break;
				default: break;
			}
			switch (comboBoxCharG.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharG.Value; n++) { strVowelPool += CharacterResources.g; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharG.Value; n++) { strConsonantPool += CharacterResources.g; } break;
				default: break;
			}
			switch (comboBoxCharH.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharH.Value; n++) { strVowelPool += CharacterResources.h; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharH.Value; n++) { strConsonantPool += CharacterResources.h; } break;
				default: break;
			}
			switch (comboBoxCharI.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharI.Value; n++) { strVowelPool += CharacterResources.i; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharI.Value; n++) { strConsonantPool += CharacterResources.i; } break;
				default: break;
			}
			switch (comboBoxCharJ.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharJ.Value; n++) { strVowelPool += CharacterResources.j; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharJ.Value; n++) { strConsonantPool += CharacterResources.j; } break;
				default: break;
			}
			switch (comboBoxCharK.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharK.Value; n++) { strVowelPool += CharacterResources.k; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharK.Value; n++) { strConsonantPool += CharacterResources.k; } break;
				default: break;
			}
			switch (comboBoxCharL.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharL.Value; n++) { strVowelPool += CharacterResources.l; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharL.Value; n++) { strConsonantPool += CharacterResources.l; } break;
				default: break;
			}
			switch (comboBoxCharM.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharM.Value; n++) { strVowelPool += CharacterResources.m; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharM.Value; n++) { strConsonantPool += CharacterResources.m; } break;
				default: break;
			}
			switch (comboBoxCharN.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharN.Value; n++) { strVowelPool += CharacterResources.n; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharN.Value; n++) { strConsonantPool += CharacterResources.n; } break;
				default: break;
			}
			switch (comboBoxCharO.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharO.Value; n++) { strVowelPool += CharacterResources.o; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharO.Value; n++) { strConsonantPool += CharacterResources.o; } break;
				default: break;
			}
			switch (comboBoxCharP.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharP.Value; n++) { strVowelPool += CharacterResources.p; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharP.Value; n++) { strConsonantPool += CharacterResources.p; } break;
				default: break;
			}
			switch (comboBoxCharQ.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharQ.Value; n++) { strVowelPool += CharacterResources.q; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharQ.Value; n++) { strConsonantPool += CharacterResources.q; } break;
				default: break;
			}
			switch (comboBoxCharR.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharR.Value; n++) { strVowelPool += CharacterResources.r; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharR.Value; n++) { strConsonantPool += CharacterResources.r; } break;
				default: break;
			}
			switch (comboBoxCharS.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharS.Value; n++) { strVowelPool += CharacterResources.s; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharS.Value; n++) { strConsonantPool += CharacterResources.s; } break;
				default: break;
			}
			switch (comboBoxCharT.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharT.Value; n++) { strVowelPool += CharacterResources.t; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharT.Value; n++) { strConsonantPool += CharacterResources.t; } break;
				default: break;
			}
			switch (comboBoxCharU.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharU.Value; n++) { strVowelPool += CharacterResources.u; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharU.Value; n++) { strConsonantPool += CharacterResources.u; } break;
				default: break;
			}
			switch (comboBoxCharV.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharV.Value; n++) { strVowelPool += CharacterResources.v; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharV.Value; n++) { strConsonantPool += CharacterResources.v; } break;
				default: break;
			}
			switch (comboBoxCharW.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharW.Value; n++) { strVowelPool += CharacterResources.w; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharW.Value; n++) { strConsonantPool += CharacterResources.w; } break;
				default: break;
			}
			switch (comboBoxCharX.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharX.Value; n++) { strVowelPool += CharacterResources.x; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharX.Value; n++) { strConsonantPool += CharacterResources.x; } break;
				default: break;
			}
			switch (comboBoxCharY.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharY.Value; n++) { strVowelPool += CharacterResources.y; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharY.Value; n++) { strConsonantPool += CharacterResources.y; } break;
				default: break;
			}
			switch (comboBoxCharZ.SelectedIndex)
			{
				case (byte)Letter.Vowel: for (byte n = 0; n < numericUpDownCharZ.Value; n++) { strVowelPool += CharacterResources.z; } break;
				case (byte)Letter.Consonant: for (byte n = 0; n < numericUpDownCharZ.Value; n++) { strConsonantPool += CharacterResources.z; } break;
				default: break;
			}
			Close();
		}

		/// <summary>
		/// Cancel the changes of the characters
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Randomize the changes of the characters
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonRandomize_Click(object sender, EventArgs e)
		{
			isUpdatePercentLabels = false;
			Random rnd = new Random();
			numericUpDownCharA.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharB.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharC.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharD.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharE.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharF.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharG.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharH.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharI.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharJ.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharK.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharL.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharM.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharN.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharO.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharP.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharQ.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharR.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharS.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharT.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharU.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharV.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharW.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharX.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharY.Value = rnd.Next(minValue: 0, maxValue: 101);
			numericUpDownCharZ.Value = rnd.Next(minValue: 0, maxValue: 101);
			isUpdatePercentLabels = true;
			UpdatePercentLabels();
		}

		#endregion

		#region DoubleClick handlers

		/// <summary>
		/// Copy the percent of the character A to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharA_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharA.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character B to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharB_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharB.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character C to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharC_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharC.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character D to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharD_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharD.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character E to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharE_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharE.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character F to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharF_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharF.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character G to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharG_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharG.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character H to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharH_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharH.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character I to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharI_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharI.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character J to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharJ_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharJ.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character K to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharK_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharK.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character L to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharL_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharL.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character M to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharM_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharM.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character N to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharN_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharN.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character O to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharO_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharO.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character P to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharP_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharP.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character Q to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharQ_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharQ.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character R to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharR_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharR.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character S to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharS_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharS.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character T to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharT_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharT.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character U to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharU_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharU.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character V to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharV_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharV.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character W to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharW_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharW.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character X to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharX_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharX.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character Y to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharY_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharY.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the percent of the character Z to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelPercentCharZ_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharZ.Text, showMessage: true);
		}

		/// <summary>
		/// Copy the char pool to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LabelCharPool_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelCharPool.Text, showMessage: true);
		}

		#endregion

		#region ValueChanged handlers

		/// <summary>
		/// Update the percent labels while changing the values of numeric spin buttons
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void UpdatePercentLabels_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		#endregion

		#region Enter handlers

		/// <summary>
		/// Set the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = ((Control)sender).AccessibleDescription;
		}

		#endregion

		#region Leave handlers

		/// <summary>
		/// Clear the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = string.Empty;
		}

		#endregion
	}
}