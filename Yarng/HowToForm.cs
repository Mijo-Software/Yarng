using System;
using System.Windows.Forms;
using Yarng.Properties;

namespace Yarng
{
	/// <summary>
	/// HowTo form
	/// </summary>
	public partial class HowToForm : Form
	{
		/// <summary>
		/// Settings
		/// </summary>
		private readonly Settings settings = new Settings();

		/// <summary>
		/// Load the Fatcow icon theme
		/// </summary>
		private void LoadFatcowIcons() => okButton.Image = Resources.fatcow_accept_16;

		/// <summary>
		/// Load the Fugue icon theme
		/// </summary>
		private void LoadFugueIcons() => okButton.Image = Resources.fugue_tick_circle_16;

		/// <summary>
		/// Load the Silk icon theme
		/// </summary>
		private void LoadSilkIcons() => okButton.Image = Resources.silk_accept_16;

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
		private void HowToForm_Load(object sender, EventArgs e)
		{
			richTextBox.SelectedRtf = Resources.howto;
			switch (settings.userIconSet)
			{
				default: LoadFatcowIcons(); break;
				case "fugue": LoadFugueIcons(); break;
				case "silk": LoadSilkIcons(); break;
			}
		}
	}
}
