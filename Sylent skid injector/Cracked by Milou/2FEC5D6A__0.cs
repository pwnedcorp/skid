using System;
using System.Runtime.InteropServices;

// Token: 0x02000087 RID: 135
internal static class 2FEC5D6A__0
{
	// Token: 0x060004D8 RID: 1240
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFile", SetLastError = true)]
	public static extern IntPtr 4293671F(string 6E484E83, int 44BA524D, int 7A216D6F, IntPtr 7DD54DA3, int 5B637A17, int 47CD1C25, IntPtr 75E076DA);

	// Token: 0x060004D9 RID: 1241
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFileMapping", SetLastError = true)]
	public static extern IntPtr 66912569(IntPtr 521D4BB2, IntPtr 0B081E32, 2FEC5D6A__0.4CBF377C 30E01543, int 5002707F, int 438C78CE, string 29FC4F06);

	// Token: 0x060004DA RID: 1242
	[DllImport("kernel32", EntryPoint = "MapViewOfFile", SetLastError = true)]
	public static extern IntPtr 13BE6D47(IntPtr 73DC506A, 2FEC5D6A__0.71F10131 04BF4839, int 610E1EB3, int 77867939, IntPtr 4B4F1C70);

	// Token: 0x060004DB RID: 1243
	[DllImport("kernel32", EntryPoint = "UnmapViewOfFile", SetLastError = true)]
	public static extern bool 631417F8(IntPtr 2C102899);

	// Token: 0x060004DC RID: 1244
	[DllImport("kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool 7A975CCA(IntPtr 53744973);

	// Token: 0x060004DD RID: 1245
	[DllImport("kernel32", EntryPoint = "GetFileSize", SetLastError = true)]
	public static extern uint 2E304F6C(IntPtr 3BF47E65, IntPtr 62EA04C1);

	// Token: 0x060004DE RID: 1246
	[DllImport("kernel32", EntryPoint = "VirtualProtect", SetLastError = true)]
	public static extern bool 3384405A(IntPtr 78357D62, UIntPtr 4FF06FF3, 2FEC5D6A__0.4CBF377C 4F162198, out 2FEC5D6A__0.4CBF377C 120321DC);

	// Token: 0x060004DF RID: 1247
	[DllImport("kernel32", EntryPoint = "IsDebuggerPresent")]
	public static extern bool 5FE1308B();

	// Token: 0x060004E0 RID: 1248
	[DllImport("kernel32", EntryPoint = "CheckRemoteDebuggerPresent")]
	public static extern bool 0DD36E95();

	// Token: 0x060004E1 RID: 1249
	[DllImport("ntdll", EntryPoint = "NtQueryInformationProcess")]
	public static extern int 6F2E1EB7(IntPtr 442F480E, int 1A9A6C6C, byte[] 2EC143D5, uint 261439D4, out uint 32474447);

	// Token: 0x0400019D RID: 413
	public const int 18EF44EB = -2147483648;

	// Token: 0x0400019E RID: 414
	public const int 254D7091 = 3;

	// Token: 0x0400019F RID: 415
	public const int 3D3A30D1 = 128;

	// Token: 0x040001A0 RID: 416
	public const int 5A855C6F = 1;

	// Token: 0x040001A1 RID: 417
	public const int 744D43D2 = 2;

	// Token: 0x040001A2 RID: 418
	public static readonly IntPtr 00183A37 = new IntPtr(-1);

	// Token: 0x040001A3 RID: 419
	public static readonly IntPtr 30B7498D = IntPtr.Zero;

	// Token: 0x040001A4 RID: 420
	public static readonly IntPtr 093A6E19 = new IntPtr(-1);

	// Token: 0x02000089 RID: 137
	public enum 4CBF377C : uint
	{
		// Token: 0x040001AB RID: 427
		0B72117E = 1U,
		// Token: 0x040001AC RID: 428
		5061459A,
		// Token: 0x040001AD RID: 429
		217727B7 = 4U,
		// Token: 0x040001AE RID: 430
		22213B52 = 8U,
		// Token: 0x040001AF RID: 431
		06A40F6D = 16U,
		// Token: 0x040001B0 RID: 432
		668037EF = 32U,
		// Token: 0x040001B1 RID: 433
		7EE17AC1 = 64U,
		// Token: 0x040001B2 RID: 434
		4DAD1734 = 256U
	}

	// Token: 0x02000088 RID: 136
	public enum 71F10131 : uint
	{
		// Token: 0x040001A6 RID: 422
		758F5161 = 1U,
		// Token: 0x040001A7 RID: 423
		10491867,
		// Token: 0x040001A8 RID: 424
		3DBD301B = 4U,
		// Token: 0x040001A9 RID: 425
		1F92746B = 31U
	}
}
