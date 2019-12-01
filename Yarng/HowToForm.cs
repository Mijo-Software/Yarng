﻿using System;
using System.Windows.Forms;

namespace Yarng
{
	/// <summary>
	/// HowTo form
	/// </summary>
	public partial class HowToForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public HowToForm() => InitializeComponent();

		/// <summary>
		/// Load the HowTo form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void HowToForm_Load(object sender, EventArgs e) => richTextBox.SelectedRtf = Properties.Resources.howto;
	}
}
