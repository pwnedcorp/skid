using System;

namespace DLLInjection.InjectionStrategies
{
	// Token: 0x0200000E RID: 14
	internal class CreateRemoteThreadInjectionStrategy : LoadLibraryInjectionStrategyBase
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00004882 File Offset: 0x00002882
		protected override IntPtr Inject(IntPtr processHandle, IntPtr loadLibraryAddress, IntPtr addressOfDllPath)
		{
		}
	}
}
