using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sylent_Injector
{
	// Token: 0x0200004B RID: 75
	public partial class SelectGameType__0 : Form
	{
		// Token: 0x0600028D RID: 653
		public extern SelectGameType__0();

		// Token: 0x0600028E RID: 654
		private extern void SteamVersion_Click(object sender, EventArgs e);

		// Token: 0x0600028F RID: 655
		private extern void SCVersion_Click(object sender, EventArgs e);

		// Token: 0x06000290 RID: 656
		private extern string SelectGTA();

		// Token: 0x06000291 RID: 657
		private extern void CloseBTN_Click(object sender, EventArgs e);

		// Token: 0x06000292 RID: 658
		private extern void CloseTimer_Tick(object sender, EventArgs e);

		// Token: 0x06000293 RID: 659
		protected override extern void Dispose(bool disposing);

		// Token: 0x06000294 RID: 660
		private extern void InitializeComponent();

		// Token: 0x040000FB RID: 251
		private string TargetFolder;

		// Token: 0x040000FC RID: 252
		private IContainer components;

		// Token: 0x040000FD RID: 253
		private PictureBox SteamVersion;

		// Token: 0x040000FE RID: 254
		private PictureBox SCVersion;

		// Token: 0x040000FF RID: 255
		private Button CloseBTN;

		// Token: 0x04000100 RID: 256
		private Timer CloseTimer;
	}
}
