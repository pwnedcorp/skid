using System;

namespace DLLInjection.InjectionStrategies
{
	// Token: 0x0200005F RID: 95
	internal abstract class LoadLibraryInjectionStrategyBase__0 : IInjectionStrategy__0
	{
		// Token: 0x060002DA RID: 730
		public extern IntPtr Inject(IntPtr processHandle, string dllPath);

		// Token: 0x060002DB RID: 731
		protected abstract IntPtr Inject(IntPtr processHandle, IntPtr loadLibraryAddress, IntPtr addressOfDllPath);

		// Token: 0x060002DC RID: 732
		protected extern LoadLibraryInjectionStrategyBase__0();
	}
}
