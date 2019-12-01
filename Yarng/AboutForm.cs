using MijoSoftware.AssemblyInformation;
using System;
using System.Windows.Forms;

namespace Yarng
{
	internal partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			Text = $"Info about {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
		}
	}
}
