using System;

namespace DLLInjection.InjectionStrategies
{
	// Token: 0x0200005C RID: 92
	internal class CreateRemoteThreadInjectionStrategy__0 : LoadLibraryInjectionStrategyBase__0
	{
		// Token: 0x060002D6 RID: 726
		protected override extern IntPtr Inject(IntPtr processHandle, IntPtr loadLibraryAddress, IntPtr addressOfDllPath);

		// Token: 0x060002D7 RID: 727
		public extern CreateRemoteThreadInjectionStrategy__0();
	}
}
