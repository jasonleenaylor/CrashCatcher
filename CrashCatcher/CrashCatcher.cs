using System;
using System.Windows.Forms;

namespace CrashCatcher
{
	/// <summary>
	/// This program is built to try and extract as much error information as possible from a program that crashes
	/// on start-up with errors like FileLoadException where all you get is a windows event log message with
	/// no useful info.
	/// </summary>
	static class CrashCatcher
	{
		/// <summary/>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DropWindow());
		}
	}
}
