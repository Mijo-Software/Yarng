using System;
using System.Windows.Forms;

namespace Yarng
{
	public partial class HistoryForm : Form
	{
		public HistoryForm()
		{
			InitializeComponent();
		}

		private void HistoryForm_Load(object sender, EventArgs e)
		{
			richTextBox.SelectedRtf = Properties.Resources.history;
		}
	}
}
