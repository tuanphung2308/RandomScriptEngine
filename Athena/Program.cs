using System;
using System.Windows.Forms;

namespace Athena
{
	// Token: 0x02000020 RID: 32
	internal static class Program
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00005512 File Offset: 0x00003712
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
