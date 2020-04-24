using System;
using DLLInjection.InjectionStrategies;

namespace DLLInjection
{
	// Token: 0x02000009 RID: 9
	public class DLLInjector
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00004753 File Offset: 0x00002753
		public DLLInjector(InjectionMethod injectionMethod)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004768 File Offset: 0x00002768
		public void Inject(int pid, string pathToDll, InjectionOptions injectionOptions = null)
		{
		}

		// Token: 0x0400002D RID: 45
		private IInjectionStrategy _injectionStrategy;
	}
}
