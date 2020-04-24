using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sylent_Injector
{
	// Token: 0x0200004C RID: 76
	public partial class Loader__0 : Form
	{
		// Token: 0x06000295 RID: 661
		public extern Loader__0();

		// Token: 0x06000296 RID: 662
		private extern void wait_Tick(object sender, EventArgs e);

		// Token: 0x06000297 RID: 663
		public extern bool IsOnline();

		// Token: 0x06000298 RID: 664
		private extern void DownloadFont();

		// Token: 0x06000299 RID: 665
		protected override extern void Dispose(bool disposing);

		// Token: 0x0600029A RID: 666
		private extern void InitializeComponent();

		// Token: 0x04000101 RID: 257
		private string TargetFolder;

		// Token: 0x04000102 RID: 258
		private IContainer components;

		// Token: 0x04000103 RID: 259
		private PictureBox pictureBox1;

		// Token: 0x04000104 RID: 260
		public Timer wait;
	}
}
