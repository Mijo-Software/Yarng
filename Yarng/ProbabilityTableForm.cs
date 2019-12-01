using System;
using System.Windows.Forms;

namespace Yarng
{
	public partial class ProbabilityTableForm : Form
	{
		private uint sumChars = 0;
		private string strConsonants, strConsonantPool, strVowels, strVowelPool;

		private enum Letter : byte { Consonant = 0, Vowel /*Syllable, Semivowel, DoubleConsonant, DoubleVowel*/ };

		public string Consonants
		{
			get => strConsonants;
			set => strConsonants = value;
		}

		public string Vowels
		{
			get => strVowels;
			set => strVowels = value;
		}

		public string ConsonantPool
		{
			get => strConsonantPool;
			set => strConsonantPool = value;
		}

		public string VowelPool
		{
			get => strVowelPool;
			set => strVowelPool = value;
		}

		public byte NumericValueCharA
		{
			get => (byte)numericUpDownCharA.Value;
			set => numericUpDownCharA.Value = value;
		}

		public byte NumericValueCharB
		{
			get => (byte)numericUpDownCharB.Value;
			set => numericUpDownCharB.Value = value;
		}

		public byte NumericValueCharC
		{
			get => (byte)numericUpDownCharC.Value;
			set => numericUpDownCharC.Value = value;
		}

		public byte NumericValueCharD
		{
			get => (byte)numericUpDownCharD.Value;
			set => numericUpDownCharD.Value = value;
		}

		public byte NumericValueCharE
		{
			get => (byte)numericUpDownCharE.Value;
			set => numericUpDownCharE.Value = value;
		}

		public byte NumericValueCharF
		{
			get => (byte)numericUpDownCharF.Value;
			set => numericUpDownCharF.Value = value;
		}

		public byte NumericValueCharG
		{
			get => (byte)numericUpDownCharG.Value;
			set => numericUpDownCharG.Value = value;
		}

		public byte NumericValueCharH
		{
			get => (byte)numericUpDownCharH.Value;
			set => numericUpDownCharH.Value = value;
		}

		public byte NumericValueCharI
		{
			get => (byte)numericUpDownCharI.Value;
			set => numericUpDownCharI.Value = value;
		}

		public byte NumericValueCharJ
		{
			get => (byte)numericUpDownCharJ.Value;
			set => numericUpDownCharJ.Value = value;
		}

		public byte NumericValueCharK
		{
			get => (byte)numericUpDownCharK.Value;
			set => numericUpDownCharK.Value = value;
		}

		public byte NumericValueCharL
		{
			get => (byte)numericUpDownCharL.Value;
			set => numericUpDownCharL.Value = value;
		}

		public byte NumericValueCharM
		{
			get => (byte)numericUpDownCharM.Value;
			set => numericUpDownCharM.Value = value;
		}

		public byte NumericValueCharN
		{
			get => (byte)numericUpDownCharN.Value;
			set => numericUpDownCharN.Value = value;
		}

		public byte NumericValueCharO
		{
			get => (byte)numericUpDownCharO.Value;
			set => numericUpDownCharO.Value = value;
		}

		public byte NumericValueCharP
		{
			get => (byte)numericUpDownCharP.Value;
			set => numericUpDownCharP.Value = value;
		}

		public byte NumericValueCharQ
		{
			get => (byte)numericUpDownCharQ.Value;
			set => numericUpDownCharQ.Value = value;
		}

		public byte NumericValueCharR
		{
			get => (byte)numericUpDownCharR.Value;
			set => numericUpDownCharR.Value = value;
		}

		public byte NumericValueCharS
		{
			get => (byte)numericUpDownCharS.Value;
			set => numericUpDownCharS.Value = value;
		}

		public byte NumericValueCharT
		{
			get => (byte)numericUpDownCharT.Value;
			set => numericUpDownCharT.Value = value;
		}

		public byte NumericValueCharU
		{
			get => (byte)numericUpDownCharU.Value;
			set => numericUpDownCharU.Value = value;
		}

		public byte NumericValueCharV
		{
			get => (byte)numericUpDownCharV.Value;
			set => numericUpDownCharV.Value = value;
		}

		public byte NumericValueCharW
		{
			get => (byte)numericUpDownCharW.Value;
			set => numericUpDownCharW.Value = value;
		}

		public byte NumericValueCharX
		{
			get => (byte)numericUpDownCharX.Value;
			set => numericUpDownCharX.Value = value;
		}

