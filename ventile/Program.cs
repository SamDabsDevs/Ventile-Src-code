using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ventile_Client
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			if ((int)Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length <= 1)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new home());
			}
		}
	}
}