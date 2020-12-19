using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Yarng
{
	/// <summary>
	/// History form
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	internal partial class HistoryForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public HistoryForm() => InitializeComponent();

		/// <summary>
		/// Load the history form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void HistoryForm_Load(object sender, EventArgs e) => richTextBox.SelectedRtf = Properties.Resources.history;

		private string GetDebuggerDisplay()
		{
			return ToString();
		}
	}
}