using System;
using System.Windows.Forms;

namespace LauncherHypno
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000024E7 File Offset: 0x000006E7
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new HypnoLauncher());
		}
	}
}