		public byte NumericValueCharY
		{
			get => (byte)numericUpDownCharY.Value;
			set => numericUpDownCharY.Value = value;
		}

		public byte NumericValueCharZ
		{
			get => (byte)numericUpDownCharZ.Value;
			set => numericUpDownCharZ.Value = value;
		}

		public byte SortOfCharA
		{
			get => (byte)comboBoxCharA.SelectedIndex;
			set => comboBoxCharA.SelectedIndex = value;
		}

		public byte SortOfCharB
		{
			get => (byte)comboBoxCharB.SelectedIndex;
			set => comboBoxCharB.SelectedIndex = value;
		}

		public byte SortOfCharC
		{
			get => (byte)comboBoxCharC.SelectedIndex;
			set => comboBoxCharC.SelectedIndex = value;
		}

		public byte SortOfCharD
		{
			get => (byte)comboBoxCharD.SelectedIndex;
			set => comboBoxCharD.SelectedIndex = value;
		}

		public byte SortOfCharE
		{
			get => (byte)comboBoxCharE.SelectedIndex;
			set => comboBoxCharE.SelectedIndex = value;
		}

		public byte SortOfCharF
		{
			get => (byte)comboBoxCharF.SelectedIndex;
			set => comboBoxCharF.SelectedIndex = value;
		}

		public byte SortOfCharG
		{
			get => (byte)comboBoxCharG.SelectedIndex;
			set => comboBoxCharG.SelectedIndex = value;
		}

		public byte SortOfCharH
		{
			get => (byte)comboBoxCharH.SelectedIndex;
			set => comboBoxCharH.SelectedIndex = value;
		}

		public byte SortOfCharI
		{
			get => (byte)comboBoxCharI.SelectedIndex;
			set => comboBoxCharI.SelectedIndex = value;
		}

		public byte SortOfCharJ
		{
			get => (byte)comboBoxCharJ.SelectedIndex;
			set => comboBoxCharJ.SelectedIndex = value;
		}

		public byte SortOfCharK
		{
			get => (byte)comboBoxCharK.SelectedIndex;
			set => comboBoxCharK.SelectedIndex = value;
		}

		public byte SortOfCharL
		{
			get => (byte)comboBoxCharL.SelectedIndex;
			set => comboBoxCharL.SelectedIndex = value;
		}

		public byte SortOfCharM
		{
			get => (byte)comboBoxCharM.SelectedIndex;
			set => comboBoxCharM.SelectedIndex = value;
		}

		public byte SortOfCharN
		{
			get => (byte)comboBoxCharN.SelectedIndex;
			set => comboBoxCharN.SelectedIndex = value;
		}

		public byte SortOfCharO
		{
			get => (byte)comboBoxCharO.SelectedIndex;
			set => comboBoxCharO.SelectedIndex = value;
		}

		public byte SortOfCharP
		{
			get => (byte)comboBoxCharP.SelectedIndex;
			set => comboBoxCharP.SelectedIndex = value;
		}

		public byte SortOfCharQ
		{
			get => (byte)comboBoxCharQ.SelectedIndex;
			set => comboBoxCharQ.SelectedIndex = value;
		}

		public byte SortOfCharR
		{
			get => (byte)comboBoxCharR.SelectedIndex;
			set => comboBoxCharR.SelectedIndex = value;
		}

		public byte SortOfCharS
		{
			get => (byte)comboBoxCharS.SelectedIndex;
			set => comboBoxCharS.SelectedIndex = value;
		}

		public byte SortOfCharT
		{
			get => (byte)comboBoxCharT.SelectedIndex;
			set => comboBoxCharT.SelectedIndex = value;
		}

		public byte SortOfCharU
		{
			get => (byte)comboBoxCharU.SelectedIndex;
			set => comboBoxCharU.SelectedIndex = value;
		}

		public byte SortOfCharV
		{
			get => (byte)comboBoxCharV.SelectedIndex;
			set => comboBoxCharV.SelectedIndex = value;
		}

		public byte SortOfCharW
		{
			get => (byte)comboBoxCharW.SelectedIndex;
			set => comboBoxCharW.SelectedIndex = value;
		}

		public byte SortOfCharX
		{
			get => (byte)comboBoxCharX.SelectedIndex;
			set => comboBoxCharX.SelectedIndex = value;
		}

		public byte SortOfCharY
		{
			get => (byte)comboBoxCharY.SelectedIndex;
			set => comboBoxCharY.SelectedIndex = value;
		}

