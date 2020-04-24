using System;
using System.Runtime.InteropServices;

namespace DLLInjection
{
	// Token: 0x0200000D RID: 13
	internal static class WinAPI
	{
		// Token: 0x0600003F RID: 63
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(WinAPI.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		// Token: 0x06000040 RID: 64
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseHandle(IntPtr hObject);

		// Token: 0x06000041 RID: 65
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, WinAPI.AllocationType flAllocationType, WinAPI.MemoryProtection flProtect);

		// Token: 0x06000042 RID: 66
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x06000043 RID: 67
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000044 RID: 68
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x06000045 RID: 69
		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x06000046 RID: 70
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

		// Token: 0x04000032 RID: 50
		public const string KERNEL32_DLL = "kernel32.dll";

		// Token: 0x04000033 RID: 51
		public const string NTDLL_DLL = "ntdll.dll";

		// Token: 0x04000034 RID: 52
		public const string LOAD_LIBRARY_PROC = "LoadLibraryA";

		// Token: 0x04000035 RID: 53
		public const string NT_CREATE_THREAD_EX = "NtCreateThreadEx";

		// Token: 0x04000036 RID: 54
		public const uint INFINITE = 4294967295U;

		// Token: 0x04000037 RID: 55
		public const uint WAIT_ABANDONED = 128U;

		// Token: 0x04000038 RID: 56
		public const uint WAIT_OBJECT_0 = 0U;

		// Token: 0x04000039 RID: 57
		public const uint WAIT_TIMEOUT = 258U;

		// Token: 0x02000013 RID: 19
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x0400003B RID: 59
			All = 2035711U,
			// Token: 0x0400003C RID: 60
			Terminate = 1U,
			// Token: 0x0400003D RID: 61
			CreateThread = 2U,
			// Token: 0x0400003E RID: 62
			VirtualMemoryOperation = 8U,
			// Token: 0x0400003F RID: 63
			VirtualMemoryRead = 16U,
			// Token: 0x04000040 RID: 64
			VirtualMemoryWrite = 32U,
			// Token: 0x04000041 RID: 65
			DuplicateHandle = 64U,
			// Token: 0x04000042 RID: 66
			CreateProcess = 128U,
			// Token: 0x04000043 RID: 67
			SetQuota = 256U,
			// Token: 0x04000044 RID: 68
			SetInformation = 512U,
			// Token: 0x04000045 RID: 69
			QueryInformation = 1024U,
			// Token: 0x04000046 RID: 70
			QueryLimitedInformation = 4096U,
			// Token: 0x04000047 RID: 71
			Synchronize = 1048576U
		}

		// Token: 0x02000014 RID: 20
		[Flags]
		public enum AllocationType
		{
			// Token: 0x04000049 RID: 73
			Commit = 4096,
			// Token: 0x0400004A RID: 74
			Reserve = 8192,
			// Token: 0x0400004B RID: 75
			Decommit = 16384,
			// Token: 0x0400004C RID: 76
			Release = 32768,
			// Token: 0x0400004D RID: 77
			Reset = 524288,
			// Token: 0x0400004E RID: 78
			Physical = 4194304,
			// Token: 0x0400004F RID: 79
			TopDown = 1048576,
			// Token: 0x04000050 RID: 80
			WriteWatch = 2097152,
			// Token: 0x04000051 RID: 81
			LargePages = 536870912
		}

		// Token: 0x02000015 RID: 21
		[Flags]
		public enum MemoryProtection
		{
			// Token: 0x04000053 RID: 83
			Execute = 16,
			// Token: 0x04000054 RID: 84
			ExecuteRead = 32,
			// Token: 0x04000055 RID: 85
			ExecuteReadWrite = 64,
			// Token: 0x04000056 RID: 86
			ExecuteWriteCopy = 128,
			// Token: 0x04000057 RID: 87
			NoAccess = 1,
			// Token: 0x04000058 RID: 88
			ReadOnly = 2,
			// Token: 0x04000059 RID: 89
			ReadWrite = 4,
			// Token: 0x0400005A RID: 90
			WriteCopy = 8,
			// Token: 0x0400005B RID: 91
			GuardModifierflag = 256,
			// Token: 0x0400005C RID: 92
			NoCacheModifierflag = 512,
			// Token: 0x0400005D RID: 93
			WriteCombineModifierflag = 1024
		}

		// Token: 0x02000016 RID: 22
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct NtCreateThreadExBuffer
		{
			// Token: 0x0400005E RID: 94
			public int Size;

			// Token: 0x0400005F RID: 95
			public uint Unknown1;

			// Token: 0x04000060 RID: 96
			public uint Unknown2;

			// Token: 0x04000061 RID: 97
			public IntPtr Unknown3;

			// Token: 0x04000062 RID: 98
			public uint Unknown4;

			// Token: 0x04000063 RID: 99
			public uint Unknown5;

			// Token: 0x04000064 RID: 100
			public uint Unknown6;

			// Token: 0x04000065 RID: 101
			public IntPtr Unknown7;

			// Token: 0x04000066 RID: 102
			public uint Unknown8;
		}

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000051 RID: 81
		public delegate int NtCreateThreadEx(out IntPtr threadHandle, uint desiredAccess, IntPtr objectAttributes, IntPtr processHandle, IntPtr lpStartAddress, IntPtr lpParameter, int createSuspended, uint stackZeroBits, uint sizeOfStackCommit, uint sizeOfStackReserve, IntPtr lpBytesBuffer);
	}
}
