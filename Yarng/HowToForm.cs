using System;
using System.Windows.Forms;

namespace Yarng
{
	public partial class HowToForm : Form
	{
		public HowToForm()
		{
			InitializeComponent();
		}

		private void HowToForm_Load(object sender, EventArgs e)
		{
			richTextBox.SelectedRtf = Properties.Resources.howto;
		}
	}
}
