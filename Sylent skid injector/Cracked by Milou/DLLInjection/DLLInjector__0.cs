using System;
using DLLInjection.InjectionStrategies;

namespace DLLInjection
{
	// Token: 0x02000052 RID: 82
	public class DLLInjector__0
	{
		// Token: 0x060002C3 RID: 707
		public extern DLLInjector__0(InjectionMethod__0 injectionMethod);

		// Token: 0x060002C4 RID: 708
		public extern void Inject(int pid, string pathToDll, InjectionOptions__0 injectionOptions = null);

		// Token: 0x04000127 RID: 295
		private IInjectionStrategy__0 _injectionStrategy;
	}
}
