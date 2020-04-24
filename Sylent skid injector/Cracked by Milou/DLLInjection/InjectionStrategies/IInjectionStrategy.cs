using System;

namespace DLLInjection.InjectionStrategies
{
	// Token: 0x0200000F RID: 15
	internal interface IInjectionStrategy
	{
		// Token: 0x06000049 RID: 73
		IntPtr Inject(IntPtr processHandle, string dllPath);
	}
}
