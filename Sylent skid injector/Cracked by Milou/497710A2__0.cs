using System;

// Token: 0x02000062 RID: 98
public class 497710A2__0
{
	// Token: 0x060002E1 RID: 737
	public 497710A2__0()
	{
		this.440561FF = 1940661593U;
	}

	// Token: 0x060002E2 RID: 738
	public uint 529E3E21(uint 3F6027BE)
	{
		uint num = 3F6027BE ^ this.440561FF;
		this.440561FF = (16D25689__0.1D82142A(this.440561FF, 7) ^ num);
		return num;
	}

	// Token: 0x04000162 RID: 354
	private uint 440561FF;
}
