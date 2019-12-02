using System;
using System.Windows.Forms;

namespace Yarng
{
	/// <summary>
	/// Program
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// Main entrance of the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using MainForm mainWindow = new MainForm();
			Application.Run(mainForm: mainWindow);
		}
	}
}