		public byte SortOfCharZ
		{
			get => (byte)comboBoxCharZ.SelectedIndex;
			set => comboBoxCharZ.SelectedIndex = value;
		}

		private void CopyToClipboard(string text, bool showMessage)
		{
			Clipboard.SetText(text: text);
			if (showMessage)
			{
				MessageBox.Show(text: "Copied to clipboard", caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
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

		private void UpdatePercentLabels()
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
			labelPercentCharA.Text = $"{numericUpDownCharA.Value / sumChars * 100,0:0.00}%";
			labelPercentCharB.Text = $"{numericUpDownCharB.Value / sumChars * 100,0:0.00}%";
			labelPercentCharC.Text = $"{numericUpDownCharC.Value / sumChars * 100,0:0.00}%";
			labelPercentCharD.Text = $"{numericUpDownCharD.Value / sumChars * 100,0:0.00}%";
			labelPercentCharE.Text = $"{numericUpDownCharE.Value / sumChars * 100,0:0.00}%";
			labelPercentCharF.Text = $"{numericUpDownCharF.Value / sumChars * 100,0:0.00}%";
			labelPercentCharG.Text = $"{numericUpDownCharG.Value / sumChars * 100,0:0.00}%";
			labelPercentCharH.Text = $"{numericUpDownCharH.Value / sumChars * 100,0:0.00}%";
			labelPercentCharI.Text = $"{numericUpDownCharI.Value / sumChars * 100,0:0.00}%";
			labelPercentCharJ.Text = $"{numericUpDownCharJ.Value / sumChars * 100,0:0.00}%";
			labelPercentCharK.Text = $"{numericUpDownCharK.Value / sumChars * 100,0:0.00}%";
			labelPercentCharL.Text = $"{numericUpDownCharL.Value / sumChars * 100,0:0.00}%";
			labelPercentCharM.Text = $"{numericUpDownCharM.Value / sumChars * 100,0:0.00}%";
			labelPercentCharN.Text = $"{numericUpDownCharN.Value / sumChars * 100,0:0.00}%";
			labelPercentCharO.Text = $"{numericUpDownCharO.Value / sumChars * 100,0:0.00}%";
			labelPercentCharP.Text = $"{numericUpDownCharP.Value / sumChars * 100,0:0.00}%";
			labelPercentCharQ.Text = $"{numericUpDownCharQ.Value / sumChars * 100,0:0.00}%";
			labelPercentCharR.Text = $"{numericUpDownCharR.Value / sumChars * 100,0:0.00}%";
			labelPercentCharS.Text = $"{numericUpDownCharS.Value / sumChars * 100,0:0.00}%";
			labelPercentCharT.Text = $"{numericUpDownCharT.Value / sumChars * 100,0:0.00}%";
			labelPercentCharU.Text = $"{numericUpDownCharU.Value / sumChars * 100,0:0.00}%";
			labelPercentCharV.Text = $"{numericUpDownCharV.Value / sumChars * 100,0:0.00}%";
			labelPercentCharW.Text = $"{numericUpDownCharW.Value / sumChars * 100,0:0.00}%";
			labelPercentCharX.Text = $"{numericUpDownCharX.Value / sumChars * 100,0:0.00}%";
			labelPercentCharY.Text = $"{numericUpDownCharY.Value / sumChars * 100,0:0.00}%";
			labelPercentCharZ.Text = $"{numericUpDownCharZ.Value / sumChars * 100,0:0.00}%";
			labelCharPool.Text = $"char pool: {sumChars}";
		}

		public ProbabilityTableForm()
		{
			InitializeComponent();
		}

		private void ProbabilityTableForm_Load(object sender, EventArgs e)
		{
			ClearStatusText();
			toolStripProgressBar.Visible = false;
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

		private void ButtonApply_Click(object sender, EventArgs e)
		{
			ClearStatusText();
			strConsonants = "";
			strVowels = "";
			strConsonantPool = "";
			strVowelPool = "";
			toolStripProgressBar.Visible = true;
			toolStripProgressBar.Maximum = (int)numericUpDownCharA.Value +
				(int)numericUpDownCharB.Value +
				(int)numericUpDownCharC.Value +
				(int)numericUpDownCharD.Value +
				(int)numericUpDownCharE.Value +
				(int)numericUpDownCharF.Value +
				(int)numericUpDownCharG.Value +
				(int)numericUpDownCharH.Value +
				(int)numericUpDownCharI.Value +
				(int)numericUpDownCharJ.Value +
				(int)numericUpDownCharK.Value +
				(int)numericUpDownCharL.Value +
				(int)numericUpDownCharM.Value +
				(int)numericUpDownCharN.Value +
				(int)numericUpDownCharO.Value +
				(int)numericUpDownCharP.Value +
				(int)numericUpDownCharQ.Value +
				(int)numericUpDownCharR.Value +
				(int)numericUpDownCharS.Value +
				(int)numericUpDownCharT.Value +
				(int)numericUpDownCharU.Value +
				(int)numericUpDownCharV.Value +
				(int)numericUpDownCharW.Value +
				(int)numericUpDownCharX.Value +
				(int)numericUpDownCharY.Value +
				(int)numericUpDownCharZ.Value;
			toolStripProgressBar.Minimum = 0;
			switch (comboBoxCharA.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.a; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.a; break;
					}
			}
			switch (comboBoxCharB.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.b; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.b; break;
					}
			}
			switch (comboBoxCharC.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.c; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.c; break;
					}
			}
			switch (comboBoxCharD.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.d; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.d; break;
					}
			}
			switch (comboBoxCharE.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.e; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.e; break;
					}
			}
			switch (comboBoxCharF.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.f; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.f; break;
					}
			}
			switch (comboBoxCharG.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.g; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.g; break;
					}
			}
			switch (comboBoxCharH.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.h; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.h; break;
					}
			}
			switch (comboBoxCharI.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.i; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.i; break;
					}
			}
			switch (comboBoxCharJ.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.j; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.j; break;
					}
			}
			switch (comboBoxCharK.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.k; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.k; break;
					}
			}
			switch (comboBoxCharL.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.l; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.l; break;
					}
			}
			switch (comboBoxCharM.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.m; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.m; break;
					}
			}
			switch (comboBoxCharN.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.n; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.n; break;
					}
			}
			switch (comboBoxCharO.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.o; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.o; break;
					}
			}
			switch (comboBoxCharP.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.p; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.p; break;
					}
			}
			switch (comboBoxCharQ.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.q; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.q; break;
					}
			}
			switch (comboBoxCharR.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.r; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.r; break;
					}
			}
			switch (comboBoxCharS.SelectedIndex)
			{
				case (byte)Letter.Vowel: strVowels += Properties.CharacterResources.s; break;
				case (byte)Letter.Consonant: strConsonants += Properties.CharacterResources.s; break;
			}
			switch (comboBoxCharT.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.t; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.t; break;
					}
			}
			switch (comboBoxCharU.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.u; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.u; break;
					}
			}
			switch (comboBoxCharV.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.v; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.v; break;
					}
			}
			switch (comboBoxCharW.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.w; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.w; break;
					}
			}
			switch (comboBoxCharX.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.x; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.x; break;
					}
			}
			switch (comboBoxCharY.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.y; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.y; break;
					}
			}
			switch (comboBoxCharZ.SelectedIndex)
			{
				case (byte)Letter.Vowel:
					{
						strVowels += Properties.CharacterResources.z; break;
					}
				case (byte)Letter.Consonant:
					{
						strConsonants += Properties.CharacterResources.z; break;
					}
			}
			for (byte i = 0; i < numericUpDownCharA.Value; i++)
			{
				switch (comboBoxCharA.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.a; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.a; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharB.Value; i++)
			{
				switch (comboBoxCharB.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.b; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.b; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharC.Value; i++)
			{
				switch (comboBoxCharC.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.c; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.c; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharD.Value; i++)
			{
				switch (comboBoxCharD.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.d; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.d; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharE.Value; i++)
			{
				switch (comboBoxCharE.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.e; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.e; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharF.Value; i++)
			{
				switch (comboBoxCharF.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.f; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.f; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharG.Value; i++)
			{
				switch (comboBoxCharG.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.g; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.g; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharH.Value; i++)
			{
				switch (comboBoxCharH.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.h; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.h; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharI.Value; i++)
			{
				switch (comboBoxCharI.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.i; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.i; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharJ.Value; i++)
			{
				switch (comboBoxCharJ.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.j; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.j; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharK.Value; i++)
			{
				switch (comboBoxCharK.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.k; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.k; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharL.Value; i++)
			{
				switch (comboBoxCharL.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.l; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.l; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharM.Value; i++)
			{
				switch (comboBoxCharM.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.m; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.m; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharN.Value; i++)
			{
				switch (comboBoxCharN.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.n; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.n; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharO.Value; i++)
			{
				switch (comboBoxCharO.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.o; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.o; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharP.Value; i++)
			{
				switch (comboBoxCharP.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.p; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.p; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharQ.Value; i++)
			{
				switch (comboBoxCharQ.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.q; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.q; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharR.Value; i++)
			{
				switch (comboBoxCharR.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.r; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.r; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharS.Value; i++)
			{
				switch (comboBoxCharS.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.s; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.s; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharT.Value; i++)
			{
				switch (comboBoxCharT.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.t; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.t; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharU.Value; i++)
			{
				switch (comboBoxCharU.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.u; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.u; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharV.Value; i++)
			{
				switch (comboBoxCharV.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.v; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.v; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharW.Value; i++)
			{
				switch (comboBoxCharW.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.w; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.w; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharX.Value; i++)
			{
				switch (comboBoxCharX.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.x; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.x; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharY.Value; i++)
			{
				switch (comboBoxCharY.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.y; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.y; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			for (byte i = 0; i < numericUpDownCharZ.Value; i++)
			{
				switch (comboBoxCharZ.SelectedIndex)
				{
					case (byte)Letter.Vowel:
						{
							strVowelPool += Properties.CharacterResources.z; break;
						}
					case (byte)Letter.Consonant:
						{
							strConsonantPool += Properties.CharacterResources.z; break;
						}
				}
				toolStripProgressBar.PerformStep();
			}
			Close();
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonRandomize_Click(object sender, EventArgs e)
		{
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
		}

		#endregion

		#region ValueChanged handlers

		private void NumericUpDownCharA_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharB_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharC_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharD_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharE_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharF_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharG_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharH_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharI_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharJ_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharK_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharL_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharM_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharN_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharO_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharP_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharQ_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharR_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharS_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharT_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharU_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharV_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharW_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharX_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharY_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		private void NumericUpDownCharZ_ValueChanged(object sender, EventArgs e)
		{
			UpdatePercentLabels();
		}

		#endregion

		#region Enter handlers

		private void LabelCharA_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharB_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharC_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharD_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharE_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharF_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharG_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharH_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharI_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharJ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharK_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharL_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharM_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharN_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharO_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharP_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharQ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharR_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharS_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharT_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharU_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharV_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharW_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharX_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharY_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharZ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharPool_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonApply_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonCancel_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonRandomize_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharA_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharB_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharC_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharD_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharE_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharF_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharG_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharH_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharI_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharJ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharK_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharL_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharM_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharN_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharO_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharP_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharQ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharR_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharS_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharT_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharU_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharV_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharW_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharX_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharY_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharZ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharA_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharB_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharC_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharD_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharE_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharF_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharG_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharH_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharI_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharJ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharK_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharL_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharM_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharN_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharO_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharP_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharQ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharR_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharS_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharT_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharU_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharV_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharW_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharX_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharY_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void NumericUpDownCharZ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharA_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharB_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharC_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharD_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharE_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharF_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharG_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharH_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharI_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharJ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharK_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharL_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharM_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharN_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharO_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharP_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharQ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharR_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharS_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharT_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharU_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharV_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharW_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharX_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharY_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharZ_Enter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		#endregion

		#region Leave handlers

		private void LabelCharA_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharB_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharC_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharD_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharE_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharF_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharG_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharH_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharI_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharJ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharK_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharL_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharM_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharN_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharO_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharP_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharQ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharR_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharS_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharT_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharU_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharV_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharW_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharX_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharY_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharZ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharPool_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonApply_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonCancel_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonRandomize_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharA_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharB_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharC_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharD_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharE_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharF_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharG_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharH_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharI_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharJ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharK_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharL_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharM_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharN_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharO_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharP_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharQ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharR_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharS_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharT_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharU_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharV_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharW_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharX_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharY_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharZ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharA_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharB_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharC_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharD_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharE_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharF_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharG_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharH_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharI_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharJ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharK_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharL_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharM_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharN_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharO_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharP_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharQ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharR_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharS_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharT_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharU_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharV_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharW_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharX_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharY_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void NumericUpDownCharZ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharA_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharB_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharC_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharD_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharE_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharF_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharG_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharH_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharI_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharJ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharK_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharL_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharM_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharN_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharO_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharP_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharQ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharR_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharS_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharT_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharU_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharV_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharW_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharX_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharY_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharZ_Leave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		#endregion

		#region MouseEnter handlers

		private void LabelCharA_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharB_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharC_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharD_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharE_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharF_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharG_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharH_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharI_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharJ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharK_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharL_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharM_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharN_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharO_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharP_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharQ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharR_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharS_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharT_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharU_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharV_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharW_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharX_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharY_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharZ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelCharPool_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonApply_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonCancel_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ButtonRandomize_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharA_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharB_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharC_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharD_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharE_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharF_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharG_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharH_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharI_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharJ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharK_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharL_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharM_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharN_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharO_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharP_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharQ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharR_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharS_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharT_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharU_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharV_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharW_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharX_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharY_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void ComboBoxCharZ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharA_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharB_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharC_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharD_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharE_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharF_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharG_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharH_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharI_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharJ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharK_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharL_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharM_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharN_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharO_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharP_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharQ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharR_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharS_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharT_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharU_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharV_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharW_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharX_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharY_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		private void LabelPercentCharZ_MouseEnter(object sender, EventArgs e)
		{
			SetStatusText(sender: sender, e: e);
		}

		#endregion

		#region MouseLeave handlers

		private void LabelCharA_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharB_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharC_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharD_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharE_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharF_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharG_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharH_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharI_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharJ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharK_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharL_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharM_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharN_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharO_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharP_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharQ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharR_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharS_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharT_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharU_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharV_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharW_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharX_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharY_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharZ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelCharPool_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonApply_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonCancel_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ButtonRandomize_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharA_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharB_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharC_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharD_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharE_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharF_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharG_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharH_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharI_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharJ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharK_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharL_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharM_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharN_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharO_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharP_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharQ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharR_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharS_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharT_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharU_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharV_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharW_MouseMove(object sender, MouseEventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharX_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharY_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void ComboBoxCharZ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharA_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharB_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharC_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharD_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharE_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharF_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharG_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharH_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharI_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharJ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharK_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharL_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharM_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharN_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharO_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharP_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharQ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharR_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharS_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharT_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharU_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharV_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharW_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharX_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharY_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		private void LabelPercentCharZ_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusText();
		}

		#endregion

		#region DoubleClick handlers

		private void LabelPercentCharA_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharA.Text, showMessage: true);
		}

		private void LabelPercentCharB_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharB.Text, showMessage: true);
		}

		private void LabelPercentCharC_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharC.Text, showMessage: true);
		}

		private void LabelPercentCharD_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharD.Text, showMessage: true);
		}

		private void LabelPercentCharE_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharE.Text, showMessage: true);
		}

		private void LabelPercentCharF_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharF.Text, showMessage: true);
		}

		private void LabelPercentCharG_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharG.Text, showMessage: true);
		}

		private void LabelPercentCharH_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharH.Text, showMessage: true);
		}

		private void LabelPercentCharI_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharI.Text, showMessage: true);
		}

		private void LabelPercentCharJ_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharJ.Text, showMessage: true);
		}

		private void LabelPercentCharK_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharK.Text, showMessage: true);
		}

		private void LabelPercentCharL_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharL.Text, showMessage: true);
		}

		private void LabelPercentCharM_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharM.Text, showMessage: true);
		}

		private void LabelPercentCharN_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharN.Text, showMessage: true);
		}

		private void LabelPercentCharO_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharO.Text, showMessage: true);
		}

		private void LabelPercentCharP_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharP.Text, showMessage: true);
		}

		private void LabelPercentCharQ_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharQ.Text, showMessage: true);
		}

		private void LabelPercentCharR_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharR.Text, showMessage: true);
		}

		private void LabelPercentCharS_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharS.Text, showMessage: true);
		}

		private void LabelPercentCharT_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharT.Text, showMessage: true);
		}

		private void LabelPercentCharU_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharU.Text, showMessage: true);
		}

		private void LabelPercentCharV_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharV.Text, showMessage: true);
		}

		private void LabelPercentCharW_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharW.Text, showMessage: true);
		}

		private void LabelPercentCharX_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharX.Text, showMessage: true);
		}

		private void LabelPercentCharY_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharY.Text, showMessage: true);
		}

		private void LabelPercentCharZ_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelPercentCharZ.Text, showMessage: true);
		}

		private void LabelCharPool_DoubleClick(object sender, EventArgs e)
		{
			CopyToClipboard(text: labelCharPool.Text, showMessage: true);
		}

		#endregion
	}
}