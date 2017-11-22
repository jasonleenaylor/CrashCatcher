using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CrashCatcher
{
	public partial class DropWindow : Form
	{
		public DropWindow()
		{
			InitializeComponent();
			components = new Container();
		}

		private void OnDrop(object sender, DragEventArgs e)
		{
			var dropData = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
			var pi = new ProcessStartInfo(dropData)
			{
				WorkingDirectory = Path.GetDirectoryName(dropData),
				RedirectStandardError = true,
				UseShellExecute = false
			};
			try
			{
				var process = Process.Start(pi);
				process.WaitForExit();
				if (process.ExitCode == 0)
				{
					resultsBox.Text = "Looks like it worked.";
				}
				else
				{
					resultsBox.Text = "Something blew up." + Environment.NewLine + process.StandardError.ReadToEnd(); 
				}
			}
			catch (Exception crash)
			{
				var realCrash = crash.InnerException;
				if (realCrash == null)
					realCrash = crash;
				resultsBox.Text = realCrash.Message + Environment.NewLine + realCrash.StackTrace;
				Refresh();
			}
		}

		private void DropWindow_DragEnter(object sender, DragEventArgs e)
		{
			resultsBox.Text = string.Empty;
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				var dropData = (string[])e.Data.GetData(DataFormats.FileDrop);
				if (dropData.Length == 1 && dropData[0].EndsWith(".exe"))
				{
					e.Effect = DragDropEffects.Copy;
				}
				else
				{
					resultsBox.Text = "Drop one .exe file here at a time.";
				}
			}
		}

		private void DropWindow_DragLeave(object sender, EventArgs e)
		{
		}
	}
}
