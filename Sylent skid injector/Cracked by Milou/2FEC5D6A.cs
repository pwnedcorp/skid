using System;
using System.Runtime.InteropServices;

// Token: 0x0200001E RID: 30
internal static class 2FEC5D6A
{
	// Token: 0x060000CF RID: 207
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFile", SetLastError = true)]
	public static extern IntPtr 4293671F(string 6E484E83, int 44BA524D, int 7A216D6F, IntPtr 7DD54DA3, int 5B637A17, int 47CD1C25, IntPtr 75E076DA);

	// Token: 0x060000D0 RID: 208
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFileMapping", SetLastError = true)]
	public static extern IntPtr 66912569(IntPtr 521D4BB2, IntPtr 0B081E32, 2FEC5D6A.4CBF377C 30E01543, int 5002707F, int 438C78CE, string 29FC4F06);

	// Token: 0x060000D1 RID: 209
	[DllImport("kernel32", EntryPoint = "MapViewOfFile", SetLastError = true)]
	public static extern IntPtr 13BE6D47(IntPtr 73DC506A, 2FEC5D6A.71F10131 04BF4839, int 610E1EB3, int 77867939, IntPtr 4B4F1C70);

	// Token: 0x060000D2 RID: 210
	[DllImport("kernel32", EntryPoint = "UnmapViewOfFile", SetLastError = true)]
	public static extern bool 631417F8(IntPtr 2C102899);

	// Token: 0x060000D3 RID: 211
	[DllImport("kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool 7A975CCA(IntPtr 53744973);

	// Token: 0x060000D4 RID: 212
	[DllImport("kernel32", EntryPoint = "GetFileSize", SetLastError = true)]
	public static extern uint 2E304F6C(IntPtr 3BF47E65, IntPtr 62EA04C1);

	// Token: 0x060000D5 RID: 213
	[DllImport("kernel32", EntryPoint = "VirtualProtect", SetLastError = true)]
	public static extern bool 3384405A(IntPtr 78357D62, UIntPtr 4FF06FF3, 2FEC5D6A.4CBF377C 4F162198, out 2FEC5D6A.4CBF377C 120321DC);

	// Token: 0x060000D6 RID: 214
	[DllImport("kernel32", EntryPoint = "IsDebuggerPresent")]
	public static extern bool 5FE1308B();

	// Token: 0x060000D7 RID: 215
	[DllImport("kernel32", EntryPoint = "CheckRemoteDebuggerPresent")]
	public static extern bool 0DD36E95();

	// Token: 0x060000D8 RID: 216
	[DllImport("ntdll", EntryPoint = "NtQueryInformationProcess")]
	public static extern int 6F2E1EB7(IntPtr 442F480E, int 1A9A6C6C, byte[] 2EC143D5, uint 261439D4, out uint 32474447);

	// Token: 0x0400007A RID: 122
	public const int 18EF44EB = -2147483648;

	// Token: 0x0400007B RID: 123
	public const int 254D7091 = 3;

	// Token: 0x0400007C RID: 124
	public const int 3D3A30D1 = 128;

	// Token: 0x0400007D RID: 125
	public const int 5A855C6F = 1;

	// Token: 0x0400007E RID: 126
	public const int 744D43D2 = 2;

	// Token: 0x0400007F RID: 127
	public static readonly IntPtr 00183A37 = new IntPtr(-1);

	// Token: 0x04000080 RID: 128
	public static readonly IntPtr 30B7498D = IntPtr.Zero;

	// Token: 0x04000081 RID: 129
	public static readonly IntPtr 093A6E19 = new IntPtr(-1);

	// Token: 0x02000045 RID: 69
	public enum 4CBF377C : uint
	{
		// Token: 0x040000E0 RID: 224
		0B72117E = 1U,
		// Token: 0x040000E1 RID: 225
		5061459A,
		// Token: 0x040000E2 RID: 226
		217727B7 = 4U,
		// Token: 0x040000E3 RID: 227
		22213B52 = 8U,
		// Token: 0x040000E4 RID: 228
		06A40F6D = 16U,
		// Token: 0x040000E5 RID: 229
		668037EF = 32U,
		// Token: 0x040000E6 RID: 230
		7EE17AC1 = 64U,
		// Token: 0x040000E7 RID: 231
		4DAD1734 = 256U
	}

	// Token: 0x02000046 RID: 70
	public enum 71F10131 : uint
	{
		// Token: 0x040000E9 RID: 233
		758F5161 = 1U,
		// Token: 0x040000EA RID: 234
		10491867,
		// Token: 0x040000EB RID: 235
		3DBD301B = 4U,
		// Token: 0x040000EC RID: 236
		1F92746B = 31U
	}
}
