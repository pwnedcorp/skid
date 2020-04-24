using System;

namespace DLLInjection.InjectionStrategies
{
	// Token: 0x02000011 RID: 17
	internal abstract class LoadLibraryInjectionStrategyBase : IInjectionStrategy
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000048E8 File Offset: 0x000028E8
		public IntPtr Inject(IntPtr processHandle, string dllPath)
		{
		}

		// Token: 0x0600004C RID: 76
		protected abstract IntPtr Inject(IntPtr processHandle, IntPtr loadLibraryAddress, IntPtr addressOfDllPath);
	}
}
