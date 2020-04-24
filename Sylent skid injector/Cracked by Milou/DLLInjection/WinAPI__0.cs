using System;
using System.Runtime.InteropServices;

namespace DLLInjection
{
	// Token: 0x02000056 RID: 86
	internal static class WinAPI__0
	{
		// Token: 0x060002CA RID: 714
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(WinAPI__0.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		// Token: 0x060002CB RID: 715
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseHandle(IntPtr hObject);

		// Token: 0x060002CC RID: 716
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, WinAPI__0.AllocationType flAllocationType, WinAPI__0.MemoryProtection flProtect);

		// Token: 0x060002CD RID: 717
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x060002CE RID: 718
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x060002CF RID: 719
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x060002D0 RID: 720
		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x060002D1 RID: 721
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

		// Token: 0x0400012C RID: 300
		public const string KERNEL32_DLL = "kernel32.dll";

		// Token: 0x0400012D RID: 301
		public const string NTDLL_DLL = "ntdll.dll";

		// Token: 0x0400012E RID: 302
		public const string LOAD_LIBRARY_PROC = "LoadLibraryA";

		// Token: 0x0400012F RID: 303
		public const string NT_CREATE_THREAD_EX = "NtCreateThreadEx";

		// Token: 0x04000130 RID: 304
		public const uint INFINITE = 4294967295U;

		// Token: 0x04000131 RID: 305
		public const uint WAIT_ABANDONED = 128U;

		// Token: 0x04000132 RID: 306
		public const uint WAIT_OBJECT_0 = 0U;

		// Token: 0x04000133 RID: 307
		public const uint WAIT_TIMEOUT = 258U;

		// Token: 0x0200005B RID: 91
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x04000154 RID: 340
			All = 2035711U,
			// Token: 0x04000155 RID: 341
			Terminate = 1U,
			// Token: 0x04000156 RID: 342
			CreateThread = 2U,
			// Token: 0x04000157 RID: 343
			VirtualMemoryOperation = 8U,
			// Token: 0x04000158 RID: 344
			VirtualMemoryRead = 16U,
			// Token: 0x04000159 RID: 345
			VirtualMemoryWrite = 32U,
			// Token: 0x0400015A RID: 346
			DuplicateHandle = 64U,
			// Token: 0x0400015B RID: 347
			CreateProcess = 128U,
			// Token: 0x0400015C RID: 348
			SetQuota = 256U,
			// Token: 0x0400015D RID: 349
			SetInformation = 512U,
			// Token: 0x0400015E RID: 350
			QueryInformation = 1024U,
			// Token: 0x0400015F RID: 351
			QueryLimitedInformation = 4096U,
			// Token: 0x04000160 RID: 352
			Synchronize = 1048576U
		}

		// Token: 0x0200005A RID: 90
		[Flags]
		public enum AllocationType
		{
			// Token: 0x0400014A RID: 330
			Commit = 4096,
			// Token: 0x0400014B RID: 331
			Reserve = 8192,
			// Token: 0x0400014C RID: 332
			Decommit = 16384,
			// Token: 0x0400014D RID: 333
			Release = 32768,
			// Token: 0x0400014E RID: 334
			Reset = 524288,
			// Token: 0x0400014F RID: 335
			Physical = 4194304,
			// Token: 0x04000150 RID: 336
			TopDown = 1048576,
			// Token: 0x04000151 RID: 337
			WriteWatch = 2097152,
			// Token: 0x04000152 RID: 338
			LargePages = 536870912
		}

		// Token: 0x02000059 RID: 89
		[Flags]
		public enum MemoryProtection
		{
			// Token: 0x0400013E RID: 318
			Execute = 16,
			// Token: 0x0400013F RID: 319
			ExecuteRead = 32,
			// Token: 0x04000140 RID: 320
			ExecuteReadWrite = 64,
			// Token: 0x04000141 RID: 321
			ExecuteWriteCopy = 128,
			// Token: 0x04000142 RID: 322
			NoAccess = 1,
			// Token: 0x04000143 RID: 323
			ReadOnly = 2,
			// Token: 0x04000144 RID: 324
			ReadWrite = 4,
			// Token: 0x04000145 RID: 325
			WriteCopy = 8,
			// Token: 0x04000146 RID: 326
			GuardModifierflag = 256,
			// Token: 0x04000147 RID: 327
			NoCacheModifierflag = 512,
			// Token: 0x04000148 RID: 328
			WriteCombineModifierflag = 1024
		}

		// Token: 0x02000058 RID: 88
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct NtCreateThreadExBuffer
		{
			// Token: 0x04000134 RID: 308
			public int Size;

			// Token: 0x04000135 RID: 309
			public uint Unknown1;

			// Token: 0x04000136 RID: 310
			public uint Unknown2;

			// Token: 0x04000137 RID: 311
			public IntPtr Unknown3;

			// Token: 0x04000138 RID: 312
			public uint Unknown4;

			// Token: 0x04000139 RID: 313
			public uint Unknown5;

			// Token: 0x0400013A RID: 314
			public uint Unknown6;

			// Token: 0x0400013B RID: 315
			public IntPtr Unknown7;

			// Token: 0x0400013C RID: 316
			public uint Unknown8;
		}

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060002D3 RID: 723
		public delegate int NtCreateThreadEx(out IntPtr threadHandle, uint desiredAccess, IntPtr objectAttributes, IntPtr processHandle, IntPtr lpStartAddress, IntPtr lpParameter, int createSuspended, uint stackZeroBits, uint sizeOfStackCommit, uint sizeOfStackReserve, IntPtr lpBytesBuffer);
	}
}
