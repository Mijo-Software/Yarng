using MijoSoftware.AssemblyInformation;
using System;
using System.Windows.Forms;

namespace Yarng
{
	/// <summary>
	/// AboutForm
	/// </summary>
	internal partial class AboutForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AboutForm() => InitializeComponent();

		/// <summary>
		/// Load the AboutForm
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void AboutForm_Load(object sender, EventArgs e)
		{
			Text = $"Info about {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}
	}
}
