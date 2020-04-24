using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using LauncherHypno.Properties;

namespace LauncherHypno
{
	// Token: 0x02000002 RID: 2
	public partial class HypnoLauncher : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public HypnoLauncher()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205E File Offset: 0x0000025E
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.io/HypnoMenu");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206B File Offset: 0x0000026B
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://discord.io/HypnoMenu");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002078 File Offset: 0x00000278
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("https://HypnoMenu.tk");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002088 File Offset: 0x00000288
		private void button1_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory("C:\\Hypno");
			Directory.CreateDirectory("C:\\Hypno\\ASI");
			Directory.CreateDirectory("C:\\Hypno\\R-ID-Database");
			File.Delete("Hypnp.conf");
			string fileName = "Hypno.dll";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("http://hypnomenu.tk/Launcher/Hypno.dll", fileName);
			string fileName2 = "C:\\Hypno/Hypno.ytd";
			webClient.DownloadFile("http://hypnomenu.tk/Launcher/Hypno.ytd", fileName2);
			string fileName3 = "injector.exe";
			webClient.DownloadFile("http://hypnomenu.tk/Launcher/injector.exe", fileName3);
			Directory.CreateDirectory("C:\\Windows/Temp/tw-34423-39154-1e5a932312.tmp");
			string fileName4 = "C:\\Windows/Temp/tw-34423-39154-1e5a932312.tmp/ScriptHookV.dll";
			webClient.DownloadFile("http://hypnomenu.tk/Launcher/Launcher.exe.mui", fileName4);
			Process.Start("injector.exe");
		}
	}
}
